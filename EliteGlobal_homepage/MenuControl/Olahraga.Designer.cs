namespace EliteGlobal_homepage.MenuControl
{
    partial class Olahraga
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(159, 21, 33);
            button1.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(930, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 14;
            button1.Text = "CARI";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(477, 25);
            label3.Name = "label3";
            label3.Size = new Size(206, 30);
            label3.TabIndex = 13;
            label3.Text = "Waktu Peminjaman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 12;
            label1.Text = "Jenis Lapangan";
            label1.Click += label1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lapangan Tenis", "Lapangan basket", "Lapangan futsal", "Swiming Pool" });
            comboBox1.Location = new Point(32, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 91);
            label2.Name = "label2";
            label2.Size = new Size(213, 15);
            label2.TabIndex = 17;
            label2.Text = "contoh : Rabu, 3 mei 2023 / 09.30-12.00";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 16;
            // 
            // Olahraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Olahraga";
            Size = new Size(1038, 145);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
    }
}
