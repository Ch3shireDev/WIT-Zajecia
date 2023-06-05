using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotTest
{
    public partial class MandelbrotForm : Form
    {
        double X=-2, Y=-1, Zoom=1;
        public MandelbrotForm()
        {
            InitializeComponent();
            //ShowValues();
            this.ShowValues(); // jak wyżej
            //new MandelbrotForm().ShowValues();
            //MandelbrotForm.ShowValues();

            PicManbelbroat.Image = MakeBitmap();
        }
        private void ShowValues()
        {
            EdX.Text = string.Format("{0:F18}", X);
            EdY.Text = string.Format("{0:F18}", Y);
            EdZoom.Text = string.Format("{0:F18}", Zoom);
        }
        private double CalcMul()
        {
            return 3 / (Zoom * PicManbelbroat.Width);
        }
        private double ToComplex(double value,double mul,double shift)
        {
            return value * mul + shift;
        }
        private Bitmap MakeBitmap()
        {
            int ySize = PicManbelbroat.Height;
            int xSize = PicManbelbroat.Width;
            Color[,] clr = new Color[ySize, xSize];
            double mul=CalcMul();
            for (int y = 0; y < ySize; ++y)
            {
                double Pi = ToComplex(y, mul, Y);
                for (int x = 0; x < xSize; ++x)
                {
                    double Pr = ToComplex(x, mul, X);
                    uint index = MandelbrotHelper.Calc(Pi, Pr);
                    clr[y, x] = MandelbrotHelper.Theme[index];
                }
            }
            return MandelbrotHelper.ArrToBmp(clr);
        }
        private void Ed_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlClient_Resize(object sender, EventArgs e)
        {
            PicManbelbroat.Image = MakeBitmap();
            PicManbelbroat.Dock = DockStyle.Fill;
        }

        private void PicManbelbroat_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void PicManbelbroat_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void PicManbelbroat_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
