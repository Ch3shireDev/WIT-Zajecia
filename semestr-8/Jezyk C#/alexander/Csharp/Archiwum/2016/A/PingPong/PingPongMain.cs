using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class PingPongMain : Form
    {
        //[System.Runtime.InteropServices.DllImport("User32.dll")]
        //private static extern short GetAsyncKeyState(Keys vKey);
        private Size size;
        private Point where;
        private Brush bg;
        private List<Ball> lst;
        private Random rnd = new Random((int)(DateTime.Now.Ticks));

        public PingPongMain()
        {
            InitializeComponent();
            size = new Size(100, 7);
            int x = (box.Width-size.Width)/2;
            where = new Point(x, box.Height - 5 - size.Height);
            bg = Brushes.Blue;
            lst = new List<Ball>();
            AppendBall();
            timer.Enabled = true;
        }

        private int MinMax(int value)
        {
            return Math.Max(0, Math.Min(box.Width - size.Width, value));
        }

        private void AppendBall()
        {
            Ball ball = new Ball(0, 0, 0, 0, size.Width / 2);
            lst.Add(ball);
            ball.MovePalete(where);
        }

        private void box_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(bg, new Rectangle(where, size));
            foreach (Ball ball in lst) ball.Draw(e.Graphics);
        }

        private void box_MouseMove(object sender, MouseEventArgs e)
        {
            where.X = MinMax(e.X - size.Width / 2);
            foreach (Ball ball in lst) ball.MovePalete(where);
            box.Invalidate();
        }

        private void box_Resize(object sender, EventArgs e)
        {
            where.Y = box.Height - 5;
            where.X = MinMax(where.X);
            foreach (Ball ball in lst) ball.MovePalete(where);
            box.Invalidate();
        }

        private void box_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Ball ball in lst) ball.Unglue(rnd);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Ball ball in lst) ball.TimeTick();
            foreach (Ball ball in lst) ball.TopCollision(0);
            foreach (Ball ball in lst) ball.LeftCollision(0);
            foreach (Ball ball in lst) ball.RightCollision(box.Width);
            foreach (Ball ball in lst) ball.BottomCollision(where.Y, where.X, where.X + size.Width);
            for (int i=lst.Count-1;i>=0;--i) if (lst[i].Under(box.Height)) lst.RemoveAt(i);
            if (lst.Count == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("Game over");
                AppendBall();
                timer.Enabled = true;
            }
            box.Invalidate();
        }
    }

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
            size = new Size(2* radius + 1, 2 * radius + 1);
            this.glue = glue;
        }
        public void MovePalete(Point pal)
        {
            if (glue >= 0) pos = new Point(pal.X + glue, pal.Y - radius - 1);
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
            if (glue >= 0)
            {
                glue = -1;
                delta.Y = rnd.Next(-18, -10);
                delta.X = rnd.Next(-3, 3);
            }
        }
        public void TopCollision(int Top)
        {
            Top += radius + 1;
            if(pos.Y < Top)
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
        public void BottomCollision(int Bottom,int Left,int Right)
        {
            Bottom -= radius + 1;
            if (pos.Y > Bottom)
            {
                int X = pos.X + delta.X*(Bottom-pos.Y)/delta.Y;
                if ((Left <= X) && (X<=Right))
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
