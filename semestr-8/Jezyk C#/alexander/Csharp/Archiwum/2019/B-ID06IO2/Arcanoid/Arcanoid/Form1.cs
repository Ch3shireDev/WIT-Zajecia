using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arcanoid
{
    public partial class ArcanoidForm : Form
    {
        private Board board;
        private System.Threading.Timer tm;
        public ArcanoidForm()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            //TopMost = false;
            //WindowState = FormWindowState.Normal;
        }
        private void OnDrawEvent(Object source)
        {
            if (board == null) return;
            board.Move();
            Box.Invalidate();
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Box.Image = (board = new Board(Box.Width, Box.Height)).bitmap;
            if (tm != null) tm.Dispose();
            tm = new System.Threading.Timer(OnDrawEvent, null, 20, 20);
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e) { Close(); }
        private void Box_MouseMove(object sender, MouseEventArgs e) { board.MoveEvent(e.X); }
        private void Box_Click(object sender, EventArgs e) { board.Unglue(); }
    }
    class Board
    {
        private static Color field = Color.Green;
        public Bitmap bitmap { get; private set; }
        public Graphics g { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        public Paddle paddle { get; private set; }
        private List<Ball> balls = new List<Ball>();
        public Board(int w, int h)
        {
            width = w;
            height = h;
            g = Graphics.FromImage(bitmap = new Bitmap(w, h));
            paddle = new Paddle(this);
            balls.Add(new Ball(this, paddle));
        }
        private void Clear() { g.Clear(field); }
        public void MoveEvent(int x) { paddle.MoveEvent(x); }
        public void Unglue() { foreach (Ball ball in balls) ball.Unglue(); }
        public void Move()
        {
            Clear();
            paddle.Move();
            foreach (Ball ball in balls) ball.Move();
        }
    }

    class Paddle
    {
        private static Brush brush = Brushes.Blue;
        private static int from_bottom = 5;
        private static int normal_height = 15;
        private static int normal_width = 60;
        private float dx, mx;
        public float x { get; private set; }
        public int width { get; private set; }
        public int top { get; private set; }
        private Board board;
        public Paddle(Board board)
        {
            this.board = board;
            this.width = normal_width;
            top = board.height - normal_height - from_bottom;
            x = width >> 1;
        }
        public float getX() { return x; }
        public float getY() { return top; }
        public void MoveEvent(float xto) { dx = 0.2F * ((mx = xto) - x); }
        public void Move()
        {
            x = Math.Min(board.width - width, Math.Max(width, x + dx));
            MoveEvent(mx);
            board.g.FillRectangle(brush, x - width, top, width << 1, normal_height);
        }
    }
    class Ball
    {
        private static Random rnd = new Random();
        private static Brush brush = Brushes.Red;
        private static int ball_radius = 5;
        private Board board;
        private Paddle paddle;
        private float x, y, sx, sy, dx, dy;
        public Ball(Board board, Paddle paddle)
        {
            this.board = board;
            Glue(paddle);
        }
        public void Glue(Paddle paddle)
        {
            this.paddle = paddle;
            sx = x = paddle.getX();
            sy = y = paddle.getY() - ball_radius;
        }
        public void Unglue()
        {
            if (paddle != null)
            {
                dy = -12;
                dx = (float)(5*(rnd.NextDouble()-0.5));
                paddle = null;
            }
        }

        public void Move()
        {
            if (paddle != null)
            {
                x = paddle.getX();
                y = paddle.getY() - ball_radius;
            }
            else
            {
                sx = x;
                sy = y;
                x += dx;
                y += dy;
                bool more = true;
                Paddle pad = board.paddle;
                float px = pad.x, pw = pad.width, py = pad.top, boardwidth = board.width, boardheight = board.height;
                while (more)
                {
                    more = false;
                    if (x < ball_radius)
                    {
                        sx = x;
                        x = 2 * ball_radius - x;
                        dx = -dx;
                        more = true;
                    }
                    if (x > boardwidth - ball_radius)
                    {
                        sx = x;
                        x = 2 * (boardwidth - ball_radius) - x;
                        dx = -dx;
                        more = true;
                    }
                    if (y < ball_radius)
                    {
                        sy = y;
                        y = 2 * ball_radius - y;
                        dy = -dy;
                        more = true;
                    }
                    if (y > py - ball_radius)
                    {
                        if ((px - pw <= sx) && (sx <= px + pw) || (px - pw <= x) && (x <= px + pw))
                        {
                            y = 2 * (py - ball_radius) - y;
                            dy = -dy;
                            more = true;
                        }
                    }
                    sx = x;
                    sy = y;
                }
                if ((y > boardheight - ball_radius) && (dy != 0))
                {
                    dx = 0;
                    dy = 0;
                    MessageBox.Show("Game over!");
                    Glue(board.paddle);
                }
            }
            try
            {
                board.g.FillEllipse(brush, x - ball_radius, y - ball_radius, ball_radius << 1, ball_radius << 1);
            }
            catch(Exception) { }
        }
    }
}
