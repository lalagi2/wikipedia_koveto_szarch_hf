using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wikipedia_koveto.Model;

namespace wikipedia_koveto
{
    static class Program
    {
        static void checkForDifferencesAndSendEmail(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += checkForDifferencesAndSendEmail;
            timer.Start();

            // Test email
            //EmailSender emailSender = new EmailSender();
            //emailSender.sendEmail("tothlajosg@gmail.com", "toth lajos", "subject", "uzenet");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.SimpleUserForm("User1"));

            // Test Database
            using (UserDataEntities dc = new UserDataEntities())
            {
                var users = from user in dc.Users select new { user.UserName, user.Email };
                foreach (var user in users)
                {
                    Console.WriteLine("( " + user.UserName + ", " + user.Email + " )");
                }

                var groups = from page in dc.Pages where page.UserName.Contains("User1")
                            group page by page.UserName into g
                            select g;
                foreach (var g in groups)
                {
                    Console.WriteLine(g.Key);
                    foreach (var page in g)
                    {
                        Console.WriteLine("   {0}, {1}, {2}, {3}", page.WikiPage, page.Sensitivity, page.NotificationNumber, page.RefreshRate);
                    }
                }
            }
        }
    }
}
