using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeTest
{
    public partial class BridgeTestForm : Form
    {
        private Bitmap bmp;
        private FigureList fl = new FigureList();
        private BridgeListBox blb;
        private BridgeGraphics bgr;
        public BridgeTestForm()
        {
            InitializeComponent();
            bmp = new Bitmap(1000, 1000);
            ImageBox.Image = bmp;
            foreach (var s in Figure.keys()) CbFigure.Items.Add(s);
            blb = new BridgeListBox(LstLayer);
            bgr = new BridgeGraphics(bmp);
            CbFigure.SelectedIndex = 0;
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawArc(new Pen(Color.Red, 2), 50, 50, 100, 100, 0, 357);
            g.DrawRectangle(new Pen(Color.Blue, 2), 45, 45, 110, 110);
            g.DrawLines(new Pen(Color.Green, 2), new Point[] { new Point(48,48), new Point(158, 80), new Point(80, 158), new Point(48, 48) });
            ImageBox.Invalidate();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Kind = CbFigure.SelectedItem.ToString();
            fl.Add(Figure.make(Kind, EdParams.Text));
            fl.Draw(blb);
            fl.Draw(bgr);
            ImageBox.Invalidate();
        }
    }
}
