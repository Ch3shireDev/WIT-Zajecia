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
        private BridgeListBox blb = null;
        private BridgePictureBox bpb = null;
        private List<Figure> list = new List<Figure>();
        public BridgeShowForm()
        {
            InitializeComponent();
            CbFigureKinds.Items.AddRange(Figure.Keys);
            CbFigureKinds.SelectedIndex = 0;
            blb = new BridgeListBox(LbFigures);
            PbFigures_Resize(null, null);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Figure fig = Figure.make(CbFigureKinds.SelectedItem.ToString(), TxtParameters.Text);
            list.Add(fig);
            blb.Proceed(list);
            bpb.Proceed(list);
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            PbFigures.Image = new Bitmap(PbFigures.Width, PbFigures.Height);
            bpb = new BridgePictureBox(PbFigures);
        }
    }
}
