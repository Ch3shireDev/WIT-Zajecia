using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BridgeTest
{
    public abstract class Bridge
    {
        public abstract void initialise();
        public abstract void finalise();
        public abstract void Proceed(Figure fig);
        public void Proceed(List<Figure> list)
        {
            initialise();
            foreach (Figure fig in list) Proceed(fig);
            finalise();
        }
    }
    public class BridgeListBox: Bridge
    {
        private ListBox lb;
        public BridgeListBox(ListBox lb) { this.lb = lb; }

        public override void finalise()
        {
            lb.SelectedIndex = lb.Items.Count - 1;
        }

        public override void initialise()
        {
            lb.Items.Clear();
        }

        public override void Proceed(Figure fig)
        {
            lb.Items.Add(fig);
        }
    }
    public class BridgePictureBox : Bridge
    {
        private PictureBox pb;
        private Graphics g;
        public BridgePictureBox(PictureBox lb)
        {
            this.pb = lb;
            g = Graphics.FromImage(pb.Image);
        }

        public override void finalise()
        {
            pb.Invalidate();
        }

        public override void initialise()
        {
            g.FillRectangle(Brushes.AntiqueWhite, 0, 0, pb.Width, pb.Height);
        }

        public override void Proceed(Figure fig)
        {
            fig.Draw(g);
        }
    }
}
