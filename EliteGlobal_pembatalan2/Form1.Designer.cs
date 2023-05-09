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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            Linkedin = new PictureBox();
            Facebook = new PictureBox();
            IG = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label5 = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Linkedin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Facebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IG).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 21, 33);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 34);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(51, 65);
            Logo.Margin = new Padding(4);
            Logo.Name = "Logo";
            Logo.Size = new Size(246, 46);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.BackColor = Color.Transparent;
            Home.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Home.ForeColor = Color.Black;
            Home.Location = new Point(435, 71);
            Home.Margin = new Padding(4, 0, 4, 0);
            Home.Name = "Home";
            Home.Size = new Size(89, 39);
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
            Facility.Location = new Point(644, 71);
            Facility.Margin = new Padding(4, 0, 4, 0);
            Facility.Name = "Facility";
            Facility.Size = new Size(103, 39);
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
            Search.Location = new Point(910, 71);
            Search.Margin = new Padding(4);
            Search.Name = "Search";
            Search.Size = new Size(437, 31);
            Search.TabIndex = 4;
            Search.Text = "Cari Fasilitas";
            Search.TextChanged += Search_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1416, 76);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1492, 62);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            panel2.Location = new Point(0, 919);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1800, 131);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1549, 45);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(51, 45);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 51);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Linkedin
            // 
            Linkedin.Image = (Image)resources.GetObject("Linkedin.Image");
            Linkedin.Location = new Point(1492, 45);
            Linkedin.Margin = new Padding(4);
            Linkedin.Name = "Linkedin";
            Linkedin.Size = new Size(32, 32);
            Linkedin.SizeMode = PictureBoxSizeMode.StretchImage;
            Linkedin.TabIndex = 11;
            Linkedin.TabStop = false;
            // 
            // Facebook
            // 
            Facebook.Image = (Image)resources.GetObject("Facebook.Image");
            Facebook.Location = new Point(1370, 45);
            Facebook.Margin = new Padding(4);
            Facebook.Name = "Facebook";
            Facebook.Size = new Size(32, 32);
            Facebook.SizeMode = PictureBoxSizeMode.StretchImage;
            Facebook.TabIndex = 9;
            Facebook.TabStop = false;
            // 
            // IG
            // 
            IG.Image = (Image)resources.GetObject("IG.Image");
            IG.Location = new Point(1436, 45);
            IG.Margin = new Padding(4);
            IG.Name = "IG";
            IG.Size = new Size(32, 32);
            IG.SizeMode = PictureBoxSizeMode.StretchImage;
            IG.TabIndex = 10;
            IG.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1720, 441);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 29;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(781, 251);
            label1.Name = "label1";
            label1.Size = new Size(287, 54);
            label1.TabIndex = 31;
            label1.Text = "PEMBATALAN";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(112, 346);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1613, 364);
            textBox1.TabIndex = 32;
            textBox1.Text = "\r\n\r\n\r\n\r\nKami sedang melakukan peninjauan mengenai pengajuan pembatalan anda,\r\nketika pembatalan disetujui anda tidak dapat melakukan pengajuan peminjaman 1x24 jam.\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(734, 407);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 59);
            textBox2.TabIndex = 33;
            textBox2.Text = "PERHATIAN!";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 232);
            ClientSize = new Size(1800, 1050);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(Facility);
            Controls.Add(Home);
            Controls.Add(Logo);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Facility Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Linkedin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Facebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)IG).EndInit();
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
        private Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}