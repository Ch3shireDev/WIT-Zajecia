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

namespace LedMonitor
{
    public partial class LedMonitor : Form
    {
        private static readonly int DMarg = 8;
        private static readonly int SMarg = 10;
        private LedMonitorFont MyFont = new LedMonitorFont();
        private int shift = 0;
        private Panel[,] disp = new Panel[5, 40];
        private bool[,] data;
        private Color[] pal = new Color[] { Color.DarkGray, Color.Green };
        private bool stop=false;
        public LedMonitor()
        {
            InitializeComponent();
            SuspendLayout();
            for (int y = 0; y < disp.GetLength(0); ++y)
            {
                for (int x = 0; x < disp.GetLength(1); ++x)
                {
                    disp[y, x] = mkPanel(y, x);
                    setLed(y, x, false);
                    Controls.Add(disp[y, x]);
                }
            }
            ResumeLayout(true);
            ClientSize = new Size(16 * disp.GetLength(1) + 2 * DMarg, ClientSize.Height);
            ShowText_TextChanged(null, null);
            new Task(doit).Start();
        }
        private async void doit()
        {
            while(!stop)
            {
                show();
                Thread.Sleep(250);
            }
        }
        private void setLed(int y, int x, bool set)
        {
            disp[y, x].BackColor = pal[set ? 1 : 0];
        }
        private Panel mkPanel(int y, int x)
        {
            Panel tmp = new Panel();
            tmp.Location = new Point(x * 16 + DMarg, y * 16 + DMarg);
            tmp.Size = new Size(15, 15);
            //tmp.Name = "Panel_" + y + "_" + x;
            tmp.TabIndex = 0;
            return tmp;
        }
        private void show()
        {
            shift%=data.GetLength(1);
            for (int y = 0; y < disp.GetLength(0); ++y)
            {
                for (int x = 0; x < disp.GetLength(1); ++x)
                {
                    int p = (x + shift) % (data.GetLength(1));
                    setLed(y, x, data[y, p]);
                }
            }
            ++shift;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //show();
        }

        private void ShowText_TextChanged(object sender, EventArgs e)
        {
            bool[,] sp = MyFont.getData(' ');
            int spw = sp.GetLength(1), sph = sp.GetLength(0), max = SMarg * spw;
            string text = ShowText.Text;
            for (int i = 0; i < text.Length; ++i)
            {
                max += MyFont.getData(text[i]).GetLength(1) + spw;
            }
            data = new bool[sph, max];
            int p = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                bool[,] tmp = MyFont.getData(text[i]);
                int w = tmp.GetLength(1);
                for (int y = 0; y < sph; ++y)
                {
                    for (int x = 0; x < w; ++x)
                    {
                        data[y, p + x] = tmp[y, x];
                    }
                }
                p += w + spw;
            }
        }

        private void LedMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            stop = true;
        }
    }
}
