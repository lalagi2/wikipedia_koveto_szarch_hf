using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using wikipedia_koveto.Model;
using wikipedia_koveto.WikipediaAPI;

namespace wikipedia_koveto
{
    class WikipediaPoller
    {
        private bool running = true;
        private Object thisLock = new Object();
        private DateTime date;

        public WikipediaPoller()
        {
            using (UserDataEntities dc = new UserDataEntities())
            {
                var pages = from page in dc.Pages
                                where page.LastNotified == null
                                || page.LastNotified.Value != DateTime.Today
                                select page;
                foreach (var page in pages)
                {
                    page.LastNotified = DateTime.Today;
                    page.Notified = 0;
                }
                date = DateTime.Today;
                dc.SaveChanges();
            }
        }

        private void updateNotifications()
        {
            using (UserDataEntities dc = new UserDataEntities())
            {
                var pages = from page in dc.Pages
                                select page;
                foreach(var page in pages)
                {
                    page.LastNotified = DateTime.Today;
                    page.Notified = 0;
                }

                dc.SaveChanges();
            }

            date = DateTime.Today;
        }

        public void poll()
        {
            int milisec = 60000;
            while (true)
            {
                lock (thisLock)
                {
                    if (!running)
                    {
                        break;
                    }
                }
                if (milisec >= 60000)
                {
                    milisec = 0;
                    if (date != DateTime.Today)
                        updateNotifications();

                    using (UserDataEntities dc = new UserDataEntities())
                    {
                        var pages = from user in dc.Users
                                    join page in dc.Pages on user.UserName equals page.UserName
                                    select new { user.UserName, user.NotificationPerDay, user.Email, page.Id, page.WikiPage, page.Sensitivity, page.RefreshRate, page.LastRefreshed, page.Notified, page.LastRevision };

                        var threads = new List<Thread>();

                        foreach (var page in pages)
                        {
                            if (page.Notified == page.NotificationPerDay)
                            {
                                // User reached notification limit
                                continue;
                            }
                            if (page.LastRefreshed == null || (DateTime.Now - page.LastRefreshed.Value).TotalMilliseconds >= page.RefreshRate * 60000)
                            {
                                var t = new Thread(() => checkAndUpdateWikiPage(page.Id, page.WikiPage, page.Sensitivity, page.Email, page.LastRevision));
                                threads.Add(t);
                                t.Start();
                            }
                            foreach (var t in threads)
                            {
                                t.Join();
                            }
                        }
                    }
                }
                Thread.Sleep(10); // 1 minutes
                milisec += 10;
            }
        }

        private void checkAndUpdateWikiPage(int id, string page, int sens, string email, int currentRevId)
        {
            Console.WriteLine("Need to update {0} {1} {2}!", id, page, DateTime.Now.Minute);
            WikiAPI api = new WikiAPI();
            var revID = api.GetRevisions(page, currentRevId).OrderBy(x => x.RevId).Last().RevId;
            Console.WriteLine("    RevID: {0} current: {1}", revID, currentRevId);
            Console.WriteLine("    RevID: {0}", api.GetRevisions(page, currentRevId).OrderBy(x => x.RevId).First().RevId);
        }

        public void stop()
        {
            lock (thisLock)
            {
                running = false;
            }
        }
    }
}
