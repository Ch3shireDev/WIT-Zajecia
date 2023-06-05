using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            Bitmap bmp = new Bitmap(120, 120);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Color.Red), 0, 0, 120, 120);
            bmp.Save("x.bmp");
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
