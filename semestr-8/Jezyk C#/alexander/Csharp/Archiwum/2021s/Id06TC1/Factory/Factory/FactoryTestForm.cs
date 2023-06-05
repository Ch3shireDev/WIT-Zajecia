using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class FactoryTestForm : Form
    {
        public FactoryTestForm()
        {
            InitializeComponent();
            foreach(string kind in Animal.kinds) cbKinds.Items.Add(kind);
            cbKinds.SelectedIndex=0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Animal animal=Animal.make(cbKinds.SelectedItem.ToString(),txtName.Text);
            txtLog.AppendText(animal.ToString()+Environment.NewLine);
        }
    }
}
