using System;
using System.Windows.Forms;

namespace Wallhaven_Client
{
    public partial class Form1 : Form
    {
        API.WebCrawler crawler = new API.WebCrawler();

        bool createDirectoryOnQuery = false;

        string saveDirectory = "";

        string SFW = "&purity=100",
               resolution = "&resolutions=1920x1080";

        string pagesToSearch = "&page=1";

        string[] resolutions = { "1024x768",
                                 "1280x800",
                                 "1366x768",
                                 "1280x960",
                                 "1440x900",
                                 "1280x1024",
                                 "1600x1200",
                                 "1680x1050",
                                 "1920x1080",
                                 "1920x1200",
                                 "2569x1440",
                                 "3840x1080",
                                 "5760x1080"
                                };

        int imagesFound = 0;
        public static int imagesDownloaded = 0;

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
            saveDirectory = txtDirectory.Text + "\\";
            imagesDownloaded = 0;
            lblStatus.Text = "Downloading images...";
            this.Refresh();

            if (createDirectoryOnQuery)
                saveDirectory += txtTags.Text + "\\";

            if (crawler.startDownload(saveDirectory))
                MessageBox.Show("Downloaded " + imagesDownloaded + "/" + imagesFound);
            else
                MessageBox.Show("Failed!");

            lblStatus.Text = "Idle.";
        }

        private void btnGetImage_Click_1(object sender, EventArgs e)
        {
            lblStatus.Text = "Please wait, searching for \"" + txtTags.Text + "\"...";
            this.Refresh();

            listBox1.Items.Clear();
            imagesFound = 0;

            foreach (string s in crawler.extractImages("http://alpha.wallhaven.cc/search?q=" + txtTags.Text + SFW + resolution + pagesToSearch))
            {
                listBox1.Items.Add(s);
                imagesFound++;
            }

            lblStatus.Text = "Idle.";

            if (imagesFound != 0)
                btnSave.Enabled = true;

        }

        private void radSFW_CheckedChanged(object sender, EventArgs e)
        {
            //Check if SFW
            if (radSFW.Checked)
                SFW = "&purity=100";
        }

        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check Resolution
            resolution = "&resolutions=" + cmbResolution.SelectedItem.ToString();
        }

        private void flickerPages_ValueChanged(object sender, EventArgs e)
        {
            //Check page to search
            pagesToSearch = "&page=" + flickerPages.Value;
        }

        private void chkCreateFolder_CheckedChanged(object sender, EventArgs e)
        {
            //Check if to create a directory on download
            createDirectoryOnQuery = !createDirectoryOnQuery;
        }

        private void radNSFW_CheckedChanged(object sender, EventArgs e)
        {
            //Check if NSFW
            if (radNSFW.Checked)
                SFW = "&purity=010";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get save directory 
            DialogResult result = saveDirectoryDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDirectory.Text = saveDirectoryDialog.SelectedPath + "\\";
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
