using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class UserControlForm : Form
    {
        public UserControlForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            object x = BtnAdd;
            ((Form)(((Control)x).Parent.Parent)).Text = "ala ma kota";

            PersonEdit pe = new PersonEdit();
            pe.Person = new Person();
            if (pe.ShowDialog() == DialogResult.OK) 
            {
                PersonControl pc = new PersonControl(Edit_Click);
                pc.Person = pe.Person;
                pc.Dock=DockStyle.Top;
                pc.Parent = PnlPersonList;
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            PersonEdit pe = new PersonEdit();
            pe.Person = ((PersonControl)sender).Person;
            if (pe.ShowDialog() == DialogResult.OK)
            {
                PersonControl pc = new PersonControl(Edit_Click);
                pc.Person = pe.Person;
                pc.Dock = DockStyle.Top;
                pc.Parent = PnlPersonList;
            }
        }
    }
}
