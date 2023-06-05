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
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
            foreach (string kind in Animal.keys()) cbKind.Items.Add(kind);
            cbKind.SelectedIndex=0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string kind=cbKind.SelectedItem.ToString();
            string name=txtName.Text;
            Animal animal=Animal.make(kind,name);
            txtLog.AppendText(animal.ToString()+Environment.NewLine);
        }
    }
}
