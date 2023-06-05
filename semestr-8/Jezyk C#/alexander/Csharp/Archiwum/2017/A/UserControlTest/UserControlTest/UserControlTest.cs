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
    public partial class UserControlTest : Form
    {
        public UserControlTest()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Person person = PersonEdit.Execute();
            if(person != null)
            {
                PersonControl row = new PersonControl();
                row.BindPerson(person);
                row.Dock = DockStyle.Top;
                row.Top = UInt16.MaxValue;
                Box.Controls.Add(row);
            }
            Box.Focus();
        }
    }
}
