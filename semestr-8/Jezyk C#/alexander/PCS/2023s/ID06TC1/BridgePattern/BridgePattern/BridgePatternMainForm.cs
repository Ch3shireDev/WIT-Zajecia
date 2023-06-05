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
        private List<ShapeBase> shapes = new List<ShapeBase>();
        private BridgeShapeListToAll bridges;
        public BridgePatternMainForm()
        {
            InitializeComponent();
            ScRight.SplitterWidth = 12;
            CbShapeKinds.Items.AddRange(ShapeFactory.Kinds);
            CbShapeKinds.SelectedIndex = 0;
            bridges = new BridgeShapeListToAll
            (
                new BridgeShapeListToListBox(LbShapes),
                new BridgeShapeListToXml(TbXml),
                new BridgeShapeListToPictureBox(PbDraw)
            );
            runbridges(false);
        }
        private void runbridges(bool preserve)
        {
            int index = LbShapes.SelectedIndex;
            bridges.Proceed(shapes);
            if (preserve) LbShapes.SelectedIndex = index;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string kind = CbShapeKinds.SelectedItem.ToString();
            string parameters = TbParameters.Text.Trim();
            shapes.Add(ShapeFactory.make(kind, parameters));
            runbridges(false);
        }

        private void PbDraw_Resize(object sender, EventArgs e)
        {
            PbDraw.Size = ScRight.Panel1.Size;
            runbridges(true);
        }
    }
}
