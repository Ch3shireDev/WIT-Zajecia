using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UlamClasters
{
    public partial class UlamClastersMain : Form
    {
        public UlamClastersMain()
        {
            InitializeComponent();
        }

        private float midOf(float big, float small)
        {
            return (float)(0.5 * (big - small));
        }

        private Bitmap draw(string str)
        {
            Bitmap bmp = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bmp);
            Font fnt = new Font("Arial", 16);
            SizeF sz = g.MeasureString(str, fnt);
            double sqr = Math.Sqrt(2);
            float w = (float)Math.Ceiling(sqr * (sz.Width + 4));
            float h = (float)Math.Ceiling(sqr * (sz.Height + 4));
            float x = midOf(bmp.Width, w), y = midOf(bmp.Height, h);
            Brush back = new SolidBrush(Color.Yellow);
            Brush fore = new SolidBrush(Color.Red);
            Pen border = new Pen(Color.Blue, 2);
            Pen line = new Pen(Color.Green, 3);
            for (int py = -1; py <= 1; ++py)
            {
                for (int px = -1; px <= 1; ++px)
                {
                    if ((px != 0) || (py != 0))
                    {
                        float X = midOf(bmp.Width, 0), Y = midOf(bmp.Height, 0);
                        g.DrawLine(line, X, Y, X + w * px, Y + h * py);
                    }
                }
            }
            g.FillEllipse(back, x, y, w, h);
            g.DrawEllipse(border, x, y, w, h);
            g.DrawString(str, fnt, fore, midOf(bmp.Width, sz.Width), midOf(bmp.Height, sz.Height));
            return bmp;
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            //Box.Image=draw("CSharp");
            int value;
            if (int.TryParse(EdCount.Text, out value)) Box.Image = new UlamGraphics().calc(value);
        }
    }
}
