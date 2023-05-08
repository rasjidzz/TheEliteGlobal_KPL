namespace EliteGlobal_homepage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Logo = new PictureBox();
            Home = new Label();
            Facility = new Label();
            Search = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            Facebook = new PictureBox();
            IG = new PictureBox();
            Linkedin = new PictureBox();
            pictureBox4 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Facebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Linkedin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 21, 33);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 27);
            panel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(41, 52);
            Logo.Name = "Logo";
            Logo.Size = new Size(197, 37);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.BackColor = Color.Transparent;
            Home.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Home.ForeColor = Color.FromArgb(226, 42, 50);
            Home.Location = new Point(348, 57);
            Home.Name = "Home";
            Home.Size = new Size(70, 32);
            Home.TabIndex = 2;
            Home.Text = "Home";
            Home.TextAlign = ContentAlignment.MiddleCenter;
            Home.Click += label1_Click;
            // 
            // Facility
            // 
            Facility.AutoSize = true;
            Facility.BackColor = Color.Transparent;
            Facility.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Facility.ForeColor = Color.Black;
            Facility.Location = new Point(515, 57);
            Facility.Name = "Facility";
            Facility.Size = new Size(82, 32);
            Facility.TabIndex = 3;
            Facility.Text = "Facility";
            Facility.TextAlign = ContentAlignment.MiddleCenter;
            Facility.Click += label1_Click_1;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.ScrollBar;
            Search.BorderStyle = BorderStyle.FixedSingle;
            Search.ForeColor = Color.Black;
            Search.Location = new Point(728, 57);
            Search.Name = "Search";
            Search.Size = new Size(350, 27);
            Search.TabIndex = 4;
            Search.Text = "Cari Fasilitas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1133, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1194, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 35, 55);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(Linkedin);
            panel2.Controls.Add(Facebook);
            panel2.Controls.Add(IG);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 997);
            panel2.Name = "panel2";
            panel2.Size = new Size(1440, 105);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 41);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Facebook
            // 
            Facebook.Image = (Image)resources.GetObject("Facebook.Image");
            Facebook.Location = new Point(1096, 36);
            Facebook.Name = "Facebook";
            Facebook.Size = new Size(26, 26);
            Facebook.SizeMode = PictureBoxSizeMode.StretchImage;
            Facebook.TabIndex = 9;
            Facebook.TabStop = false;
            // 
            // IG
            // 
            IG.Image = (Image)resources.GetObject("IG.Image");
            IG.Location = new Point(1149, 36);
            IG.Name = "IG";
            IG.Size = new Size(26, 26);
            IG.SizeMode = PictureBoxSizeMode.StretchImage;
            IG.TabIndex = 10;
            IG.TabStop = false;
            // 
            // Linkedin
            // 
            Linkedin.Image = (Image)resources.GetObject("Linkedin.Image");
            Linkedin.Location = new Point(1194, 36);
            Linkedin.Name = "Linkedin";
            Linkedin.Size = new Size(26, 26);
            Linkedin.SizeMode = PictureBoxSizeMode.StretchImage;
            Linkedin.TabIndex = 11;
            Linkedin.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1239, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(62, 131);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1262, 275);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 232);
            ClientSize = new Size(1440, 1102);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(Facility);
            Controls.Add(Home);
            Controls.Add(Logo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Home Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Facebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)IG).EndInit();
            ((System.ComponentModel.ISupportInitialize)Linkedin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo;
        private Label Home;
        private Label Facility;
        private TextBox Search;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox Facebook;
        private PictureBox IG;
        private PictureBox Linkedin;
        private PictureBox pictureBox4;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox5;
    }
}