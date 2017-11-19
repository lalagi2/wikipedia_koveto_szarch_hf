using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wikipedia_koveto.Model;

namespace wikipedia_koveto.Forms
{
    public partial class SimpleUserForm : Form
    {
        private string userName; // To store which user logged in
        private bool isAdmin;

        public void deleteDataGrid()
        {
           // this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }

        public void modifyDataGrid()
        {
            dataGridView1.Rows[0].Cells[1].Value = "TEST COMPLETE"; // átírja a 0. sor 1. oszlopot "TEST COMPLETE"-re
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
            base.OnClosed(e);
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            using (UserDataEntities dc = new UserDataEntities())
            {
                var users = from user in dc.Users where user.UserName == userName select user;
                var userPages = from pages in dc.Pages where pages.UserName == userName select pages;
                var count = userPages.Count();
                if (users.FirstOrDefault().MaxPageNumber > count)
                {
                    // newWikipediaPageTextBox, sensitivityNumericBox, refreshRateNumericBox értékét  kiovlassuk, és beszúrunk egy új sort a Pages táblába, majd meghívjuk a refreshDataGridet
                    string subscribePageName = newWikipediaPageTextBox.Text;
                    int subscribeSensitivity = (int)sensitivityNumericBox.Value;
                    int subscriberefreshRate = (int)refreshRateNumericBox.Value;

                    Page newPage = new Page();
                    newPage.UserName = this.userName;
                    newPage.WikiPage = subscribePageName;
                    newPage.Sensitivity = subscribeSensitivity;
                    newPage.RefreshRate = subscriberefreshRate;

                    dc.Pages.Add(newPage);
                    dc.SaveChanges();

                    refreshDataGrid();
                }
                else
                {
                    MessageBox.Show("You can not subscribe");
                }
            }

        }


        public void refreshDataGrid()
        {
            deleteDataGrid();
            deleteUnsubscribeComboBox();

            using (UserDataEntities dc = new UserDataEntities())
            {
                var groups = from page in dc.Pages
                             where page.UserName.Contains(userName)
                             group page by page.UserName into g
                             select g;
                foreach (var g in groups)
                {
                    //Console.WriteLine(g.Key);
                    foreach (var page in g)
                    {
                        //Console.WriteLine("   {0}, {1}, {2}", page.WikiPage, page.Sensitivity, page.RefreshRate);
                        this.unsubscribeComboBox1.Items.Add(page.WikiPage);
                        this.dataGridView1.Rows.Add(page.WikiPage, page.Sensitivity, page.RefreshRate);
                    }
                }
            }
            if(unsubscribeComboBox1.Items.Count > 0)
                this.unsubscribeComboBox1.SelectedIndex = 0;
        }

        private void deleteUnsubscribeComboBox()
        {
            this.unsubscribeComboBox1.Items.Clear();
        }

        public SimpleUserForm(string userName, bool isAdmin = false)
        {
            InitializeComponent();

            this.userName = userName;
            WelcomeLabel.Text += " " + userName + "!";

            if (isAdmin)
                admin_button.Visible = true;
            else
                admin_button.Visible = false;

            refreshDataGrid();
           // modifyDataGrid();
        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            Object selectedItem = unsubscribeComboBox1.SelectedItem;

            // username és a kiválasztott wikipedia oldal függvényében kitöröljük a Pages táblából a sort, majd meghívjuk a refreshDataGridet
            using (UserDataEntities dc = new UserDataEntities())
            {
                var itemToRemove = (from s1 in dc.Pages
                            where s1.WikiPage == selectedItem.ToString() && s1.UserName == userName
                            select s1).FirstOrDefault();

                if (itemToRemove != null)
                {
                    dc.Pages.Remove(itemToRemove);
                    dc.SaveChanges();
                }
            }

            refreshDataGrid();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // username és a kiválasztott wikipedia oldal függvényében kitöröljük a Pages táblából a sort és egy új sort szúrúnk be a módosított értékeknek megfelelően, majd meghívjuk a refreshDataGridet

            Object selectedItem = unsubscribeComboBox1.SelectedItem;

            // username és a kiválasztott wikipedia oldal függvényében kitöröljük a Pages táblából a sort, majd meghívjuk a refreshDataGridet
            using (UserDataEntities dc = new UserDataEntities())
            {
                var itemToRemove = (from s1 in dc.Pages
                                    where s1.WikiPage == selectedItem.ToString() && s1.UserName == userName
                                    select s1).FirstOrDefault();

                if (itemToRemove != null)
                {
                    dc.Pages.Remove(itemToRemove);
                    dc.SaveChanges();
                }
            }

            // newWikipediaPageTextBox, sensitivityNumericBox, refreshRateNumericBox értékét  kiovlassuk, és beszúrunk egy új sort a Pages táblába, majd meghívjuk a refreshDataGridet
            string subscribePageName = selectedItem.ToString();
            int subscribeSensitivity = (int)modifySensitivityNumericBox.Value;
            int subscriberefreshRate = (int)modifyRefreshRate.Value;

            using (UserDataEntities dc = new UserDataEntities())
            {
                Page newPage = new Page();
                newPage.UserName = this.userName;
                newPage.WikiPage = subscribePageName;
                newPage.Sensitivity = subscribeSensitivity;
                newPage.RefreshRate = subscriberefreshRate;
                newPage.LastRevision = -1;

                dc.Pages.Add(newPage);
                dc.SaveChanges();
            }

            refreshDataGrid();
        }

        private void unsubscribeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedIndex = this.unsubscribeComboBox1.SelectedIndex;
            Object selectedItem = unsubscribeComboBox1.SelectedItem;

            using (UserDataEntities dc = new UserDataEntities())
            {
                var groups = from page in dc.Pages
                             where page.UserName.Contains(userName)
                             group page by page.UserName into g
                             select g;
                foreach (var g in groups)
                {
                    foreach (var page in g)
                    {
                        if (page.WikiPage == selectedItem.ToString())
                        {
                            // Updationg the numeric boxes according to the selected subscribe
                            modifySensitivityNumericBox.Value = page.Sensitivity;
                            modifyRefreshRate.Value = page.RefreshRate;
                        }
                    }
                }
            }
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            using (UserDataEntities dc = new UserDataEntities())
            {
                var user_admin = from user in dc.Users where user.UserName == userName select new { user.IsAdmin };
                if (user_admin.FirstOrDefault().IsAdmin)
                {
                    Forms.AdminForm adminForm = new Forms.AdminForm(userName);
                    adminForm.Show();
                }
            }
        }
    }
}
