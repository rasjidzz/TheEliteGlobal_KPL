namespace EliteGlobal_homepage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = panel3.HorizontalScroll.Maximum;
            hScrollBar1.LargeChange = panel3.HorizontalScroll.LargeChange;
            hScrollBar1.SmallChange = panel3.HorizontalScroll.SmallChange;

            hScrollBar1.Scroll += new ScrollEventHandler(hScrollBar1_Scroll_1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void GedungKuliahUmum_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void TennisCourt_Click(object sender, EventArgs e)
        {

        }

        private void Auditorium_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaenNow_TUCH_Click(object sender, EventArgs e)
        {

        }

        private void BaenNow_Auditorium_Click(object sender, EventArgs e)
        {

        }

        private void BaenNow_StudentCenter_Click(object sender, EventArgs e)
        {

        }

        private void BaenNow_TennisCourt_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            panel3.HorizontalScroll.Value = e.NewValue;
            panel3.Invalidate();
            panel3.AutoScrollPosition = new Point(-e.NewValue, -panel3.AutoScrollPosition.Y);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {



        }
    }
}