using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbroat
{
    public partial class MandelbroatForm : Form
    {
        private double Lf, Tp, Zoom;
        private int mainWidth;
        private Graphics main;

        public MandelbroatForm()
        {
            InitializeComponent();
            MandelbroatForm_Resize(null, null);
        }

        private void EdData_TextChanged(object sender, EventArgs e)
        {
            if
            (
                double.TryParse(EdX.Text, out Lf) &&
                double.TryParse(EdY.Text, out Tp) &&
                double.TryParse(EdZoom.Text, out Zoom)
            )
            {
                RecalcFractal(Lf, Tp, Zoom);
            }
        }

        private void MandelbroatForm_Resize(object sender, EventArgs e)
        {
            lock(Box)
            {
                mainWidth = Box.Width;
                Bitmap bmp = new Bitmap(mainWidth, Box.Height);
                Box.Image = bmp;
                main = Graphics.FromImage(bmp);
            }
            EdData_TextChanged(null, null);
        }

        private double ZoomMul(double Zoom)
        {
            return 3 / (mainWidth * Zoom);
        }
        private void BmpReport(int X, int Y, Bitmap bmp)
        {
            lock(main)
            { 
                main.DrawImage(bmp, X, Y, MandelbroatThread.size, MandelbroatThread.size);
                Box.Invalidate();
            }
        }
        private void RecalcFractal(double Lf, double Tp, double Zoom)
        {
            int sx = Box.Width, sy = Box.Height;
            double mul = ZoomMul(Zoom);
            for (int y = 0; y < sy; y += MandelbroatThread.size)
            {
                double smallTp = MandelbroatProc.encodeY(y, Tp, mul);
                for (int x = 0; x < sx; x += MandelbroatThread.size)
                {
                    double smallLf = MandelbroatProc.encodeX(x, Lf, mul);
                    new MandelbroatThread(smallLf, smallTp, mul, x, y, BmpReport);
                }
            }
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            int sx = Box.Width >> 1, sy = Box.Height >> 1;
            double mul = ZoomMul(Zoom);
            double Pi = MandelbroatProc.encodeY(y, Tp, mul), Pr = MandelbroatProc.encodeX(x, Lf, mul);
            if (e.Button == MouseButtons.Left) Zoom *= 2;
            else if (e.Button == MouseButtons.Right) Zoom /= 2;
            else return;
            mul = ZoomMul(Zoom);
            EdZoom.Text = string.Format("{0:F14}", Zoom);
            EdX.Text = string.Format("{0:F14}", MandelbroatProc.decodeX(sx, Pr, mul)); // Pr - sx * mul
            EdY.Text = string.Format("{0:F14}", MandelbroatProc.decodeY(sy, Pi, mul));
        }
    }
}
