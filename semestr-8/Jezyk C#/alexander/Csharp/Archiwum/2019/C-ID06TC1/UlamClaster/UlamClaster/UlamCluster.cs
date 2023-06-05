using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UlamClasterTest
{
    public class UlamCluster
    {
        private static int margine = 10;
        private static Font fnt = new Font("Arial", 12);
        private static Brush gray = Brushes.Gray;
        private static Brush yellow = Brushes.Yellow;
        private static Pen pgray = Pens.Gray;
        private static Pen pred = Pens.Red;
        private static Pen blue = Pens.Blue;
        private Bitmap bmp;
        private int size, max;
        private int[,] tb;
        private bool[] primes;
        private SizeF ellipseRect, cellRect;
        public static Bitmap Make(int number)
        {
            return new UlamCluster(number).bmp;
        }
        private UlamCluster(int number)
        {
            Init(number);
            Eratoistenes();
            Spiral();
            Draw();
        }
        private void Init(int number)
        {
            size = (int)Math.Ceiling(Math.Sqrt(number));
            max = size * size;
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            SizeF textRect = g.MeasureString("9876543210", fnt);
            textRect.Width = 0;
            for (int i = 1; i <= max; ++i)
            {
                textRect.Width = Math.Max(textRect.Width, g.MeasureString(i.ToString(), fnt).Width);
            }
            float sqr = (float)Math.Sqrt(2);
            ellipseRect = new SizeF(sqr * textRect.Width + 1, sqr * textRect.Height + 1);
            cellRect = new SizeF(ellipseRect.Width + margine, ellipseRect.Height + margine);
            bmp = new Bitmap((int)Left(size), (int)Top(size));
        }
        private void Eratoistenes()
        {
            primes = new bool[max + 1];
            for (int i = 2; i <= max; ++i) primes[i] = true;
            for (int i = 2; i <= size; ++i)
            {
                if (primes[i]) for (int k = 2 * i; k <= max; k += i) primes[k] = false;
            }
        }
        private void Spiral()
        {
            tb = new int[size, size];
            int L = 0, U = 0, R = size - 1, D = R, val = max + 1;
            for (int s = size; s > 0; --s)
            {
                if ((s & 1) > 0)
                {
                    for (int x = R; x >= L; --x) tb[D, x] = --val;
                    --D;
                    for (int y = D; y >= U; --y) tb[y, L] = --val;
                    ++L;
                }
                else
                {
                    for (int x = L; x <= R; ++x) tb[U, x] = --val;
                    ++U;
                    for (int y = U; y <= D; ++y) tb[y, R] = --val;
                    --R;
                }
            }
        }
        private float Left(int x) { return margine + x * cellRect.Width; }
        private float Top(int y) { return margine + y * cellRect.Height; }
        private float Horz(int x, float sz = 0) { return Left(x) + 0.5F * (ellipseRect.Width - sz); }
        private float Vert(int y, float sz = 0) { return Top(y) + 0.5F * (ellipseRect.Height - sz); }
        private void Draw()
        {
            Graphics g = Graphics.FromImage(bmp);
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    int n = tb[y, x];
                    string str = n.ToString();
                    SizeF textRect = g.MeasureString(str, fnt);
                    float midL = Horz(x);
                    float midT = Vert(y);
                    float L = Horz(x, textRect.Width);
                    float T = Vert(y, textRect.Width);
                    float Lf = Left(x);
                    float Tp = Top(y);
                    if (primes[n])
                    {
                        if(x+1<size)
                        {
                            if(primes[tb[y, x+1]]) g.DrawLine(pred,midL,midT, Horz(x+1),Vert(y));
                            if (y + 1 < size)
                            {
                                if (primes[tb[y + 1, x + 1]]) g.DrawLine(pred, midL, midT, Horz(x + 1), Vert(y + 1));
                            }
                        }
                        if (y + 1 < size)
                        {
                            if (primes[tb[y + 1, x]]) g.DrawLine(pred, midL, midT, Horz(x), Vert(y + 1));
                            if (x > 0)
                            {
                                if (primes[tb[y + 1, x - 1]]) g.DrawLine(pred, midL, midT, Horz(x - 1), Vert(y + 1));
                            }
                        }

                        g.FillEllipse(yellow,Lf, Tp,ellipseRect.Width,ellipseRect.Height);
                        g.DrawEllipse(blue, Lf, Tp, ellipseRect.Width, ellipseRect.Height);
                        g.DrawString(str, fnt, Brushes.Black, L, T);
                    }
                    else g.DrawString(str, fnt, gray, L, T);
                }
            }
        }
    }
}
