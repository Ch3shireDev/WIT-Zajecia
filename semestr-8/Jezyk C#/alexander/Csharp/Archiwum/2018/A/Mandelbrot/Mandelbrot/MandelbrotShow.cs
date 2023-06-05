using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class MandelbrotShow : Form
    {
        private double X = -2, Y = 1, Zoom = 1, saveX = 0, saveY = 0;
        private bool CanRecalc = true;
        private bool Drag = false;
        public MandelbrotShow()
        {
            InitializeComponent();
            SetValues(X, Y, Zoom);
        }
        private void SetValues(double X, double Y, double Zoom)
        {
            CanRecalc = false;
            EdX.Text = string.Format("{0:F18}", X);
            EdY.Text = string.Format("{0:F18}", Y);
            EdZoom.Text = string.Format("{0:F4}", Zoom);
            CanRecalc = true;
            RecalcImage();
        }
        private void BoxInvalidate()
        {
            if
            (
                (CanRecalc) &&
                (LbX.ForeColor == SystemColors.ControlText) &&
                (LbY.ForeColor == SystemColors.ControlText) &&
                (LbZoom.ForeColor == SystemColors.ControlText)
            )
            {
                RecalcImage();
            }
        }
        private void EdX_TextChanged(object sender, EventArgs e)
        {
            ParseValue(EdX.Text, ref X, LbX);
        }
        private void EdY_TextChanged(object sender, EventArgs e)
        {
            ParseValue(EdY.Text, ref Y, LbY);
        }
        private void EdZoom_TextChanged(object sender, EventArgs e)
        {
            ParseValue(EdZoom.Text, ref Zoom, LbZoom);
        }
        private double ZoomMul()
        {
            return 2.5 / (Zoom * Box.Width);
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = (Bitmap)Box.Tag;
            if (bmp != null) e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void MandelbrotShow_Resize(object sender, EventArgs e)
        {
            BoxInvalidate();
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            double mul = ZoomMul();
            saveY = Y - e.Y * mul;
            saveX = X + e.X * mul;
        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                double mul = ZoomMul();
                SetValues(saveX - e.X * mul, saveY + e.Y * mul, Zoom);
            }
        }

        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
            if (Drag) Drag = false;
            else
            {
                double mul = ZoomMul(), Pi = Y - e.Y * mul, Pr = X + e.X * mul, my = Box.Height * 0.5, mx = Box.Width * 0.5;
                if (e.Button == MouseButtons.Left) Zoom *= 2;
                else if (e.Button == MouseButtons.Right) Zoom *= 0.5;
                else return;
                mul = ZoomMul();
                SetValues(Pr - mx * mul, Pi + my * mul, Zoom);
            }
        }

        private void ParseValue(string text,ref double value,Label lb)
        {
            bool f = double.TryParse(text, out value);
            if (f)
            {
                lb.ForeColor = SystemColors.ControlText;
                BoxInvalidate();
            }
            else lb.ForeColor = Color.Red;
        }
        private void RecalcImage()
        {
            int w = Box.Width, h = Box.Height, ThemeLength = MandelbrotColors.Helper.Theme.Length;
            double mul = ZoomMul();
            Color[,] arr = new Color[h, w];
            for (int y = 0; y < h; ++y)
            {
                double Pi = Y - y * mul;
                for (int x = 0; x < w; ++x)
                {
                    double Pr = X + x * mul;
                    arr[y, x] = MandelbrotColors.Helper.Theme[MandelbrotCalc.Helper.Calc(Pi,Pr, ThemeLength)];
                }
            }
            Box.Tag = ImageHelper.Helper.ArrToBmp(arr);
            Box.Invalidate();
        }
    }
}
