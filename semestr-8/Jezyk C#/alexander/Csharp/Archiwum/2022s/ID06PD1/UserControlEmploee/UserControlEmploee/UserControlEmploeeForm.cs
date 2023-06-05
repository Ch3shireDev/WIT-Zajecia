using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlEmploee
{
    public partial class UserControlEmploeeForm : Form
    {
        public UserControlEmploeeForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EmploeeControl control = new EmploeeControl(new Employee());
            control.Dock = DockStyle.Top;
            control.Height = 80;
            control.Parent = PnList;
        }
    }
}
