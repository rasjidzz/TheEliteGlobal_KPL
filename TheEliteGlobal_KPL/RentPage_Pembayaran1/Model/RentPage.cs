using System.Drawing.Drawing2D;

namespace RentPage
{
    public partial class RentPage : Form
    {
        public RentPage()
        {
            InitializeComponent();
            dragfile.AllowDrop = true;
            dragfile.DragEnter += new DragEventHandler(dragfile_DragEnter);
            dragfile.DragDrop += new DragEventHandler(dragfile_DragDrop);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputNama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NamaBangunan_Click(object sender, EventArgs e)
        {
            NamaBangunan.Parent = panel1;
            NamaBangunan.BackColor = Color.Transparent;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dash;

            Rectangle rect = new Rectangle(10, 10, 970, 200);
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void UploadDokumen_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Gray;
        }

        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dragfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".jpg" || extension == ".png" || extension == ".pdf"
                        || extension == ".doc" || extension == ".docx" || extension == ".zip")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        private void dragfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!dragfile.Items.Contains(Path.GetFileName(file)))
                {
                    dragfile.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void InputNoTelf_Click(object sender, EventArgs e)
        {

        }
    }
}