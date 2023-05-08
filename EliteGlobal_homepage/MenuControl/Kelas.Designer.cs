namespace EliteGlobal_homepage.MenuControl
{
    partial class Kelas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(159, 21, 33);
            button1.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(931, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 14;
            button1.Text = "CARI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(602, 26);
            label3.Name = "label3";
            label3.Size = new Size(206, 30);
            label3.TabIndex = 13;
            label3.Text = "Waktu Peminjaman";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 12;
            label1.Text = "Gedung";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(329, 26);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 15;
            label2.Text = "Ruangan";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Gedung Kuliah Umum", "TULT (Telkom University Landmark Tower)", "Gedung A", "Gedung B" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gedung Kuliah Umum", "TULT (Telkom University Landmark Tower)", "Auditorium", "Student Center", "TUCH (Telkom university Convention Hall)", "GSG (Gedung Serba Guna)", "Gedung A", "Gedung B" });
            comboBox1.Location = new Point(33, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Nama Gedung";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(602, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 92);
            label4.Name = "label4";
            label4.Size = new Size(213, 15);
            label4.TabIndex = 18;
            label4.Text = "contoh : Rabu, 3 mei 2023 / 09.30-12.00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(329, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 92);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 20;
            label5.Text = "Contoh : TULT.07.10";
            // 
            // Kelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Kelas";
            Size = new Size(1038, 145);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
    }
}
