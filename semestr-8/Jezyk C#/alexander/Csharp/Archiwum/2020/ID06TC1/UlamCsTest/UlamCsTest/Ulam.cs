using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UlamCsTest
{
    class Ulam
    {
        private static Font boldFont = new Font("Arial", 8, FontStyle.Bold);
        private static Font italicFont = new Font("Arial", 8, FontStyle.Italic);
        private static float sqrt2 = (float)Math.Sqrt(2);
        private static int margine = 8;
        private int side,count;
        private Bitmap bitmap;
        private Graphics gr;
        private SizeF textSize,ellipseSize,halfSize;
        private bool[] NoPrimes;
        private int[,] spiral;
        private Ulam(int count)
        {
            side = (int)Math.Ceiling(Math.Sqrt(count));
            this.count = side * side;
            Primes();
            Spiral();
            Measure();
            Draw();
            return;
        }
        private void Draw()
        {
            PointF bitmapSize = ellipsePos(side, side);
            bitmap = new Bitmap((int)bitmapSize.X, (int)bitmapSize.Y);
            gr = Graphics.FromImage(bitmap);
            for (int r = 1; r < side - 1; ++r)
            {
                for (int c = 1; c < side - 1; ++c)
                {
                    int i = spiral[r, c];
                    if (!NoPrimes[i])
                    {
                        PointF start = inc(ellipsePos(r, c), halfSize);
                        for (int dr = -1; dr <= 1; ++dr)
                        {
                            for (int dc = -1; dc <= 1; ++dc)
                            {
                                if(dr!=0 || dc!=0)
                                {
                                    int er = r + dr, ec = c + dc;
                                    if (!NoPrimes[spiral[er, ec]])
                                    {
                                        PointF end = inc(ellipsePos(er, ec), halfSize);
                                        gr.DrawLine(Pens.Red, start, end);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int r = 0; r < side; ++r) 
            {
                for (int c = 0; c < side; ++c)
                {
                    int i = spiral[r, c];
                    string text = i.ToString();
                    SizeF currSize = gr.MeasureString(text, boldFont);
                    PointF ellipse = ellipsePos(r,c);
                    PointF middle = inc(ellipse,halfSize);
                    if(!NoPrimes[i])
                    {
                        gr.FillEllipse(Brushes.Yellow, ellipse.X, ellipse.Y, ellipseSize.Width, ellipseSize.Height);
                        gr.DrawEllipse(Pens.Red, ellipse.X, ellipse.Y, ellipseSize.Width, ellipseSize.Height);
                        gr.DrawString(text, boldFont, Brushes.Black, dec(middle, half(currSize)));
                    }
                    else gr.DrawString(text, italicFont, Brushes.Gray, dec(middle, half(currSize)));
                }
            }
        }
        private void Measure()
        {
            bitmap=new Bitmap(1,1);
            gr = Graphics.FromImage(bitmap);
            textSize = new SizeF(0, 0);
            for(int i=1;i<=count;++i)
            {
                SizeF currSize = gr.MeasureString(i.ToString(), boldFont);
                textSize.Width = Math.Max(textSize.Width, currSize.Width);
                textSize.Height = Math.Max(textSize.Height, currSize.Height);
            }
            ellipseSize = new SizeF(textSize.Width * sqrt2, textSize.Height * sqrt2);
            halfSize = half(ellipseSize);
        }
        private PointF inc(PointF point, SizeF size)
        {
            return new PointF(point.X + size.Width, point.Y + size.Height);
        }
        private PointF dec(PointF point, SizeF size)
        {
            return new PointF(point.X - size.Width, point.Y - size.Height);
        }
        private SizeF half(SizeF size)
        {
            return new SizeF(size.Width*0.5F,size.Height*0.5F);
        }
        private PointF ellipsePos(int r,int c)
        {
            return new PointF
            (
                margine + c * (ellipseSize.Width + margine),
                margine + r * (ellipseSize.Height + margine)
            );
        }
        private void Spiral()
        {
            spiral = new int[side, side];
            int MinC = 0, MinR = 0, MaxC = side - 1, MaxR = side - 1, cnt = count;
            while((MinC<=MaxC)&&(MinR<=MaxR))
            {
                if((cnt&1)==0)
                {
                    for (int c = MinC; c <= MaxC; ++c) spiral[MinR, c] = cnt--;
                    ++MinR;
                    for (int r = MinR; r <= MaxR; ++r) spiral[r, MaxC] = cnt--;
                    --MaxC;
                }
                else
                {
                    for (int c = MaxC; c >= MinC; --c) spiral[MaxR, c] = cnt--;
                    --MaxR;
                    for (int r = MaxR; r >= MinR; --r) spiral[r, MinC] = cnt--;
                    ++MinC;
                }
            }
        }
        private void Primes()
        {
            NoPrimes = new bool[count + 1];
            NoPrimes[0]=NoPrimes[1]=true;
            for (int i = 2; i * i <= count; ++i)
            {
                if(!NoPrimes[i])
                {
                    for (int k = i << 1; k <= count; k += i) NoPrimes[k] = true;
                }
            }
        }

        public static Bitmap make(int count)
        {
            return new Ulam(count).bitmap;
        }
    }
}
