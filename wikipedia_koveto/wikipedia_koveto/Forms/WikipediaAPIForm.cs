using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wikipedia_koveto.WikipediaAPI;

namespace wikipedia_koveto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            WikiAPI api = new WikiAPI();
            resultText.Text = api.GetContent(titleText.Text);
            revisionList.DataSource = null;
        }

        private void revisionButton_Click(object sender, EventArgs e)
        {
            WikiAPI api = new WikiAPI();
            int revId;
            if (Int32.TryParse(revisionText.Text, out revId))
                revisionList.DataSource = api.GetRevisions(titleText.Text, revId);
            else
                revisionList.DataSource = api.GetRevisions(titleText.Text);
            revisionList.DisplayMember = "RevId";
        }

        private void revisionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (RevisionData)revisionList.SelectedItem;
            if (item != null)
            {
                revText.Text = item.RevId.ToString();
                parentText.Text = item.ParentId.ToString();
                sizeText.Text = item.Size.ToString();
                timeText.Text = item.Timestamp.ToString();
                WikiAPI api = new WikiAPI();
                resultText.Text = api.GetContent(titleText.Text, item.RevId);
            }
            else
            {
                revText.Text = "";
                parentText.Text = "";
                sizeText.Text = "";
                timeText.Text = "";
                resultText.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void get_button_Click(object sender, EventArgs e)
        {
            int fromRev = int.Parse(from_text.Text);
            int toRev = int.Parse(to_text.Text);


            WikiAPI api = new WikiAPI();
            diff_size_text.Text = api.GetDiff(fromRev, toRev).ToString();
            diff_text.Text = api.LastDiff;
        }
    }
}
