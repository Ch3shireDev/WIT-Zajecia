using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace MandelbrotTest
{
    public partial class MandelbrotHelper
    {
        public static double CalcMul(double zoom,int pictureHeight,int pictureWidth)
        {
            return (2*pictureWidth<3*pictureHeight)? 3 / (zoom * pictureWidth) : 2 / (zoom * pictureHeight) ;
        }
        public static double ToComplex(double value,double mul,double shift)
        {
            return value * mul + shift;
        }
    }
}
