using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Steganography
{
    class ColorArray
    {
        public static byte[] ClrToBytes(Color[,] arr)
        {
            int Y = arr.GetLength(0), X = arr.GetLength(1);
            byte[] ret = new byte[Y * X * 3];
            int p = 0;
            for (int y = 0; y < Y; ++y)
            {
                for (int x = 0; x < X; ++x, p += 3) 
                {
                    Color clr = arr[y, x];
                    ret[p + 0] = clr.R;
                    ret[p + 1] = clr.G;
                    ret[p + 2] = clr.B;
                }
            }
            return ret;
        }
        public static Color[,] BytesToClr(byte[] arr, int Y, int X)
        {
            Color[,] clr = new Color[Y, X];
            int p = 0;
            for (int y = 0; y < Y; ++y)
            {
                for (int x = 0; x < X; ++x, p += 3) 
                {
                    clr[y, x] = Color.FromArgb(arr[p + 0], arr[p + 1], arr[p + 2]);
                }
            }
            return clr;
        }
    }
}
