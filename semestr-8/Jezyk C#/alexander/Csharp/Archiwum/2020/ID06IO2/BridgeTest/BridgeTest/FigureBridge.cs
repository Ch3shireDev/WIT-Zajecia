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
        public abstract void initialise();
        public abstract void proceed(Figure fig);
        public void proceed(List<Figure> list)
        {
            foreach (Figure fig in list) proceed(fig);
        }
        public abstract void finalise();
    }
    public class FigureListboxBridge : FigureBridge
    {
        private ListBox lb;
        public FigureListboxBridge(ListBox lb)
        {
            this.lb = lb;
        }
        public override void initialise()
        {
            lb.Items.Clear();
        }
        public override void proceed(Figure fig)
        {
            lb.Items.Add(fig);
        }
        public override void finalise()
        {
            lb.SelectedIndex = lb.Items.Count - 1;
        }
    }
    public class FigurePictureboxBridge : FigureBridge
    {
        private PictureBox pb;
        private Graphics gr;
        public FigurePictureboxBridge(PictureBox pb)
        {
            this.pb = pb;
            this.gr = Graphics.FromImage(pb.Image);
        }
        public override void initialise()
        {
            gr.FillRectangle(Brushes.White, 0, 0, pb.Width, pb.Height);
        }
        public override void proceed(Figure fig)
        {
            fig.Draw(gr);
        }
        public override void finalise()
        {
            pb.Invalidate();
        }
    }
}
