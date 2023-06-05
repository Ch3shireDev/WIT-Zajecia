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
        public static readonly int size = 256;
        public static Bitmap fragment(double Lf, double Tp, double mul)
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
            return MandelbroatArray.ArrToBmp(arr);
        }
    }
}
