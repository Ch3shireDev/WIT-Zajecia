using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeTest
{
    public abstract class FigureBridge
    {
        public abstract void initialize();
        public abstract void finalize();
        public abstract void procceed(Figure figure);
        public void procceed(List<Figure> list)
        {
            initialize();
            foreach (Figure figure in list) procceed(figure);
            finalize();
        }
    }
    public class FigureBridgeListBox : FigureBridge
    {
        private ListBox listBox;
        public FigureBridgeListBox(ListBox listBox) { this.listBox = listBox; }
        public override void initialize() { listBox.Items.Clear(); }
        public override void procceed(Figure figure) { listBox.Items.Add(figure); }
        public override void finalize() { listBox.SelectedIndex = listBox.Items.Count - 1; }
    }
    public class FigureBridgePictureBox : FigureBridge
    {
        private PictureBox pictureBox;
        private Graphics g;
        public FigureBridgePictureBox(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            g = Graphics.FromImage(pictureBox.Image);
        }
        public override void initialize() { g.FillRectangle(Brushes.AntiqueWhite,0,0,pictureBox.Width,pictureBox.Height); }
        public override void procceed(Figure figure) { figure.Draw(g); }
        public override void finalize() { pictureBox.Invalidate(); }
    }
}
