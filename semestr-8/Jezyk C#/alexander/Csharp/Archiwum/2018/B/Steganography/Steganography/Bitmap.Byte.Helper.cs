using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BitmapHelper
{
    class BitmapArray
    {
        unsafe public static Bitmap ArrToBmp(byte[] arr, int X, int Y)
        {
            //int Y = arr.Length / (3 * X);
            int rowsize = 3 * X;
            Bitmap bmp = new Bitmap(X, Y, PixelFormat.Format24bppRgb);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride) Marshal.Copy(arr, y * rowsize, (IntPtr)ptr, rowsize);
            }
            bmp.UnlockBits(data);
            return bmp;
        }
        unsafe public static byte[] BmpToArr(Bitmap bmp)
        {
            int Y = bmp.Height, X = bmp.Width, rowsize = 3 * X;
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] arr=new byte[3*Y*X];
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride) Marshal.Copy((IntPtr)ptr, arr, y * rowsize, rowsize);
            }
            bmp.UnlockBits(data);
            return arr;
        }
    }
}
