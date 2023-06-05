using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bridge
{
    public abstract class FigureBridge
    {
        public abstract void Initializer();
        public abstract void Proceed(Figure figure);
        public abstract void Finalizer();
        public void Proceed(List<Figure> list)
        {
            Initializer();
            foreach (Figure figure in list) Proceed(figure);
            Finalizer();
        }
    }

    public class FigureBrifgeList: FigureBridge
    {
        private ListBox lb;
        public FigureBrifgeList(ListBox lb) { this.lb = lb; }

        public override void Finalizer()
        {
            if(lb.Items.Count>0) lb.SelectedIndex = 0;
        }

        public override void Initializer()
        {
            lb.Items.Clear();
        }

        public override void Proceed(Figure figure)
        {
            lb.Items.Add(figure.ToString());
        }
    }

    public class FigureBrifgePicture : FigureBridge
    {
        private PictureBox pb;
        private Graphics g;
        public FigureBrifgePicture(PictureBox pb) { this.pb = pb; g = Graphics.FromImage(pb.Image); }

        public override void Finalizer()
        {
            pb.Invalidate();
        }

        public override void Initializer()
        {
            g.FillRectangle(Brushes.Bisque,0,0,pb.Width,pb.Height);
        }

        public override void Proceed(Figure figure)
        {
            figure.Draw(g);
        }
    }
}
