using EliteGlobal_homepage.MenuControl;

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControls(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Olahraga ol = new Olahraga();
            addUserControls(ol);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Kelas kelas = new Kelas();
            addUserControls(kelas);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Gedung gedung = new Gedung();
            addUserControls(gedung);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}