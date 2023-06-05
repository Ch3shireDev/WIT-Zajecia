using System.Drawing;

namespace MandelbrotTest
{
    partial class Mandelbrot
    {
        public static uint Calc(double Pi, double Pr)
        {
            uint max = (uint)Theme.Length - 1, i = 0;
            for (double Zr = 0, Zi = 0; i < max; ++i)
            {
                double Tmp = Zr * Zr - Zi * Zi + Pr;
                Zi = 2 * Zr * Zi + Pi;
                Zr = Tmp;
                if (Zr * Zr + Zi * Zi >= 4) return i;
            }
            return max;
        }
        public static void Calc(ref Color color, double Im, double Re)
        {
            color = Mandelbrot.Theme[Mandelbrot.Calc(Im, Re)];
        }
    }
}
