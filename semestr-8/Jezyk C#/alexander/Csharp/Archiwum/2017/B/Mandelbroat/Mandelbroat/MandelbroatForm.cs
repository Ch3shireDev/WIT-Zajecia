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
        public MandelbroatForm()
        {
            InitializeComponent();
            EdLf.Text = "-2";
            EdTp.Text = "1";
            EdZoom.Text = "1";
        }
        private void EdData_TextChanged(object sender, EventArgs e)
        {
            if
            (
                double.TryParse(EdLf.Text.Trim(), out Lf) &&
                double.TryParse(EdTp.Text.Trim(), out Tp) &&
                double.TryParse(EdZoom.Text.Trim(), out Zoom) 
            )
            {
                RecalcImage(Lf, Tp, Zoom);
            }
        }

        private void MandelbroatForm_Resize(object sender, EventArgs e)
        {
            EdData_TextChanged(null, null);
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int sy = Box.Height >> 1, sx = Box.Width >> 1;
            double mul = MulZoom(Zoom);
            double Pi = Tp - e.Y * mul;
            double Pr = Lf + e.X * mul;
            if (e.Button == MouseButtons.Left) Zoom *= 2;
            else if (e.Button == MouseButtons.Right) Zoom /= 2;
            else return;
            mul = MulZoom(Zoom);
            EdZoom.Text = string.Format("{0:F4}", Zoom);
            EdTp.Text = string.Format("{0:F14}", Pi + sy * mul);
            EdLf.Text = string.Format("{0:F14}", Pr - sx * mul);
        }

        private double MulZoom(double Zoom)
        {
            return 3 / (Box.Width * Zoom);
        }
        private void RecalcImage(double Lf, double Tp, double Zoom)
        {
            int h = Box.Height, w = Box.Width;
            Color[,] arr = new Color[h, w];
            double mul = MulZoom(Zoom);
            for (uint y = 0; y < h; ++y)
            {
                double Pi = Tp - y * mul;
                for (uint x = 0; x < w; ++x)
                {
                    double Pr = Lf + x * mul;
                    arr[y, x] = Theme[MandelbrotCalc(Pi, Pr)];
                }
            }
            Box.Image = ArrToBmp(arr);
        }
    }
}
