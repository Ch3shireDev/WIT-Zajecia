using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BridgeTest
{
    abstract class Bridge
    {
        protected abstract void Init();
        protected abstract void Draw(Figure fig);
        protected abstract void Done();
        public void Draw(IEnumerable<Figure> list)
        {
            Init();
            foreach (Figure fig in list) Draw(fig);
            Done();
        }
    }
    class BridgeImage : Bridge
    {
        private PictureBox box;
        private Graphics gr;
        public BridgeImage(PictureBox box)
        {
            this.box = box;
            gr = Graphics.FromImage(box.Image);
        }
        protected override void Init()
        {
            gr.Clear(SystemColors.Control);
        }
        protected override void Draw(Figure fig)
        {
            (fig as FigCircle)?.Draw(gr);
            (fig as FigRectangle)?.Draw(gr);
            (fig as FigTriangle)?.Draw(gr);
        }
        protected override void Done()
        {
            box.Invalidate();
        }
    }
    class BridgeList : Bridge
    {
        private ListBox box;
        public BridgeList(ListBox box) { this.box = box; }
        protected override void Init()
        {
            box.Items.Clear();
        }
        protected override void Draw(Figure fig)
        {
            box.Items.Add(fig);
        }
        protected override void Done()
        {
            int size = box.Items.Count;
            if (size > 0) box.SelectedItem = box.Items[size - 1];
        }
    }
}