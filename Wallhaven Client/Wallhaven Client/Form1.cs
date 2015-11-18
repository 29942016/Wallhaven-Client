using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Wallhaven_Client
{
    public partial class Form1 : Form
    {
        API.Debugging debug = new API.Debugging();
        API.WebCrawler crawler = new API.WebCrawler();

        string SFW = "&purity=100",
               resolution = "&resolutions=1920x1080";

        string[] resolutions = { "1024x768",
                                 "1280x800",
                                 "1366x768",
                                 "1280x960",
                                 "1440x900",
                                 "1280x1024",
                                 "1600x1200",
                                 "1680x1050",
                                 "1920x1200",
                                 "2569x1440",
                                 "3840x1080",
                                 "5760x1080"
                                };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbResolution.Items.AddRange(resolutions);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (crawler.startDownload())
                MessageBox.Show("Sucess");
            else
                MessageBox.Show("Failed!");

        }

        private void btnGetImage_Click_1(object sender, EventArgs e)
        {
            lblStatus.Text = "Searching for \"" + txtTags.Text + "\"...";
            this.Refresh();

            listBox1.Items.Clear();
            
            foreach (string s in crawler.extractImages("http://alpha.wallhaven.cc/search?q=" + txtTags.Text + SFW + resolution))
            {
                listBox1.Items.Add(s);
            }

            lblStatus.Text = "Idle.";

        }

        //Additional PHP queries to filter results
        private void radSFW_CheckedChanged(object sender, EventArgs e)
        {
            if (radSFW.Checked)
                SFW = "&purity=100";
        }

        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            resolution = "&resolutions=" + cmbResolution.SelectedItem.ToString();
        }



        private void radNSFW_CheckedChanged(object sender, EventArgs e)
        {
            if (radNSFW.Checked)
                SFW = "&purity=010";
        }
    }
}
