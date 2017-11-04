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
    public partial class SimpleUserForm : Form
    {
        private string userName; // To store which admin logged in

        public void deleteDataGrid()
        {
           // this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }

        public void modifyDataGrid()
        {
            dataGridView1.Rows[0].Cells[1].Value = "TEST COMPLETE"; // átírja a 0. sor 1. oszlopot "TEST COMPLETE"-re
        }

        public void refreshDataGrid()
        {
            deleteDataGrid();

            using (UserDataEntities dc = new UserDataEntities())
            {
                var groups = from page in dc.Pages
                             where page.UserName.Contains(userName)
                             group page by page.UserName into g
                             select g;
                foreach (var g in groups)
                {
                    Console.WriteLine(g.Key);
                    foreach (var page in g)
                    {
                        Console.WriteLine("   {0}, {1}, {2}", page.WikiPage, page.Sensitivity, page.NotificationNumber);
                        this.unsubscribeComboBox1.Items.Add(page.WikiPage);
                        this.dataGridView1.Rows.Add(page.WikiPage, page.Sensitivity, page.NotificationNumber);
                    }
                }
            }

            this.unsubscribeComboBox1.SelectedIndex = 1;
        }

        public SimpleUserForm(string userName)
        {
            InitializeComponent();

            this.userName = userName;
            WelcomeLabel.Text += " " + userName + "!";

            refreshDataGrid();
           // modifyDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            // newWikipediaPageTextBox, sensitivityNumericBox, refreshRateNumericBox értékét  kiovlassuk, és beszúrunk egy új sort a Pages táblába

            refreshDataGrid();
        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            // username és a kiválasztott wikipedia oldal függvényében kitöröljük a Pages táblából a sort

            refreshDataGrid();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // username és a kiválasztott wikipedia oldal függvényében kitöröljük a Pages táblából a sort és egy új sort szúrúnk be a módosított értékeknek megfelelően

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
                    Console.WriteLine(g.Key);
                    foreach (var page in g)
                    {
                        if (page.WikiPage == selectedItem.ToString())
                        {
                            modifySensitivityNumericBox.Value = page.Sensitivity;

                            // TODO: modifyRefreshRateNumericBox.Value-t is frissíteni, ha működni fog
                        }
                    }
                }
            }
        }
    }
}
