using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wikipedia_koveto.Model;
using System.Threading;
using System.Security.Cryptography;
using System.Text;

namespace wikipedia_koveto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var poller = new WikipediaPoller();
            var pollerThread = new Thread(() => poller.poll());
            pollerThread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            poller.stop();
            pollerThread.Join();
        }
    }
}
