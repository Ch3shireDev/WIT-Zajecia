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
    public partial class MandelbrotMainForm : Form
    {
        private double X=-2, Y=1, Zoom=1;
        private int DownX, DownY;
        private bool IsDown,IsMoved;
        public MandelbrotMainForm()
        {
            InitializeComponent();
            ShowValues(X, Y, Zoom);
        }
        private void ShowValues(double x,double y,double zoom)
        {
            TbX.Text = string.Format("{0:F18}", X = x);
            TbY.Text = string.Format("{0:F18}", Y = y);
            TbZoom.Text = string.Format("{0:F18}", Zoom = zoom);
        }
        private double CalcMultiply()
        {
            return 3 / (Zoom * PbImage.Width);
        }
        private double ToComplex(int value, double multiply, double shift)
        {
            return value * multiply + shift;
        }
        private int FromComplex(double value, double multiply, double shift)
        {
            return (int)Math.Round((value - shift) / multiply);
        }
        private Bitmap MakeImage()
        {
            int ySize = PbImage.Height;
            int xSize = PbImage.Width;
            Color[,] clr = new Color[ySize, xSize];
            double mul = CalcMultiply();
            for (int y = 0; y < ySize; ++y)
            {
                double Pi = ToComplex(y, -mul, Y);
                for (int x = 0; x < xSize; ++x)
                {
                    double Pr = ToComplex(x, +mul, X);
                    clr[y, x] = MandelbrotHelper.Theme[MandelbrotHelper.Calc(Pi, Pr)];
                }
            }
            return MandelbrotHelper.ArrToBmp(clr);
        }
        private void Repaint()
        {
            PbImage.Image = MakeImage();
        }

        private void DoZoomIn(int pY, int pX)
        {

        }
        private void DoZoomOut(int pY, int pX)
        {

        }

        private void DoDrag(int pY, int pX, int tY, int tX)
        {

        }

        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
            IsMoved = false;
            DownY = e.Y;
            DownX = e.X;
        }

        private void PbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                DoDrag(DownY, DownX, e.Y, e.X);
                IsMoved = true;
                DownX = e.X;
                DownY = e.Y;
            }
        }

        private void PbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if ((IsDown) && (!IsMoved))
            {
                if(e.Button==MouseButtons.Left) DoZoomIn(DownY, DownX);
                else if (e.Button == MouseButtons.Right) DoZoomOut(DownY, DownX);
            }
        }

        private void MandelbrotMainForm_Resize(object sender, EventArgs e)
        {
            PbImage.Dock = DockStyle.Fill;
            Repaint();
        }
        private void TbParameters_TextChanged(object sender, EventArgs e)
        {
            double x=0, y=0, zoom=0;
            bool ok
            =
                double.TryParse(TbX.Text.Trim(), out x) &&
                double.TryParse(TbY.Text.Trim(), out y) &&
                double.TryParse(TbZoom.Text.Trim(), out zoom)
            ;
            if(ok)
            {
                X = x;
                Y = y;
                Zoom = zoom;
                Repaint();
            }
        }
    }
}
