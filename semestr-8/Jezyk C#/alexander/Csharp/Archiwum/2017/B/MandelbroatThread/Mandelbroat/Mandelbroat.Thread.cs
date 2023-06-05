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
        public static readonly int size = 256;
        public delegate void CalbackProc(int x, int y, Bitmap bmp);
        private double Lf, Tp, mul;
        private int X, Y;
        private CalbackProc calback;
        public MandelbroatThread(double Lf, double Tp, double mul, int X, int Y, CalbackProc calback)
        {
            this.Lf = Lf;
            this.Tp = Tp;
            this.mul = mul;
            this.X = X;
            this.Y = Y;
            this.calback = calback;
            new Thread(run).Start();
        }
        private void run()
        {
            Color[,] arr = new Color[size, size];
            for (int y = 0; y < size; ++y)
            {
                double Pi = MandelbroadEncode.encodeY(Tp, y, mul);
                for (int x = 0; x < size; ++x)
                {
                    double Pr = MandelbroadEncode.encodeX(Lf, x, mul);
                    arr[y, x] = MandelbroatCalc.Calc(Pi, Pr);
                }
            }
            calback(X, Y, MandelbroatArray.ArrToBmp(arr));
        }
    }
}
