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
        private FigureBridge[] bridges;
        private List<Figure> figures = new List<Figure>();
        public BridgeShowForm()
        {
            InitializeComponent();
            foreach (string kind in FigureFabric.keys) CbFigureKinds.Items.Add(kind);
            PbFigures_Resize(null, null);
            bridges = new FigureBridge[]
            {
                new FigureListboxBridge(LbFigures),
                new FigurePictureboxBridge(PbFigures),
            };
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Figure fig = FigureFabric.make(CbFigureKinds.SelectedItem.ToString(), EdParameters.Text);
            figures.Add(fig);
            Refresh();
        }

        private void Refresh()
        {
            foreach (FigureBridge bridge in bridges)
            {
                bridge.initialise();
                bridge.proceed(figures);
                bridge.finalise();
            }
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            PbFigures.Image = new Bitmap(PbFigures.Width, PbFigures.Height);
            Refresh();
        }
    }
}
