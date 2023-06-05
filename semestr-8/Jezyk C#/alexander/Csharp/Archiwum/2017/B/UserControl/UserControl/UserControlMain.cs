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
    public partial class UserControlMain : Form
    {
        public UserControlMain()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Person person=PersonEdit.Execute();
            if(person!=null)
            {
                PersonControl row = new PersonControl();
                row.Dock = DockStyle.Top;
                Box.Controls.Add(row);
                row.BindPerson(person);
            }
            Box.Focus();
        }
    }
}
