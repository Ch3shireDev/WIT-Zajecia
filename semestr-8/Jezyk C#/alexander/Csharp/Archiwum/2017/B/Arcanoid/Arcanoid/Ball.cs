using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    class Ball
    {
        private static int radius = 5;
        private Point pos, delta;
        private Size size;
        private int glue;
        public Ball(int y, int x, int dy, int dx, int glue)
        {
            pos = new Point(x, y);
            delta = new Point(dx, dy);
            size = new Size(2 * radius + 1, 2 * radius + 1);
            this.glue = glue;
        }
        public void MovePalete(Point pal)
        {
            if (glue != int.MinValue)
            {
                pos = new Point(pal.X + glue, pal.Y - radius - 1);
            }
        }
        public void TimeTick()
        {
            pos.X += delta.X;
            pos.Y += delta.Y;
        }
        public void Draw(Graphics g)
        {
            Point shift = new Point(pos.X - radius, pos.Y - radius);
            g.FillEllipse(Brushes.Red, new Rectangle(shift, size));
        }
        public void Unglue(Random rnd)
        {
            if (glue != int.MinValue)
            {
                glue = int.MinValue;
                delta.Y = rnd.Next(-18, -10);
                delta.X = rnd.Next(-3, 3);
            }
        }
        public void TopCollision(int Top)
        {
            Top += radius + 1;
            if (pos.Y < Top)
            {
                pos.Y = Top - 2 * pos.Y;
                delta.Y = -delta.Y;
            }
        }
        public void LeftCollision(int Left)
        {
            Left += radius + 1;
            if (pos.X < Left)
            {
                pos.X = Left - 2 * pos.X;
                delta.X = -delta.X;
            }
        }
        public void RightCollision(int Right)
        {
            Right -= radius + 1;
            if (pos.X > Right)
            {
                pos.X = 2 * Right - pos.X;
                delta.X = -delta.X;
            }
        }
        public void CarretCollision(int Bottom, int Left, int Right)
        {
            Bottom -= radius + 1;
            if (pos.Y > Bottom)
            {
                int X = pos.X + delta.X * (Bottom - pos.Y) / delta.Y;
                if ((Left <= X) && (X <= Right))
                {
                    pos.Y = 2 * Bottom - pos.Y;
                    delta.Y = -delta.Y;
                }
            }
        }
        public bool Under(int Bottom)
        {
            return pos.Y > Bottom;
        }
    }
}
