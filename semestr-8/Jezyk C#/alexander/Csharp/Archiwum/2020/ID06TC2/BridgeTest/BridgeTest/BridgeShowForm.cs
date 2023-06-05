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
        private FigurewBridgeListBox lbbridge;
        private FigurewBridgePictureBox pbbridge;
        public BridgeShowForm()
        {
            InitializeComponent();
            lbbridge = new FigurewBridgeListBox(LbFigures);
            pbbridge = new FigurewBridgePictureBox(PbFigures);
            foreach (string kind in FigureFabric.Keys) CbFigureKinds.Items.Add(kind);
            CbFigureKinds.SelectedIndex = 2;
            EdParameters.Text = "200 200 100 400 300 400";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string kind = CbFigureKinds.SelectedItem.ToString();
            string parameters = EdParameters.Text;
            Figure fig = FigureFabric.Make(kind, parameters);
            list.Add(fig);
            lbbridge.proceed(list);
            pbbridge.proceed(list);
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            //pbbridge.proceed(list);
        }

        private void PnlClient_Resize(object sender, EventArgs e)
        {
            //PbFigures.Dock = DockStyle.None;
            //PbFigures.Dock = DockStyle.Fill;
            pbbridge.proceed(list);
        }
    }
}
