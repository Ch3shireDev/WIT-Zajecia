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
        private FigureBrifgeList fbl;
        private FigureBrifgePicture fbp;
        private List<Figure> list = new List<Figure>();
        public BridgeShowForm()
        {
            InitializeComponent();
            fbl = new FigureBrifgeList(LbFigures);
            PbFigures_Resize(null, null);
            CbFigureKinds.Items.AddRange(Figure.Kinds);
            //foreach (string kind in Figure.Kinds) CbFigureKinds.Items.Add(kind);
            CbFigureKinds.SelectedIndex = 0;
            fbl.Proceed(list);
            fbp.Proceed(list);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            list.Add(Figure.make(CbFigureKinds.SelectedItem.ToString(), TxtParameters.Text));
            fbl.Proceed(list);
            fbp.Proceed(list);
        }

        private void PbFigures_Resize(object sender, EventArgs e)
        {
            PbFigures.Image = new Bitmap(PbFigures.Width, PbFigures.Height);
            fbp = new FigureBrifgePicture(PbFigures);
        }
    }
}
