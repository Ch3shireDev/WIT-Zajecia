using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabric
{
    public partial class FabricTestForm : Form
    {
        public FabricTestForm()
        {
            InitializeComponent();
            foreach(string kind in Animal.kinds()) CbKinds.Items.Add(kind);
            CbKinds.SelectedIndex=0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Animal animal=Animal.make(CbKinds.SelectedItem.ToString(),TxtName.Text);
            TxtLog.AppendText(animal.ToString()+Environment.NewLine);
        }
    }
}
