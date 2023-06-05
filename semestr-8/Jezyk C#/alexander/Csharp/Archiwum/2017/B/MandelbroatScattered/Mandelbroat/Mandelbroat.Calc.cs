using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Mandelbroat
{
    class MandelbroatCalc
    {
        public static Color Calc(double Pi, double Pr)
        {
            int max = MandelbroatColors.Theme.Length - 1, i = 0;
            for (double Zr = 0, Zi = 0; i < max; ++i)
            {
                double Tmp = Zr * Zr - Zi * Zi + Pr;
                Zi = 2 * Zr * Zi + Pi;
                Zr = Tmp;
                if (Zr * Zr + Zi * Zi >= 4) break;
            }
            return MandelbroatColors.Theme[i];
        }
    }
}
