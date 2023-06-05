using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Arcanoid
{
    public class Board
    {
        private static Brush background = Brushes.Black;
        private PictureBox PbImage;
        private Bitmap image;
        public Graphics g { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Palette palette { get; private set; }
        public List<Ball> balls;

        public Board(PictureBox PbImage)
        {
            this.PbImage = PbImage;
            palette = new Palette(this);
            balls = new List<Ball>() { new Ball(this) };
        }

        public void Draw()
        {
            g.FillRectangle(background, 0, 0, Width, Height);
            palette.Draw();
            foreach (Ball ball in balls) ball.Draw();
            PbImage.Invalidate();
        }

        public void MouseMove(int mouseX)
        {
            palette.MouseMove(mouseX);
        }

        public void Unstick()
        {
            foreach (Ball ball in balls) ball.Unstick();
        }

        public void Resize()
        {
            Width = PbImage.Width;
            Height = PbImage.Height;
            PbImage.Image = image = new Bitmap(Width, Height);
            g = Graphics.FromImage(image);
        }
    }
}
