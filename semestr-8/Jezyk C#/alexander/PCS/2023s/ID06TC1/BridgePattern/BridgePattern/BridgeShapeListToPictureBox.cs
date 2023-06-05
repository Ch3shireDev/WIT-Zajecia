using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    class BridgeShapeListToPictureBox : BridgeShapeList
    {
        private PictureBox field;
        private Graphics g;
        public BridgeShapeListToPictureBox(PictureBox field)
        {
            this.field = field;
        }

        protected override void InitialiseProcess()
        {
            Bitmap bmp = new Bitmap(field.Width, field.Height);
            field.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.BlanchedAlmond, 0, 0, bmp.Width, bmp.Height);
        }

        protected override void Proceed(ShapeBase shape)
        {
            shape.Draw(g);
        }

        protected override void FinaliseProcess()
        {
            field.Invalidate();
        }
    }
}
