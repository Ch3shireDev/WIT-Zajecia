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
            Person person = new Person();
            PersonEdit pe = new PersonEdit(person);
            if (pe.ShowDialog() == DialogResult.OK)
            {
                PersonControl pc = new PersonControl();
                pc.Person=pe.Person;
                pc.Dock = DockStyle.Top;
                pc.Parent = PnlList;
                pc.BringToFront();
                PnlList.ScrollControlIntoView(pc);
            }
        }
    }
}
