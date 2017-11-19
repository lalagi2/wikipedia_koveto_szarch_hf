using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using wikipedia_koveto.Model;
using wikipedia_koveto.WikipediaAPI;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace wikipedia_koveto
{
    class PageReadData
    {
        public string UserName { get; set; }
        public int NotificationPerDay { get; set; }
        public string Email { get; set; }
        public int PageId { get; set; }
        public string WikiPage { get; set; }
        public int Sensitivity { get; set; }
        public int RefreshRate { get; set; }
        public DateTime LastRefreshed { get; set; }
        public int Notified { get; set; }
        public int LastRevision { get; set; }
    }
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
                    page.Notified = 0;
                }

                dc.SaveChanges();
            }

            date = DateTime.Today;
        }

        public void poll()
        {
            long milisec = 60000;
            while (true)
            {
                // Check running flag in every 20 miliseconds
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

                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    long ellapsed = 0;
                    List<PageReadData> pages;
                    using (UserDataEntities dc = new UserDataEntities())
                    {
                        pages = (from user in dc.Users
                                 join page in dc.Pages on user.UserName equals page.UserName
                                 select new PageReadData {
                                        UserName = user.UserName,
                                        NotificationPerDay = user.NotificationPerDay,
                                        Email = user.Email,
                                        PageId = page.Id,
                                        WikiPage = page.WikiPage,
                                        Sensitivity = page.Sensitivity,
                                        RefreshRate = page.RefreshRate,
                                        LastRefreshed = page.LastRefreshed != null ? page.LastRefreshed.Value : DateTime.MinValue,
                                        Notified = page.Notified,
                                        LastRevision = page.LastRevision
                                 }).ToList();
                    }
                    var threads = new List<Thread>();
                    foreach (var page in pages)
                    {
                        // Measure time, and check in every 20 miliseconds if the app has been closed
                        // This is necessary to don't wait for working thread on exit
                        sw.Stop();
                        if (sw.ElapsedMilliseconds > 20)
                        {
                            lock (thisLock)
                            {
                                if (!running)
                                {
                                    break;
                                }
                            }
                            ellapsed = sw.ElapsedMilliseconds;
                            sw.Reset();
                        }
                        sw.Start();
                        if (page.Notified == page.NotificationPerDay)
                        {
                            // User reached notification limit
                            continue;
                        }
                        if (page.LastRefreshed == null || (DateTime.Now - page.LastRefreshed).TotalMilliseconds >= page.RefreshRate * 60000)
                        {
                            var t = new Thread(() => checkAndUpdateWikiPage(page));
                            threads.Add(t);
                            t.Start();
                        }
                        foreach (var t in threads)
                        {
                            t.Join();
                        }
                    }
                    sw.Stop();
                    sw.Reset();
                    // Start on ellapsed milliseconds, that way if ellapsed time less then 60000 miliseconds
                    // then there is no plus sleep time
                    milisec = ellapsed;
                }
                if (milisec < 60000)
                {
                    Thread.Sleep(20); // 1 minutes
                    milisec += 20;
                }
            }
        }

        private void sendEmail(PageReadData data)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.sendEmail(data.Email, data.UserName, data.WikiPage + " Wikipedia page has been changed", 
                "Dear " + data.UserName + "!\n\n" +
                "A wikipedia page followed by you has been changed:\n" +
                "https://en.wikipedia.org/wiki/" + data.WikiPage + "\n\n\n" +
                "Regards,\n" + 
                "The Wikipedia Follower Team"
                );
            Console.WriteLine("Email has been sent to " + data.Email);
        }

        private void refreshDatabase(PageReadData data, bool notified = false, int revID = -1)
        {
            using (UserDataEntities dc = new UserDataEntities())
            {
                var currentPage = from page in dc.Pages
                                  where page.Id == data.PageId
                                  select page;
                try
                {
                    var page = currentPage.First();
                    if (notified)
                    {
                        // If user has been notified
                        page.LastRevision = revID;
                        page.LastNotified = DateTime.Now;
                    }
                    page.LastRefreshed = DateTime.Now;

                    dc.SaveChanges();
                }
                catch (ArgumentNullException exp)
                {
                    Console.WriteLine("Error: " + exp.Message + "\n\t Possibly wrong page id.");
                }
            }
        }

        private void checkAndUpdateWikiPage(PageReadData data)
        {

            // First check revID
            WikiAPI api = new WikiAPI();
            var revIDs = api.GetRevisions(data.WikiPage, data.LastRevision).OrderBy(x => x.RevId).ToList();
            if (revIDs.Count <= 1)
            {
                // No newer revID
                return;
            }

            var currentRevID = revIDs.Last().RevId;

            if (data.LastRevision == -1)
            {
                // First check send email
                sendEmail(data);
                refreshDatabase(data, true, currentRevID);
                return;
            }
            
            string currentPageContent = api.GetContent(data.WikiPage, currentRevID);
            string prevPageContent = api.GetContent(data.WikiPage, data.LastRevision);

            MatchCollection words1 = Regex.Matches(currentPageContent, @"\b(\w+)\b");
            MatchCollection words2 = Regex.Matches(prevPageContent, @"\b(\w+)\b");

            var hs1 = new HashSet<string>(words1.Cast<Match>().Select(m => m.Value));
            var hs2 = new HashSet<string>(words2.Cast<Match>().Select(m => m.Value));

            var hs1_mod = new HashSet<string>(hs1);
            var hs2_mod = new HashSet<string>(hs2);

            hs2_mod.ExceptWith(hs1);
            int prevVersionExtraWordCounter = hs2_mod.Count;
            hs1_mod.ExceptWith(hs2);
            int newVersionExtraWordCounter = hs1_mod.Count;

            // Calculate diff, if bigger then sensititvity, then send email
            if (newVersionExtraWordCounter + prevVersionExtraWordCounter > data.Sensitivity)
            {
                sendEmail(data);
                refreshDatabase(data, true, currentRevID);
            }
            else
            {
                refreshDatabase(data);
            }
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
