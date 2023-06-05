using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePatern
{
    class BridgeShapeListToPictureBox : BridgeShapeList
    {
        private PictureBox field;
        private Graphics g;
        public BridgeShapeListToPictureBox(PictureBox field)
        {
            this.field = field;
        }
        public override void InitialiseProcess()
        {
            Bitmap bmp = new Bitmap(field.Width, field.Height);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.Bisque, 0, 0, bmp.Width, bmp.Height);
            field.Image = bmp;
        }

        public override void Proceed(Shape shape)
        {
            shape.Draw(g);
        }

        public override void FinaliseProcess()
        {
            field.Invalidate();
        }
    }
}