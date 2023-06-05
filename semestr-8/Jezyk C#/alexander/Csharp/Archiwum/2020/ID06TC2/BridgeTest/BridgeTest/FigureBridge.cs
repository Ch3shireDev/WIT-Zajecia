using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BridgeTest
{
    public abstract class FigureBridge
    {
        protected abstract void initialize();
        protected abstract void proceed(Figure fig);
        public void proceed(List<Figure> list)
        {
            initialize();
            foreach (Figure fig in list) proceed(fig);
            finalize();
        }
        protected abstract void finalize();
    }
    public class FigurewBridgeListBox : FigureBridge
    {
        private ListBox lb;
        public FigurewBridgeListBox(ListBox lb)
        {
            this.lb = lb;
        }
        protected override void initialize()
        {
            lb.Items.Clear();
        }
        protected override void proceed(Figure fig)
        {
            lb.Items.Add(fig);
        }
        protected override void finalize()
        {
            lb.SelectedIndex = lb.Items.Count - 1;
        }
    }
    public class FigurewBridgePictureBox : FigureBridge
    {
        private PictureBox pb;
        private Graphics g;
        public FigurewBridgePictureBox(PictureBox pb)
        {
            this.pb = pb;
        }
        protected override void initialize()
        {
            pb.Image = null;
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            g = Graphics.FromImage(bmp);
            pb.Image = bmp;
        }
        protected override void proceed(Figure fig)
        {
            fig.Draw(g);
        }
        protected override void finalize()
        {
            pb.Invalidate();
        }
    }
}
