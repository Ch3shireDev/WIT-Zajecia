using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePatern
{
    public partial class BridgePaternMainForm : Form
    {
        private List<Shape> shapes=new List<Shape>();
        private BridgeShapeListToAll bridges = null;
        public BridgePaternMainForm()
        {
            InitializeComponent();
            CbShapeKinds.Items.Clear();
            CbShapeKinds.Items.AddRange(ShapeFactory.Kinds);
            CbShapeKinds.SelectedIndex = 0;
            ScRight.SplitterWidth = 12;
            bridges = new BridgeShapeListToAll
            (
                new BridgeShapeListToXml(TbXml),
                new BridgeShapeListToListBox(LbShapes),
                new BridgeShapeListToPictureBox(PbImage)
            );
            BridgeAll(false);
        }

        private void BridgeAll(bool preserve)
        {
            if (bridges == null) return;
            int index = LbShapes.SelectedIndex;
            bridges.Proceed(shapes);
            if (preserve) LbShapes.SelectedIndex = index;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            shapes.Add(ShapeFactory.make(CbShapeKinds.SelectedItem.ToString(), TbParameters.Text.Trim()));
            BridgeAll(false);
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PbImage.Size = ScRight.Panel1.ClientSize;
            BridgeAll(true);
        }
    }
}
