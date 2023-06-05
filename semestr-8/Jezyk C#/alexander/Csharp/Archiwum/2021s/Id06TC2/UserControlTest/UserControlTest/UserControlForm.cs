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
            if (PersonEdit.Execute(person) == DialogResult.OK)
            {
                PersonControl pc = new PersonControl();
                pc.Bind(person,ShowReason.View);
                //PnList.Controls.Add(pc);
                pc.Parent = PnList;
                pc.Dock = DockStyle.Top;
                pc.BringToFront();
                PnList.ScrollControlIntoView(pc);
            }
        }
    }
}
