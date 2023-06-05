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
            EdX.Text = "-2";
            EdY.Text = "-1";
            EdZoom.Text = "1";
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
            EdData_TextChanged(null, null);
        }

        private double ZoomMul(double Zoom)
        {
            return 3 / (Box.Width * Zoom);
        }

        private void RecalcFractal(double Lf, double Tp, double Zoom)
        {
            int sx = Box.Width, sy = Box.Height;
            double mul = ZoomMul(Zoom);
            Color[,] clr = new Color[sy, sx];
            for (int y = 0; y < sy; ++y)
            {
                double Pi = Tp + y * mul;
                for (int x = 0; x < sx; ++x)
                {
                    double Pr = Lf + x * mul;
                    clr[y, x] = Theme[MandelbrotCalc(Pi, Pr)];
                }
            }
            Box.Image = ArrToBmp(clr);
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            int sx = Box.Width >> 1, sy = Box.Height >> 1;
            double mul = ZoomMul(Zoom);
            double Pi = Tp + y * mul, Pr = Lf + x * mul;
            if (e.Button == MouseButtons.Left) Zoom *= 2;
            else if (e.Button == MouseButtons.Right) Zoom /= 2;
            else return;
            mul = ZoomMul(Zoom);
            EdZoom.Text = string.Format("{0:F14}", Zoom);
            EdX.Text = string.Format("{0:F14}", Pr - sx * mul);
            EdY.Text = string.Format("{0:F14}", Pi - sy * mul);
        }
    }
}
