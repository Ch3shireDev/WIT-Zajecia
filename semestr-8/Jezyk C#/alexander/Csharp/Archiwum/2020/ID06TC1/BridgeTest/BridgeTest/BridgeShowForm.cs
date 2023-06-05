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
        private FigureBridge picturebridge;
        private FigureBridge[] bridges;
        public BridgeShowForm()
        {
            InitializeComponent();
            foreach (string kind in FigureFabric.Kinds) CbFigureKinds.Items.Add(kind);
            picturebridge = new FigureBridgePicturebox(PbFigures);
            bridges = new FigureBridge[]
            {
                picturebridge,
                new FigureBridgeListbox(LbFigures),
            };
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Figure fig=FigureFabric.make(CbFigureKinds.SelectedItem.ToString(),EdParameters.Text);
            list.Add(fig);
            foreach (FigureBridge br in bridges) br.proceed(list);
        }

        private void PnlClient_Resize(object sender, EventArgs e)
        {
            picturebridge.proceed(list);
        }
    }
}
