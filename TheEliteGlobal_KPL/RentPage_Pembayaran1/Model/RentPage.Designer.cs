﻿namespace RentPage
{
    partial class RentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentPage));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            PanelAtas = new Panel();
            label1 = new Label();
            label2 = new Label();
            SearchBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            NamaBangunan = new Label();
            panel2 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            InputNoTelf = new Label();
            Input_Jurusan = new Label();
            InputNIM = new Label();
            InputNama = new Label();
            DataDiri = new Label();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            UploadDokumen = new Label();
            AjukanPeminjaman = new Button();
            panel5 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            dragfile = new ListBox();
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelAtas
            // 
            PanelAtas.BackColor = Color.DarkRed;
            PanelAtas.Dock = DockStyle.Top;
            PanelAtas.ForeColor = Color.Transparent;
            PanelAtas.Location = new Point(0, 0);
            PanelAtas.Name = "PanelAtas";
            PanelAtas.Size = new Size(1149, 27);
            PanelAtas.TabIndex = 2;
            PanelAtas.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(344, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 3;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(503, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 4;
            label2.Text = "Facility";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(664, 58);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(275, 23);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "Cari Fasilitas...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(112, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(362, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NamaBangunan);
            panel1.Location = new Point(112, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 153);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(224, 45);
            label3.TabIndex = 1;
            label3.Text = "Lorem ipsum dolor sit amet, consectetur \r\nadipiscing elit, sed do eiusmod tempor \r\nincididunt ut labore et dolore magna\r\n";
            label3.Click += label3_Click;
            // 
            // NamaBangunan
            // 
            NamaBangunan.AutoSize = true;
            NamaBangunan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NamaBangunan.Location = new Point(0, 17);
            NamaBangunan.Name = "NamaBangunan";
            NamaBangunan.Size = new Size(209, 25);
            NamaBangunan.TabIndex = 0;
            NamaBangunan.Text = "Gedung Kuliah Umum";
            NamaBangunan.Click += NamaBangunan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(InputNoTelf);
            panel2.Controls.Add(Input_Jurusan);
            panel2.Controls.Add(InputNIM);
            panel2.Controls.Add(InputNama);
            panel2.Controls.Add(DataDiri);
            panel2.Location = new Point(648, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 356);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(372, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // InputNoTelf
            // 
            InputNoTelf.AutoSize = true;
            InputNoTelf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InputNoTelf.Location = new Point(45, 270);
            InputNoTelf.Name = "InputNoTelf";
            InputNoTelf.Size = new Size(93, 15);
            InputNoTelf.TabIndex = 4;
            InputNoTelf.Text = "Nomor Telepon";
            InputNoTelf.Click += InputNoTelf_Click;
            // 
            // Input_Jurusan
            // 
            Input_Jurusan.AutoSize = true;
            Input_Jurusan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Input_Jurusan.Location = new Point(45, 203);
            Input_Jurusan.Name = "Input_Jurusan";
            Input_Jurusan.Size = new Size(49, 15);
            Input_Jurusan.TabIndex = 3;
            Input_Jurusan.Text = "Jurusan";
            // 
            // InputNIM
            // 
            InputNIM.AutoSize = true;
            InputNIM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InputNIM.Location = new Point(45, 138);
            InputNIM.Name = "InputNIM";
            InputNIM.Size = new Size(31, 15);
            InputNIM.TabIndex = 2;
            InputNIM.Text = "NIM";
            // 
            // InputNama
            // 
            InputNama.AutoSize = true;
            InputNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InputNama.Location = new Point(45, 81);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(39, 15);
            InputNama.TabIndex = 1;
            InputNama.Text = "Nama";
            InputNama.Click += InputNama_Click;
            // 
            // DataDiri
            // 
            DataDiri.AutoSize = true;
            DataDiri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DataDiri.Location = new Point(126, 17);
            DataDiri.Name = "DataDiri";
            DataDiri.Size = new Size(182, 25);
            DataDiri.TabIndex = 0;
            DataDiri.Text = "Data Diri Peminjam";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 929);
            panel3.Name = "panel3";
            panel3.Size = new Size(1149, 112);
            panel3.TabIndex = 9;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1050, 48);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1005, 48);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(960, 48);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(915, 48);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // UploadDokumen
            // 
            UploadDokumen.AutoSize = true;
            UploadDokumen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            UploadDokumen.Location = new Point(320, 35);
            UploadDokumen.Name = "UploadDokumen";
            UploadDokumen.Size = new Size(393, 37);
            UploadDokumen.TabIndex = 0;
            UploadDokumen.Text = "Upload Dokumen Pendukung";
            UploadDokumen.Click += UploadDokumen_Click;
            // 
            // AjukanPeminjaman
            // 
            AjukanPeminjaman.BackColor = Color.Maroon;
            AjukanPeminjaman.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AjukanPeminjaman.ForeColor = SystemColors.ButtonHighlight;
            AjukanPeminjaman.Location = new Point(79, 346);
            AjukanPeminjaman.Name = "AjukanPeminjaman";
            AjukanPeminjaman.Size = new Size(231, 44);
            AjukanPeminjaman.TabIndex = 1;
            AjukanPeminjaman.Text = "Ajukan Peminjaman";
            AjukanPeminjaman.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(dragfile);
            panel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(79, 100);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(891, 188);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(242, 112);
            label4.Name = "label4";
            label4.Size = new Size(377, 25);
            label4.TabIndex = 1;
            label4.Text = "You can drag and drop files here to add them.\r\n";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._52;
            pictureBox4.Location = new Point(398, 33);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(86, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // dragfile
            // 
            dragfile.AllowDrop = true;
            dragfile.FormattingEnabled = true;
            dragfile.ItemHeight = 15;
            dragfile.Location = new Point(3, 2);
            dragfile.Margin = new Padding(3, 2, 3, 2);
            dragfile.Name = "dragfile";
            dragfile.Size = new Size(886, 184);
            dragfile.TabIndex = 11;
            dragfile.SelectedIndexChanged += dragfile_SelectedIndexChanged;
            dragfile.DragDrop += dragfile_DragDrop;
            dragfile.DragEnter += dragfile_DragEnter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(AjukanPeminjaman);
            panel4.Controls.Add(UploadDokumen);
            panel4.Location = new Point(112, 524);
            panel4.Name = "panel4";
            panel4.Size = new Size(1005, 405);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(178, 317);
            label8.Name = "label8";
            label8.Size = new Size(157, 15);
            label8.TabIndex = 5;
            label8.Text = ".zip .doc .docx .pdf .jpg .png";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 317);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 4;
            label7.Text = "Document files ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 302);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 3;
            label6.Text = "Accepted file types:";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Burger__1_;
            pictureBox9.Location = new Point(1016, 58);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(29, 18);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.PP;
            pictureBox10.Location = new Point(1084, 51);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(543, 167);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(8, 8);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // RentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1166, 791);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(PanelAtas);
            Name = "RentPage";
            Text = "label";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private PictureBox pictureBox1;
        private Panel PanelAtas;
        private Label label1;
        private Label label2;
        private TextBox SearchBox;
        private BindingSource bindingSource1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label NamaBangunan;
        private Panel panel2;
        private Label InputNoTelf;
        private Label Input_Jurusan;
        private Label InputNIM;
        private Label InputNama;
        private Label DataDiri;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label3;
        private Label UploadDokumen;
        private Button AjukanPeminjaman;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private ListBox dragfile;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private TableLayoutPanel tableLayoutPanel1;
    }
}