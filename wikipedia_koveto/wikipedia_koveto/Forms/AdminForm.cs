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

namespace wikipedia_koveto.Forms
{
    public partial class AdminForm : Form
    {
        private string userName; // To store which admin logged in

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
            base.OnClosed(e);
        }

        public AdminForm(string userName)
        {
            InitializeComponent();

            this.userName = userName;

            using (UserDataEntities dc = new UserDataEntities())
            {
                var users = from user in dc.Users
                            select new { user.UserName };
                foreach (var user in users)
                {
                    this.usersComboBox.Items.Add(user.UserName);
                }
            }

            usersComboBox.SelectedIndex = 1;
            refreshData();

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string selected = usersComboBox.SelectedItem.ToString();
            using (UserDataEntities dc = new UserDataEntities())
            {
                Object selecteduserName = usersComboBox.SelectedItem;
                var users = from user in dc.Users where user.UserName == selecteduserName.ToString()
                            select user;
                foreach (var user in users)
                {
                    user.MaxPageNumber = (int)modifySubscriptionNumericBox.Value;
                    user.NotificationPerDay = (int)modifyRefreshRate.Value;
                }

                try
                {
                    dc.SaveChanges();
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
            }
        }

        void refreshData()
        {
            string selected = usersComboBox.SelectedItem.ToString();
            using (UserDataEntities dc = new UserDataEntities())
            {
                var selectedUser = from user in dc.Users
                           where user.UserName == selected
                           select new { user.MaxPageNumber, user.NotificationPerDay };

                modifyRefreshRate.Value = selectedUser.FirstOrDefault().NotificationPerDay;
                modifySubscriptionNumericBox.Value = selectedUser.FirstOrDefault().MaxPageNumber;
            }
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
