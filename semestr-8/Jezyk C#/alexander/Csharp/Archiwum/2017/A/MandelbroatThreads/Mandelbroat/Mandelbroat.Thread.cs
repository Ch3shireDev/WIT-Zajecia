using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Mandelbroat
{
    class MandelbroatThread
    {
        public delegate void MandelbroadResultReport(int X, int Y, Bitmap bmp);
        private double Lf, Tp, mul;
        private int X, Y;
        private MandelbroadResultReport report;
        public static readonly int size = 128;
        public MandelbroatThread(double Lf, double Tp, double mul, int X, int Y, MandelbroadResultReport report)
        {
            this.Lf = Lf;
            this.Tp = Tp;
            this.mul = mul;
            this.X = X;
            this.Y = Y;
            this.report = report;
            new Thread(run).Start();
        }
        private void run()
        {
            Color[,] clr = new Color[size, size];
            for (int y = 0; y < size; ++y)
            {
                double Pi = MandelbroatProc.encodeY(y, Tp, mul);
                for (int x = 0; x < size; ++x)
                {
                    double Pr = MandelbroatProc.encodeX(x, Lf, mul);
                    clr[y, x] = MandelbroatProc.MandelbrotCalc(Pi, Pr);
                }
            }
            report(X, Y, MandelbroatProc.ArrToBmp(clr));
        }
    }
}
