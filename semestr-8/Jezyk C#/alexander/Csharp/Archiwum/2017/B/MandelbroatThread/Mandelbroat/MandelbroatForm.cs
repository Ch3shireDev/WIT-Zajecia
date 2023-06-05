using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbroat
{
    public partial class MandelbroatForm : Form
    {
        private double Lf, Tp, Zoom;
        private int graphicsWidth, graphicsHeight;
        private Graphics graphics;
        private BindingList<Server> servers = new BindingList<Server>();
        private ServerListForm serversForm = null;
        public MandelbroatForm()
        {
            InitializeComponent();
            MandelbroatForm_Resize(null, null);
        }
        private void EdData_TextChanged(object sender, EventArgs e)
        {
            if
            (
                double.TryParse(EdLf.Text.Trim(), out Lf) &&
                double.TryParse(EdTp.Text.Trim(), out Tp) &&
                double.TryParse(EdZoom.Text.Trim(), out Zoom) 
            )
            {
                RecalcImage(Lf, Tp, Zoom);
            }
        }

        private void MandelbroatForm_Resize(object sender, EventArgs e)
        {
            lock(Box)
            {
                graphicsWidth = Box.Width;
                graphicsHeight = Box.Height;
                Bitmap bmp = new Bitmap(graphicsWidth, graphicsHeight);
                Box.Image = bmp;
                graphics = Graphics.FromImage(bmp);
            }
            EdData_TextChanged(null, null);
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int sy = Box.Height >> 1, sx = Box.Width >> 1;
            double mul = MulZoom(Zoom);
            double Pi = MandelbroadEncode.encodeY(Tp, e.Y, mul);
            double Pr = MandelbroadEncode.encodeX(Lf, e.X, mul);
            if (e.Button == MouseButtons.Left) Zoom *= 2;
            else if (e.Button == MouseButtons.Right) Zoom /= 2;
            else return;
            mul = MulZoom(Zoom);
            EdZoom.Text = string.Format("{0:F4}", Zoom);
            EdTp.Text = string.Format("{0:F14}", MandelbroadEncode.decodeY(Pi, sy, mul));
            EdLf.Text = string.Format("{0:F14}", MandelbroadEncode.decodeX(Pr, sx, mul));
        }
        private void ServerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serversForm = null;
        }
        private void BtnServers_Click(object sender, EventArgs e)
        {
            if (serversForm == null)
            {
                serversForm=new ServerListForm(servers);
                serversForm.FormClosed += ServerListForm_FormClosed;
                serversForm.Show();
            }
            else
            {
                if (serversForm.WindowState == FormWindowState.Minimized)
                {
                    serversForm.WindowState = FormWindowState.Normal;
                }
                serversForm.Activate();
            }
        }

        private double MulZoom(double Zoom)
        {
            return 3 / (graphicsWidth * Zoom);
        }
        private void draw(int x, int y, Bitmap bmp)
        {
            lock(graphics)
            {
                graphics.DrawImage(bmp, x, y);
            }
            Box.Invalidate();
        }
        private void RecalcImage(double Lf, double Tp, double Zoom)
        {
            double mul = MulZoom(Zoom);
            for (int y = 0; y < graphicsHeight; y += MandelbroatThread.size)
            {
                double Pi = MandelbroadEncode.encodeY(Tp, y, mul);
                for (int x = 0; x < graphicsWidth; x += MandelbroatThread.size)
                {
                    double Pr = MandelbroadEncode.encodeX(Lf, x, mul);
                    new MandelbroatThread(Pr, Pi, mul, x, y, draw);
                }
            }
        }
    }
}
