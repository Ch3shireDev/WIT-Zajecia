using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ulam
{
    class UlamHelper
    {
        private static readonly float sqrt2 = (float)Math.Sqrt(2);
        private static readonly int Margine = 8;
        private static readonly Font fontBold = new Font("Arial", 12, FontStyle.Bold);
        private static readonly Font fontItalic = new Font("Arial", 12, FontStyle.Italic);
        private static readonly Pen linePen = new Pen(Color.Red, 2);
        private int side,count;
        private bool[] noPrime;
        private int[,] spiral;
        private SizeF textSize,elipseSize,halfElipseSize;
        private Bitmap bitmap;
        private Graphics gr;
        private UlamHelper(int count)
        {
            side = (int)Math.Ceiling(Math.Sqrt(count));
            this.count = side * side;
            Primes();
            Spiral();
            AdjustSizes();
            MakeBitmap();
            return;
        }
        private void Primes()
        {
            noPrime = new bool[count + 1];
            noPrime[0] = noPrime[1] = true;
            for (int i = 2; i * i <= count; ++i)
            {
                if(!noPrime[i])
                {
                    for (int k = i << 1; k <= count; k += i) noPrime[k] = true;
                }
            }
        }
        private void Spiral()
        {
            spiral = new int[side, side];
            int MinR = 0, MinC = 0, MaxR = side - 1, MaxC = side - 1;
            int cnt = count;
            while ((MinR <= MaxR) && (MinC <= MaxC))
            {
                if((cnt & 1)==0) // if(cnt % 2 == 0)
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
        private void AdjustSizes()
        {
            bitmap = new Bitmap(1, 1);
            gr = Graphics.FromImage(bitmap);
            textSize = new SizeF(0,0);
            for (int i = 1; i <= count; ++i)
            {
                string text = i.ToString();
                SizeF currText = gr.MeasureString(text, fontBold);
                //if (textSize.Width < currText.Width) textSize.Width = currText.Width;
                textSize.Width = Math.Max(textSize.Width, currText.Width);
                textSize.Height = Math.Max(textSize.Height, currText.Height);
            }
            elipseSize = new SizeF(textSize.Width * sqrt2,textSize.Height * sqrt2);
            halfElipseSize = half(elipseSize);
        }
        private SizeF half(SizeF size)
        {
            return new SizeF(size.Width * 0.5F, size.Height * 0.5F);
        }
        private PointF increment(PointF point, SizeF size)
        {
            return new PointF(point.X + size.Width, point.Y + size.Height);
        }
        private PointF decrement(PointF point, SizeF size)
        {
            return new PointF(point.X - size.Width, point.Y - size.Height);
        }
        private PointF corner(int r,int c)
        {
            return new PointF
            (
                Margine + c * (elipseSize.Width + Margine),
                Margine + r * (elipseSize.Height + Margine)
            );
        }
        private void MakeBitmap()
        {
            PointF bmpSize = corner(side, side);
            bitmap = new Bitmap((int)bmpSize.X, (int)bmpSize.Y);
            gr = Graphics.FromImage(bitmap);
            int last = side - 1;
            for (int r = 1; r < last; ++r)
            {
                for (int c = 1; c < last; ++c)
                {
                    if(!noPrime[spiral[r, c]])
                    {
                        PointF from = increment(corner(r, c), halfElipseSize);
                        for (int dr = -1; dr <= 1; ++dr)
                        {
                            for (int dc = -1; dc <= 1; ++dc)
                            {
                                if ((dc != 0) || (dr != 0))
                                {
                                    int er = r + dr, ec = c + dc;
                                    if (!noPrime[spiral[er, ec]])
                                    {
                                        //PointF from = increment(corner(r, c), halfElipseSize);
                                        PointF to = increment(corner(er, ec), halfElipseSize);
                                        gr.DrawLine(linePen, from, to);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int r=0;r<side;++r)
            {
                for (int c = 0; c < side; ++c)
                {
                    int i=spiral[r,c];
                    string text = i.ToString();
                    PointF LT = corner(r, c);
                    SizeF currText = half(gr.MeasureString(text, fontBold));
                    PointF where = decrement(increment(LT, halfElipseSize), currText);
                    if(!noPrime[i])
                    {
                        gr.FillEllipse(Brushes.Yellow, LT.X, LT.Y, elipseSize.Width, elipseSize.Height);
                        gr.DrawEllipse(linePen, LT.X, LT.Y, elipseSize.Width, elipseSize.Height);
                        gr.DrawString(text, fontBold, Brushes.Blue, where);
                    }
                    else gr.DrawString(text, fontItalic, Brushes.Black, where);
                }
            }
        }
        public static Bitmap makeBitmap(int count)
        {
            return new UlamHelper(count).bitmap;
        }
    }
}
