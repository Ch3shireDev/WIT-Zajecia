using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbroat
{
    partial class MandelbroatProc
    {
        public static double encodeX(int x, double Lf, double mul)
        {
            return Lf + x * mul;
        }
        public static double encodeY(int y, double Tp, double mul)
        {
            return Tp - y * mul;
        }
        public static double decodeX(int x, double Pr, double mul)
        {
            return Pr - x * mul;
        }
        public static double decodeY(int y, double Pi, double mul)
        {
            return Pi + y * mul;
        }
    }
}
