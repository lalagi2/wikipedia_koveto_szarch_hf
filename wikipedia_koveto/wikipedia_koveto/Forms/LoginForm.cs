using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private static string Hash(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("X2")).ToArray());
        }

        private void login()
        {
            bool loginSuccessful = false;
            using (UserDataEntities dc = new UserDataEntities())
            {
                var users = from user in dc.Users select new { user.UserName, user.Email, user.IsAdmin, user.UserPass };
                foreach (var user in users)
                {
                    if (userNameTextBox.Text == user.UserName && Hash(passwordTextBox.Text) == user.UserPass)
                    {
                        loginSuccessful = true;
                        // Elugrunk az user windowra
                        passwordTextBox.Text = "";
                        Hide();
                        Forms.SimpleUserForm userForm = new Forms.SimpleUserForm(user.UserName, this, user.IsAdmin);
                        userForm.Show();
                    }
                }

                if (!loginSuccessful)
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

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }
    }
}
