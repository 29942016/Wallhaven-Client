namespace Wallhaven_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.chkCreateFolder = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flickerPages = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radNSFW = new System.Windows.Forms.RadioButton();
            this.radSFW = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flickerPages)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.chkCreateFolder);
            this.groupBox1.Location = new System.Drawing.Point(483, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Directory to save images:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(9, 32);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(200, 20);
            this.txtDirectory.TabIndex = 11;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // chkCreateFolder
            // 
            this.chkCreateFolder.AutoSize = true;
            this.chkCreateFolder.Location = new System.Drawing.Point(9, 55);
            this.chkCreateFolder.Name = "chkCreateFolder";
            this.chkCreateFolder.Size = new System.Drawing.Size(139, 17);
            this.chkCreateFolder.TabIndex = 10;
            this.chkCreateFolder.Text = "Create Folder Per Query";
            this.chkCreateFolder.UseVisualStyleBackColor = true;
            this.chkCreateFolder.CheckedChanged += new System.EventHandler(this.chkCreateFolder_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flickerPages);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radNSFW);
            this.groupBox2.Controls.Add(this.radSFW);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbResolution);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTags);
            this.groupBox2.Controls.Add(this.btnGetImage);
            this.groupBox2.Location = new System.Drawing.Point(483, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 142);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2.";
            // 
            // flickerPages
            // 
            this.flickerPages.Location = new System.Drawing.Point(108, 32);
            this.flickerPages.Name = "flickerPages";
            this.flickerPages.Size = new System.Drawing.Size(84, 20);
            this.flickerPages.TabIndex = 23;
            this.flickerPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flickerPages.ValueChanged += new System.EventHandler(this.flickerPages_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Page to search:";
            // 
            // radNSFW
            // 
            this.radNSFW.AutoSize = true;
            this.radNSFW.Location = new System.Drawing.Point(8, 79);
            this.radNSFW.Name = "radNSFW";
            this.radNSFW.Size = new System.Drawing.Size(57, 17);
            this.radNSFW.TabIndex = 20;
            this.radNSFW.TabStop = true;
            this.radNSFW.Text = "NSFW";
            this.radNSFW.UseVisualStyleBackColor = true;
            this.radNSFW.CheckedChanged += new System.EventHandler(this.radNSFW_CheckedChanged);
            // 
            // radSFW
            // 
            this.radSFW.AutoSize = true;
            this.radSFW.Location = new System.Drawing.Point(8, 58);
            this.radSFW.Name = "radSFW";
            this.radSFW.Size = new System.Drawing.Size(49, 17);
            this.radSFW.TabIndex = 19;
            this.radSFW.TabStop = true;
            this.radSFW.Text = "SFW";
            this.radSFW.UseVisualStyleBackColor = true;
            this.radSFW.CheckedChanged += new System.EventHandler(this.radSFW_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Resolution:";
            // 
            // cmbResolution
            // 
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(6, 31);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(88, 21);
            this.cmbResolution.TabIndex = 17;
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search Tags:";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(6, 117);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(165, 20);
            this.txtTags.TabIndex = 12;
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(177, 114);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(93, 23);
            this.btnGetImage.TabIndex = 11;
            this.btnGetImage.Text = "Search Images";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(44, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(27, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Idle.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save All";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(483, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 62);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(490, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(739, 17);
            this.toolStripStatusLabel1.Text = "Written by Obsta - Oliver.Buckler@Gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Wallhaven Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flickerPages)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.CheckBox chkCreateFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.RadioButton radNSFW;
        private System.Windows.Forms.RadioButton radSFW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog saveDirectoryDialog;
        private System.Windows.Forms.NumericUpDown flickerPages;
        private System.Windows.Forms.Label label5;
    }
}

