using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BridgeTest
{
    public class FigureBridgePicturebox : FigureBridge
    {
        private PictureBox picturebox;
        private Graphics gr;
        public FigureBridgePicturebox(PictureBox picturebox)
        {
            this.picturebox = picturebox;
        }
        protected override void initialize()
        {
            Bitmap bmp = new Bitmap(picturebox.Width, picturebox.Height);
            gr=Graphics.FromImage(bmp);
            picturebox.Image = bmp;
        }
        protected override void finalize()
        {            
        }
        protected override void proceed(Figure fig)
        {
            fig.Draw(gr);
        }
    }
}
