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
    public partial class BridgeShowForm : Form
    {
        private List<Figure> list = new List<Figure>();
        private List<FigureBridge> bridges = new List<FigureBridge>();
        public BridgeShowForm()
        {
            InitializeComponent();
            CbFigureKinds.Items.AddRange(Figure.Kinds);
            CbFigureKinds.SelectedIndex = 0;
            PbFigures_Resize(null, null);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            list.Add(Figure.make(CbFigureKinds.SelectedItem.ToString(), TxtParameters.Text));
            CallBriges();
        }

        private void CallBriges()
        {
            foreach (FigureBridge bridge in bridges) bridge.procceed(list);
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            PbFigures.Dock = DockStyle.None;
            //PbFigures.Left = PbFigures.Top = 0;
            //PbFigures.Width = PnFigures.Width;
            //PbFigures.Height = PnFigures.Height;
            PbFigures.Dock = DockStyle.Fill;
            PbFigures.Image = new Bitmap(PbFigures.Width, PbFigures.Height);
            bridges.Clear();
            bridges.Add(new FigureBridgeListBox(LbFigures));
            bridges.Add(new FigureBridgePictureBox(PbFigures));
            CallBriges();
        }
    }
}
