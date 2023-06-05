using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Arcanoid : Form
    {
        private int BoxWidth, BoxHeight;
        private Bitmap bmp;
        private Graphics gr;
        private Brush bg;
        private Carret carret;
        private List<Ball> lst, lost;
        private Random rnd = new Random((int)(DateTime.Now.Ticks));

        public Arcanoid()
        {
            InitializeComponent();
            lst = new List<Ball>();
            lost = new List<Ball>();
            carret = new Carret(120);
            BitmapResize();
            bg = new SolidBrush(Color.Silver);
            carret.XPos = BoxWidth >> 1;
            AppendBall();
        }

        private void AppendBall()
        {
            Ball ball = new Ball(0, 0, 0, 0, 0);
            lst.Add(ball);
            ball.MovePalete(carret.pos);
        }

        private void Arcanoid_Resize(object sender, EventArgs e)
        {
            BitmapResize();
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            gr.FillRectangle(bg, 0, 0, BoxWidth, BoxHeight);
            int 
                y = carret.YPos, x = carret.XPos, 
                hw = carret.HalfWidth, 
                lf = x - hw, rt = x + hw
            ;
            foreach (Ball ball in lst)
            {
                ball.TimeTick();
                ball.TopCollision(0);
                ball.LeftCollision(0);
                ball.RightCollision(BoxWidth);
                ball.CarretCollision(y, lf, rt);
                ball.Draw(gr);
                if (ball.Under(BoxHeight)) lost.Add(ball);
            }
            foreach (Ball ball in lost) lst.Remove(ball);
            lost.Clear();
            if (lst.Count <= 0)
            {
                Ticker.Enabled = false;
                MessageBox.Show("Game over");
                Ticker.Enabled = true;
                AppendBall();
            }
            carret.Draw(gr);
            Box.Invalidate();
        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Ball ball in lst) ball.MovePalete(carret.pos);
            carret.XPos = e.X;
        }

        private void Box_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Ball ball in lst) ball.Unglue(rnd);
        }

        private void BitmapResize()
        {
            BoxWidth = Box.ClientSize.Width;
            BoxHeight = Box.ClientSize.Height;
            bmp = new Bitmap(BoxWidth, BoxHeight);
            gr = Graphics.FromImage(bmp);
            Box.Image = bmp;
            carret.YPos = BoxHeight - 50;
            carret.MaxWidth = BoxWidth;
        }
    }
}
