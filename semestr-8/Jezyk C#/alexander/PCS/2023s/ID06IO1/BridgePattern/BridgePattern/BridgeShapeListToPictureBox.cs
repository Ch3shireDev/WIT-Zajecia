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
        private Bitmap bitmap;
        private Graphics g;
        public BridgeShapeListToPictureBox(PictureBox field)
        {
            this.field = field;
        }

        protected override void InitialiseProcess()
        {
            bitmap = new Bitmap(field.Width, field.Height);
            g = Graphics.FromImage(bitmap);
        }

        protected override void Proceed(Shape shape)
        {
            shape.Draw(g);
        }

        protected override void FinaliseProcess()
        {
            field.Image = bitmap;
        }
    }
}
