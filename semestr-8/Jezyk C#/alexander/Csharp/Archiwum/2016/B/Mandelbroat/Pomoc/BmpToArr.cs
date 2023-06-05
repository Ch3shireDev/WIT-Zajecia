        unsafe static private Color[,] BmpToArr(Bitmap bmp)
        {
            if (bmp.PixelFormat != PixelFormat.Format24bppRgb) return null;
            int Y = bmp.Height, X = bmp.Width;
            Color[,] arr = new Color[Y, X];
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadOnly, bmp.PixelFormat);
            unsafe
            { 
                byte *ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride - 3*X)
                {
                    for (int x = 0; x < X; ++x, ptr += 3)
                    {
                        arr[y, x] = Color.FromArgb(ptr[2], ptr[1], ptr[0]);
                    }
                }
            }
            bmp.UnlockBits(data);
            return arr;
        }
