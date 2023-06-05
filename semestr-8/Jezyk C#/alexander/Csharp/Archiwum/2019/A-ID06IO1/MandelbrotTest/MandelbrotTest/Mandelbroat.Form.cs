using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MandelbrotTest
{
    delegate void PaintPartProc(Bitmap curr);
    delegate void CalculateProc(PaintPartProc proc);
    public partial class MandelbrotForm : Form
    {
        private static Color[] GoodBg = new Color[] { Color.FromArgb(255,222,222), SystemColors.Window };
        private MandelbrotKeeper keeper;
        private SortedDictionary<string, CalculateProc> HowProc = new SortedDictionary<string, CalculateProc>();
        private string How;
        private double DownRe, DownIm;
        private int DownX, DownY;
		private bool Down, Drag;
        private System.Threading.Timer tm;
        public MandelbrotForm()
        {
            InitializeComponent();
            keeper = new MandelbrotKeeper(1, -2, 1, Box.Width, Box.Height);
            HowProc.Add("One", keeper.OneThreadBitmap);
            HowProc.Add("Multi", keeper.MultiThreadBitmap);
            HowProc.Add("Pool", keeper.ThreadPoolBitmap);
            tm = new System.Threading.Timer(NeedRecalc);
            SetValues(-2, 1, 1);
            CbUse.Items.AddRange(HowProc.Keys.ToArray());
            CbUse.SelectedItem = How = HowProc.Keys.First();
        }
        private string ValToStr(double val)
        {
            string ret = string.Format("{0:F18}", val);
            int pos = ret.Length;
            for (; (pos > 1) && (ret[pos - 1] == '0'); --pos) { }
            if ((pos > 1) && (ret[pos - 1] == ',')) --pos;
            return ret.Substring(0, pos);
        }
        private void SetValues(double Re, double Im, double Zoom)
        {
            EdRe.Text = ValToStr(Re);
            EdIm.Text = ValToStr(Im);
            EdZoom.Text = ValToStr(Zoom);
        }
        private void NeedRecalc(object state) { new Thread(ThreadRecalc).Start(); }
        private void Recalc() { tm.Change(300, Timeout.Infinite); }
        private void PaintPart(Bitmap curr)
        {
            if ((Box.Width == curr.Width) && (Box.Height == curr.Height))
            {
                Box.Image = curr;
                Box.Invalidate();
            }
        }
        private void PaintPartInvoke(Bitmap curr)
        {
            Invoke(new PaintPartProc(PaintPart), new object[] { curr });
        }

        private void CbUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            How = CbUse.SelectedItem.ToString();
            Recalc();
        }

        private void ThreadRecalc()
		{
            HowProc[How](PaintPartInvoke);
        }
        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
			Drag = false;
			Down = true;
            DownRe = keeper.StartRe;
            DownIm = keeper.StartIm;
            DownX = e.X;
            DownY = e.Y;
        }
        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
			Down = false;
			if(!Drag)
			{
                double Im = keeper.DeltaIm(e.Y);
				double Re = keeper.DeltaRe(e.X);
                if (e.Button == MouseButtons.Left) keeper.Zoom /= 2;
                else if (e.Button == MouseButtons.Right) keeper.Zoom *= 2;
                Im -= keeper.DeltaIm(keeper.Height >> 1);
                Re -= keeper.DeltaRe(keeper.Width >> 1);
                SetValues(keeper.StartRe + Re, keeper.StartIm + Im, keeper.Zoom);
            }
        }
        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
			if(Down)
			{
				Drag = true;
                double Re = keeper.DeltaRe(e.X - DownX);
                double Im = keeper.DeltaIm(e.Y - DownY);
                SetValues(DownRe - Re, DownIm - Im, keeper.Zoom);
            }
        }
        private void EdValues_TextChanged(object sender, EventArgs e)
        {
            double StartIm, StartRe, Zoom;
            bool goodIm = double.TryParse(EdIm.Text, out StartIm);
            bool goodRe = double.TryParse(EdRe.Text, out StartRe);
            bool goodZoom = double.TryParse(EdZoom.Text, out Zoom);
            EdIm.BackColor = GoodBg[goodIm ? 1 : 0];
            EdRe.BackColor = GoodBg[goodRe ? 1 : 0];
            EdZoom.BackColor = GoodBg[goodZoom ? 1 : 0];
            if (goodIm && goodRe && goodZoom)
            {
                keeper.StartIm = StartIm;
                keeper.StartRe = StartRe;
                keeper.Zoom = Zoom;
                Recalc();
            }
        }
        private void Box_Resize(object sender, EventArgs e)
        {
            Recalc();
        }
    }
}
