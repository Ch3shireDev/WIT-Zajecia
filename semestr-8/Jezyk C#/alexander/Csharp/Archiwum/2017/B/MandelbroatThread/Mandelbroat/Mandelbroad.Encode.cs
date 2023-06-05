using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbroat
{
    class MandelbroadEncode
    {
        public static double encodeX(double Lf, int x, double mul) { return Lf + x * mul; }
        public static double encodeY(double Tp, int y, double mul) { return Tp - y * mul; }
        public static double decodeX(double Pr, int x, double mul) { return Pr - x * mul; }
        public static double decodeY(double Pi, int y, double mul) { return Pi + y * mul; }
    }
}
