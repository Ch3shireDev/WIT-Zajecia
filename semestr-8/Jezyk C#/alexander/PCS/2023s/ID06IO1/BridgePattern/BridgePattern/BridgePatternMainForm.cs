using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public partial class BridgePatternMainForm : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private BridgeShapeList bridges = null;
        public BridgePatternMainForm()
        {
            InitializeComponent();
            CbShapeKinds.Items.Clear();
            CbShapeKinds.Items.AddRange(ShapeFactory.Kinds);
            CbShapeKinds.SelectedIndex = 0;
            bridges = new BridgeShapeListToAll
            (
                new BridgeShapeListToXml(TbXml),
                new BridgeShapeListToListBox(LbShapes),
                new BridgeShapeListToPictureBox(PbImage)
            );
            bridges.Proceed(shapes);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            shapes.Add(ShapeFactory.make(CbShapeKinds.SelectedItem.ToString(),TbParameters.Text.Trim()));
            bridges.Proceed(shapes);
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            bridges?.Proceed(shapes);
        }
    }
}
