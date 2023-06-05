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
    public partial class AracanoidMain : Form
    {
        private Random rnd = new Random();
        private Bitmap bmp;
        private Graphics g;
        private Brush pBrush = new SolidBrush(Color.Green);
        private Brush bBrush = new SolidBrush(Color.Navy);
        private float px, py, pvx = 0;
        private float bx, by, bvx = 0, bvy = 0;
        private int bmpwidth, bmpheight;
        private bool glue = true, runing = false;
        private static float pw = 100, ph = 25, ps = 50;
        private static float br = 8;
        private static float pww = pw + pw, brr = br + br;

        public AracanoidMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private float beetwen(float lf,float value,float rt)
        {
            return Math.Min(Math.Max(lf, value), rt);
        }
        private void glueBall()
        {
            bx = px;
            by = py - br;
        }
        private void redraw()
        {
            g.Clear(SystemColors.Control);
            g.FillRectangle(pBrush, new RectangleF(px - pw, py, pww, ph));
            g.FillEllipse(bBrush, new RectangleF(bx - br, by - br, brr, brr));
            Box.Invalidate();
        }
        private void AracanoidMain_Resize(object sender, EventArgs e)
        {
            bmpwidth = Box.Width;
            bmpheight = Box.Height;
            bmp = new Bitmap(bmpwidth, bmpheight);
            Box.Image = bmp;
            g = Graphics.FromImage(bmp);
            py = Box.Height - ps;
            px = Box.Width >> 1;
            glueBall();
            bw.RunWorkerAsync();
        }
        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            pvx = beetwen(-50f, e.X - px, +50F);
        }
        private void Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (glue)
            {
                glue = false;
                bvy = -30;
                bvx = (float)(rnd.NextDouble() - 0.5) * 5;
            }
        }
        private void AracanoidMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            runing = false;
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            runing = true;
            while (runing)
            {
                Thread.Sleep(50);
                px = beetwen(pw, px + pvx, bmpwidth - pw);
                if (glue) glueBall();
                else
                {
                    bx += bvx;
                    by += bvy;
                    bool more = true;
                    while (more)
                    {
                        float sx = bx, sy = by;
                        more = false;
                        if (bx < br)
                        {
                            sx = bx;
                            bx = 2 * br - bx;
                            bvx = -bvx;
                            more = true;
                        }
                        if (bx > bmpwidth - br)
                        {
                            sx = bx;
                            bx = 2 * (bmpwidth - br) - bx;
                            bvx = -bvx;
                            more = true;
                        }
                        if (by < br)
                        {
                            sy = by;
                            by = 2 * br - by;
                            bvy = -bvy;
                            more = true;
                        }
                        if (by > py - br)
                        {
                            //float strike = sx + (py - br - sy) * (bx - sx) / (by - sy);
                            //if ((px - pw <= strike) && (strike <= px + pw))
                            if ((px - pw <= sx) && (sx <= px + pw) || (px - pw <= bx) && (bx <= px + pw))
                            {
                                by = 2 * (py - br) - by;
                                bvy = -bvy;
                                more = true;
                            }
                        }
                    }
                    if (by > bmpheight - br)
                    {
                        MessageBox.Show("Game over!");
                        glue = true;
                        glueBall();
                    }
                }
                redraw();
            }
        }
    }
}
