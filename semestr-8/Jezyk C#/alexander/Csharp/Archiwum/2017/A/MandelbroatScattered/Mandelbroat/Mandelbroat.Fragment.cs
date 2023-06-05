using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mandelbroat
{
    class MandelbroatFragment
    {
        public static readonly int size = 128;
        public static Bitmap calculate(double Lf, double Tp, double mul)
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
            return MandelbroatProc.ArrToBmp(clr);
        }
    }
}
