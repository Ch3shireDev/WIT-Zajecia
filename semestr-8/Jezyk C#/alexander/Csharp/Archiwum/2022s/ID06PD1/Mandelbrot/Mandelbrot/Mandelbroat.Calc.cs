using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Mandelbrot
{
    public partial class MandelbrotHelper
    {
        public static uint Calc(double Pi, double Pr)
        {
            uint max = (uint)Theme.Length - 1, i = 0;
            for (double Zr = 0, Zi = 0; i < max; ++i)
            {
                //(Zr+i*Zi)*(Zr+i*Zi)
                //Zr*Zr + 2*Zr*i*Zi + i*i*Zi*Zi
                //Zr*Zr - Zi*Zi + i*2*Zr*Zi 
                double Tmp = Zr * Zr - Zi * Zi + Pr;
                Zi = 2 * Zr * Zi + Pi;
                Zr = Tmp;
                if (Zr * Zr + Zi * Zi >= 4) return i;
            }
            return max;
        }
    }
}
