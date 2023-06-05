using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test023
{
    public partial class Snake : Form
    {
        public static readonly int Y = 32, X = 64, W = 16, XY = X * Y, MaxBonus = 3;
        public static Random rnd = new Random();
        public int[,] tb = new int[XY, 2];
        public int[,] bonus = new int[MaxBonus, 2];
        public Keys move;
        public int head, tail, grow, score;
        public Snake()
        {
            InitializeComponent();
            ClientSize = new Size(X * W, Y * W + Status.Height);
            GameStart();
        }

        private int GetBonus(int y, int x)
        {
            for (int i = 0; i < MaxBonus; ++i)
            {
                if ((bonus[i, 0] == x) && (bonus[i, 1] == y)) return i;
            }
            return MaxBonus;
        }


        private bool ColisionBonus(int y, int x)
        {
            return GetBonus(y, x) < MaxBonus;
        }

        private bool ColisionSnake(int y, int x)
        {
            int endi = (head + 1) % XY;
            for (int i = tail; i != endi; i = (i + 1) % XY)
            {
                if ((tb[i, 0] == x) && (tb[i, 1] == y)) return true;
            }
            return false;
        }

        private bool ColisionWall(int y, int x)
        {
            return (y <= 0) || (x <= 0) || (y >= Y - 1) || (x >= X - 1);
        }

        private void RandBonus(int pos)
        {
            bonus[pos, 0] = 0;
            bonus[pos, 1] = 0;
            int y, x;
            while(true)
            {
                x = rnd.Next(1, X - 1);
                y = rnd.Next(1, Y - 1);
                if ((!ColisionBonus(y, x)) && (!ColisionSnake(y, x))) break;
            }
            bonus[pos, 0] = x;
            bonus[pos, 1] = y;
        }

        private void GameStart()
        {
            move = Keys.Left;
            head = tail = grow = score = 0;
            tb[0, 0] = X >> 1;
            tb[0, 1] = Y >> 1;
            for (int i = 0; i < MaxBonus; ++i) RandBonus(i);
            Score.Text = "0";
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (move == Keys.Right) return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (move == Keys.Down) return;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (move == Keys.Left) return;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (move == Keys.Up) return;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!Tick.Enabled)
                {
                    GameStart();
                    Invalidate();
                    Tick.Enabled = true;
                }
                return;
            }
            else return;
            move = e.KeyCode;
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,0,0,X*W,Y*W);
            for (int y = 0; y < Y; ++y) e.Graphics.FillEllipse(Brushes.Black, 0 * W, y * W, W, W);
            for (int y = 0; y < Y; ++y) e.Graphics.FillEllipse(Brushes.Black, (X-1) * W, y * W, W, W);
            for (int x = 0; x < X; ++x) e.Graphics.FillEllipse(Brushes.Black, x * W, 0 * W, W, W);
            for (int x = 0; x < X; ++x) e.Graphics.FillEllipse(Brushes.Black, x * W, (Y-1) * W, W, W);
            int endi = (head + 1) % XY;
            for (int i = tail; i != endi; i = (i + 1) % XY)
            {
                int x = tb[i, 0], y = tb[i, 1];
                e.Graphics.FillEllipse(Brushes.Green, x * W, y * W, W, W);
            }
            for (int i = 0; i < MaxBonus; ++i)
            {
                int x = bonus[i, 0], y = bonus[i, 1];
                e.Graphics.FillEllipse(Brushes.Red, x * W, y * W, W, W);
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            int x = tb[head, 0], y = tb[head, 1];
            if (move == Keys.Left) --x;
            else if (move == Keys.Up) --y;
            else if (move == Keys.Right) ++x;
            else if (move == Keys.Down) ++y;
            if (ColisionWall(y, x) || ColisionSnake(y, x))
            {
                Tick.Enabled = false;
                Invalidate();
                return;
            }
            head = (head + 1) % XY;
            tb[head, 0] = x;
            tb[head, 1] = y;
            int b = GetBonus(y, x);
            if (b < MaxBonus)
            {
                grow += rnd.Next(1, 5);
                RandBonus(b);
            }
            if (grow > 0)
            {
                --grow;
                Score.Text = (score += 5).ToString();
            }
            else tail = (tail + 1) % XY;
            Invalidate();
        }
    }
}
