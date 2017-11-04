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

        public void refreshDataGrid()
        {
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
                        this.dataGridView1.Rows.Add(page.WikiPage, page.Sensitivity, page.NotificationNumber);
                    }
                }
            }
        }

        public SimpleUserForm(string userName)
        {
            InitializeComponent();

            this.userName = userName;
            WelcomeLabel.Text += " " + userName + "!";

            refreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
