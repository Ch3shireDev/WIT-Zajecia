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
        protected abstract void Initialization();
        protected abstract void Finalization();
        protected abstract void Procceed(Figure figure);
        public void Procceed(List<Figure> list)
        {
            Initialization();
            foreach(Figure figure in list) Procceed(figure);
            Finalization();
        }
    }
    public class FigureBridgeListBox: FigureBridge
    {
        private ListBox lb;
        public FigureBridgeListBox(ListBox lb) { this.lb = lb; }
        protected override void Initialization() { lb.Items.Clear(); }
        protected override void Finalization() { lb.SelectedIndex = lb.Items.Count - 1; }
        protected override void Procceed(Figure figure) { lb.Items.Add(figure); }
    }
    public class FigureBridgePictureBox : FigureBridge
    {
        private PictureBox pb;
        private Graphics g;
        public FigureBridgePictureBox(PictureBox pb)
        {
            this.pb = pb;
            g = Graphics.FromImage(pb.Image);
        }
        protected override void Initialization() { g.FillRectangle(Brushes.AntiqueWhite,0,0,pb.Width,pb.Height); }
        protected override void Finalization() { pb.Invalidate(); }
        protected override void Procceed(Figure figure) { figure.Draw(g); }
    }
}
