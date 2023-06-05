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
        public void Draw(List<Figure> lst)
        {
            Init();
            foreach (Figure fig in lst) Draw(fig);
            Done(lst.Last());
        }
        public abstract void Init();
        public abstract void Draw(Figure fig);
        public abstract void Done(Figure fig);
    }
    class BridgeGraphics : Bridge
    {
        private Graphics gr;
        public BridgeGraphics(Bitmap bmp) { this.gr = Graphics.FromImage(bmp); }
        public override void Init()
        {
            gr.Clear(Color.White);
        }
        public override void Draw(Figure fig)
        {
            if(fig is Circle)
            {
                Circle obj = fig as Circle;
                gr.DrawEllipse(new Pen(Color.Red), obj.TpLf.X, obj.TpLf.Y, obj.BtRt.X - obj.TpLf.X, obj.BtRt.Y - obj.TpLf.Y);
            }
            else if (fig is Rectangle)
            {
                Rectangle obj = fig as Rectangle;
                gr.DrawRectangle(new Pen(Color.Blue), obj.TpLf.X, obj.TpLf.Y, obj.BtRt.X - obj.TpLf.X, obj.BtRt.Y - obj.TpLf.Y);
            }
            else if (fig is Triangle)
            {
                Triangle obj = fig as Triangle;
                gr.DrawLines(new Pen(Color.Green), new Point[] { obj.A, obj.B, obj.C, obj.A });
            }
        }
        public override void Done(Figure fig)
        {
        }
    }
    class BridgeListBox : Bridge
    {
        private ListBox lb;
        public BridgeListBox(ListBox lb) { this.lb = lb; }
        public override void Init()
        {
            lb.Items.Clear();
        }
        public override void Draw(Figure fig)
        {
            lb.Items.Add(fig);
        }
        public override void Done(Figure fig)
        {
            lb.SelectedItem = fig;
        }
    }
}
