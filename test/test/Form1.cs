using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private Rectangle orForm;

        private Rectangle orLab1;

        private float orLab1Size;

        private float fontScale = 1f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orForm = new Rectangle(this.Location, this.Size);
            orLab1 = new Rectangle(label1.Location, label1.Size);
            orLab1Size = label1.Font.Size;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControl();
        }

        private void ResizeChildrenControl()
        {
            ResizeControl(label1, orLab1, orLab1Size);
        }

        private void ResizeControl(Control control, Rectangle orControl, float orFontSize)
        {
            float x = (float)this.ClientRectangle.Width / (float)orForm.Width;
            float y = (float)this.ClientRectangle.Height / (float)orForm.Height;

            float newX = orControl.Location.X * x;
            float newY = orControl.Location.Y * y;

            control.Location = new Point(
                (int)(pictureBox1.Width / 2 - control.Width / 2),
                (int)(pictureBox1.Height / 2 - control.Height / 2)
            );
            control.Width = (int)(orControl.Width * x);
            control.Height = (int)(orControl.Height * y);

            float ratio = x;
            if (x >= y)
            {
                ratio = y;
            }
            float newFontSize = orFontSize * ratio * fontScale;
            Font newFont = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);
            control.Font = newFont;
        }
    }
}
