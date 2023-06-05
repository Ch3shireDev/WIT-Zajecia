using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography
{
    class Helper
    {
        
        public static void hideText(string text, Bitmap bmp)
        {
            
            int index = 0;
            byte[] bytes = new UTF8Encoding().GetBytes(text);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0; //take the data 
                for (int row = 0; row < bmp.Height; ++row)
                {
                    for (int i = 0, column = 0; column < bmp.Width; ++column)
                    {
                        //pick the bit color 
                        for (int clr = 0; clr < 3; ++clr, ++i)
                        {
                            // index is bit number of whole the text
                            int byte_number = index >> 3;
                            int bit_number = index & 7;
                            int bit=0;
                            if (byte_number < bytes.Length)
                            {
                                bit = (bytes[byte_number] >> bit_number) & 1;
                            }
                            ptr[i] = (byte)(((ptr[i] | 1) ^ 1) | bit);
                            //ptr[i] =  (byte)(ptr[i] - ptr[i] % 2);
                            ++index;
                        }
                    }
                    ptr += data.Stride;
                }
                if (ptr != null) ++ptr;            
            }
            bmp.UnlockBits(data);
        }

        public static string extractText(Bitmap bmp)
        {
            int index = 0;
            int current_byte = 0;
            bool flaga = true;
            List<byte> bytes = new List<byte>();

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0; //take the data 
                for (int row = 0; row < bmp.Height; ++row)
                {
                    for (int i = 0, column = 0; column < bmp.Width; ++column)
                    {
                        //pick the bit color 
                        for (int clr = 0; clr < 3; ++clr, ++i)
                        {
                            // index is bit number of whole the text
                            int bit_number = index & 7;
                            current_byte |= (ptr[i] & 1) << bit_number;
                            if (((++index) & 7) == 0 && flaga)
                            {
                                if (current_byte == 0) flaga = false;
                                else bytes.Add((byte)current_byte);
                                current_byte = 0;
                            }
                        }
                    }
                    ptr += data.Stride;
                }             
            }
            bmp.UnlockBits(data);
            return new UTF8Encoding().GetString(bytes.ToArray());
        }

    }
}
