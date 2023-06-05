using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class BridgeShowForm : Form
    {
        private List<Figure> list = new List<Figure>();
        private FigureBridgeListBox FbListBox = null;
        private FigureBridgePictureBox FbPictureBox = null;
        public BridgeShowForm()
        {
            InitializeComponent();
            FbListBox = new FigureBridgeListBox(LbFigures);
            CbFigureKinds.Items.AddRange(FigureFactory.keys);
            CbFigureKinds.SelectedIndex = 0;
            PbFigures_Resize(null, null);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Figure figure = FigureFactory.make(CbFigureKinds.SelectedItem.ToString(), TxtParameters.Text);
            list.Add(figure);
            FbListBox.Procceed(list);
            FbPictureBox.Procceed(list);
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            PbFigures.Image = new Bitmap(PbFigures.Width, PbFigures.Height);
            FbPictureBox = new FigureBridgePictureBox(PbFigures);
            FbListBox.Procceed(list);
            FbPictureBox.Procceed(list);
        }
    }
}
