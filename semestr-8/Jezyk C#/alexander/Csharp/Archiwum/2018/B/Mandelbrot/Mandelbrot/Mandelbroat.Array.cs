using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace MandelbroatArray
{
    class Array
    {
        unsafe static public Bitmap ArrToBmp(Color[,] arr)
        {
            int Y = arr.GetLength(0), X = arr.GetLength(1);
            Bitmap bmp = new Bitmap(X, Y, PixelFormat.Format24bppRgb);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride - 3 * X)
                {
                    for (int x = 0; x < X; ++x, ptr += 3)
                    {
                        Color clr = arr[y, x];
                        ptr[2] = clr.R;
                        ptr[1] = clr.G;
                        ptr[0] = clr.B;
                    }
                }
            }
            bmp.UnlockBits(data);
            return bmp;
        }
    }
}
