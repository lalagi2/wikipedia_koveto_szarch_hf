using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wikipedia_koveto.Model;

namespace wikipedia_koveto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool userFound = false;

            using (UserDataEntities dc = new UserDataEntities())
            {
                var users = from user in dc.Users select new { user.UserName, user.Email, user.IsAdmin, user.UserPass };
                foreach (var user in users)
                {
                   // Console.WriteLine("( " + user.UserName + ", " + user.Email + " " + user.UserPass);
                    if (userNameTextBox.Text == user.UserName && passwordTextBox.Text == user.UserPass)
                    {
                        userFound = true;
                        if (user.IsAdmin)
                        {
                            // Elugrunk az admin windowra
                            Console.WriteLine("login OK admin");
                        }
                        else
                        {
                            // Elugurnk a sima wiondowra
                            Console.WriteLine("login OK sima");
                        }
                    }
                }


                if (!userFound)
                {
                    MessageBox.Show("Invalid username or password");
                }

                //var groups = from page in dc.Pages
                //             group page by page.UserName into g
                //             select g;
                //foreach (var g in groups)
                //{
                //    Console.WriteLine(g.Key);
                //    foreach (var page in g)
                //    {
                //        Console.WriteLine("   {0}, {1}, {2}", page.WikiPage, page.Sensitivity, page.NotificationNumber);
                //    }
                //}

            }
        }
    }
}
