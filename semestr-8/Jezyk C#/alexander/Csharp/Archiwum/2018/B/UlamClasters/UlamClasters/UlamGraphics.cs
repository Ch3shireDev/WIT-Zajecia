using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UlamClasters
{
    class UlamGraphics
    {
        private static Font fnt = new Font("Arial", 12);
        private static Brush back = new SolidBrush(Color.Yellow);
        private static Brush fore = new SolidBrush(Color.Red);
        private static Brush gray = new SolidBrush(Color.Gray);
        private static Pen border = new Pen(Color.Blue, 2);
        private static Pen line = new Pen(Color.Red, 4);
        private static float marg = 5;
        private bool[] sieves;
        private int[,] values;
        private int count, side, Lf, Rt, Up, Dn, Value;
        private SizeF sz;
        private Graphics g;
        private static SizeF measureAll(int max)
        {
            Graphics g = Graphics.FromImage(new Bitmap(1,1));
            SizeF sz = new SizeF(0,0);
            sz.Height = g.MeasureString("9876543210", fnt).Height;
            for (int i = 1; i <= max; ++i)
            {
                sz.Width = Math.Max(sz.Width, g.MeasureString(i.ToString(), fnt).Width);
            }
            return sz;
        }
        private void setSide(int value)
        {
            side=(int)Math.Ceiling(Math.Sqrt(value));
            count = side * side;
            sieves = new bool[count+1];
            values = new int[side, side];
        }
        private void eratostenes()
        {
            sieves[0] = sieves[1] = true;
            for (int i = 2; i <= side; ++i)
            {
                if (!sieves[i])
                {
                    for (int k = 2 * i; k < sieves.Length; k += i) sieves[k] = true;
                }
            }
        }
        private void goRtDn()
        {
            for (int i = Lf; i <= Rt; ++i) values[Up, i] = --Value;
            ++Up;
            for (int i = Up; i <= Dn; ++i) values[i, Rt] = --Value;
            --Rt;
        }
        private void goLfUp()
        {
            for (int i = Rt; i >= Lf; --i) values[Dn, i] = --Value;
            --Dn;
            for (int i = Dn; i >= Up; --i) values[i, Lf] = --Value;
            ++Lf;
        }        
        private void spirale()
        {
            Value = sieves.Length;
            Lf = Up = 0;
            Dn = Rt = side - 1;
            if((side&1)>0) goLfUp();
            while ((Lf<=Rt)&&(Up<=Dn)) { goRtDn(); goLfUp(); }            
        }
        private float Left(int x) { return marg + x * sz.Width; }
        private float Top(int y) { return marg + y * sz.Height; }
        private float Horz(int x) { return Left(x) + 0.5f * sz.Width; }
        private float Vert(int y) { return Top(y) + 0.5f * sz.Height; }
        private void drawLine(int fx,int fy, int tx, int ty)
        {
            g.DrawLine(line, Horz(fx), Vert(fy), Horz(tx), Vert(ty));
        }
        private float midOf(float big, float small)
        {
            return 0.5f * (big - small);
        }
        private void drawNonPrime(int x, int y)
        {
            float fx = Left(x), fy = Top(y);
            string str = values[y, x].ToString();
            SizeF vh = g.MeasureString(str, fnt);
            g.DrawString(str, fnt, gray, fx + midOf(sz.Width, vh.Width), fy + midOf(sz.Height, vh.Height));
        }
        private void drawPrime(int x, int y)
        {
            float fx = Left(x), fy = Top(y);
            g.FillEllipse(back, fx, fy, sz.Width, sz.Height);
            g.DrawEllipse(border, fx, fy, sz.Width, sz.Height);
            string str = values[y, x].ToString();
            SizeF vh = g.MeasureString(str, fnt);
            g.DrawString(str, fnt, fore, fx + midOf(sz.Width, vh.Width), fy + midOf(sz.Height, vh.Height));
        }
        private void drawAll()
        {
            for (int y = 0; y < side; ++y)
            {
                for (int x = 0; x < side; ++x)
                {
                    if (!sieves[values[y, x]])
                    {
                        if ((y + 1 < side) && (!sieves[values[y + 1, x]])) drawLine(x, y, x, y + 1);
                        if ((x + 1 < side) && (!sieves[values[y, x + 1]])) drawLine(x, y, x + 1, y);
                        if (y + 1 < side)
                        {
                            if ((x + 1 < side) && (!sieves[values[y + 1, x + 1]])) drawLine(x, y, x + 1, y + 1);
                            if ((x - 1 >= 0) && (!sieves[values[y + 1, x - 1]])) drawLine(x, y, x - 1, y + 1);
                        }
                        drawPrime(x, y);
                    }
                    else drawNonPrime(x, y);
                }
            }
        }
        public Bitmap calc(int value)
        {
            setSide(value);
            eratostenes();
            spirale();
            sz = measureAll(count);
            float sqr = (float)Math.Sqrt(2);
            sz.Width = sqr * (sz.Width + 3);
            sz.Height = sqr * (sz.Height + 3);
            int width = (int)(marg + side * (marg + sz.Width));
            int height = (int)(marg + side * (marg + sz.Height));
            Bitmap bmp = new Bitmap(width, height);
            g = Graphics.FromImage(bmp);
            drawAll();
            return bmp;
        }

    }
}
