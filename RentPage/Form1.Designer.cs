namespace RentPage
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
            NamaBangunan = new Label();
            panel2 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
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
            panel4 = new Panel();
            AjukanPeminjaman = new Button();
            UploadDokumen = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
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
            PanelAtas.Size = new Size(1142, 27);
            PanelAtas.TabIndex = 2;
            PanelAtas.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 58);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 3;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(360, 58);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 4;
            label2.Text = "Facility";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(530, 57);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(275, 23);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "Cari Fasilitas...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NamaBangunan);
            panel1.Location = new Point(124, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 146);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // NamaBangunan
            // 
            NamaBangunan.AutoSize = true;
            NamaBangunan.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NamaBangunan.Location = new Point(16, 17);
            NamaBangunan.Name = "NamaBangunan";
            NamaBangunan.Size = new Size(243, 26);
            NamaBangunan.TabIndex = 0;
            NamaBangunan.Text = "Gedung Kuliah Umum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(InputNoTelf);
            panel2.Controls.Add(Input_Jurusan);
            panel2.Controls.Add(InputNIM);
            panel2.Controls.Add(InputNama);
            panel2.Controls.Add(DataDiri);
            panel2.Location = new Point(516, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 351);
            panel2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(301, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // InputNoTelf
            // 
            InputNoTelf.AutoSize = true;
            InputNoTelf.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            InputNoTelf.Location = new Point(45, 270);
            InputNoTelf.Name = "InputNoTelf";
            InputNoTelf.Size = new Size(116, 21);
            InputNoTelf.TabIndex = 4;
            InputNoTelf.Text = "Nomor Telfon";
            // 
            // Input_Jurusan
            // 
            Input_Jurusan.AutoSize = true;
            Input_Jurusan.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Input_Jurusan.Location = new Point(45, 203);
            Input_Jurusan.Name = "Input_Jurusan";
            Input_Jurusan.Size = new Size(66, 21);
            Input_Jurusan.TabIndex = 3;
            Input_Jurusan.Text = "Jurusan";
            // 
            // InputNIM
            // 
            InputNIM.AutoSize = true;
            InputNIM.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            InputNIM.Location = new Point(45, 138);
            InputNIM.Name = "InputNIM";
            InputNIM.Size = new Size(45, 21);
            InputNIM.TabIndex = 2;
            InputNIM.Text = "NIM";
            // 
            // InputNama
            // 
            InputNama.AutoSize = true;
            InputNama.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            InputNama.Location = new Point(45, 75);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(53, 21);
            InputNama.TabIndex = 1;
            InputNama.Text = "Nama";
            InputNama.Click += InputNama_Click;
            // 
            // DataDiri
            // 
            DataDiri.AutoSize = true;
            DataDiri.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DataDiri.Location = new Point(125, 28);
            DataDiri.Name = "DataDiri";
            DataDiri.Size = new Size(219, 26);
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
            panel3.Location = new Point(0, 949);
            panel3.Name = "panel3";
            panel3.Size = new Size(1142, 112);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(AjukanPeminjaman);
            panel4.Controls.Add(UploadDokumen);
            panel4.Location = new Point(61, 530);
            panel4.Name = "panel4";
            panel4.Size = new Size(1016, 381);
            panel4.TabIndex = 10;
            // 
            // AjukanPeminjaman
            // 
            AjukanPeminjaman.BackColor = Color.Maroon;
            AjukanPeminjaman.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            AjukanPeminjaman.ForeColor = SystemColors.ButtonHighlight;
            AjukanPeminjaman.Location = new Point(79, 305);
            AjukanPeminjaman.Name = "AjukanPeminjaman";
            AjukanPeminjaman.Size = new Size(192, 49);
            AjukanPeminjaman.TabIndex = 1;
            AjukanPeminjaman.Text = "Ajukan Peminjaman";
            AjukanPeminjaman.UseVisualStyleBackColor = false;
            // 
            // UploadDokumen
            // 
            UploadDokumen.AutoSize = true;
            UploadDokumen.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            UploadDokumen.Location = new Point(320, 35);
            UploadDokumen.Name = "UploadDokumen";
            UploadDokumen.Size = new Size(359, 31);
            UploadDokumen.TabIndex = 0;
            UploadDokumen.Text = "Upload Dokumen Pendukung";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1142, 1061);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Button AjukanPeminjaman;
        private Label UploadDokumen;
    }
}