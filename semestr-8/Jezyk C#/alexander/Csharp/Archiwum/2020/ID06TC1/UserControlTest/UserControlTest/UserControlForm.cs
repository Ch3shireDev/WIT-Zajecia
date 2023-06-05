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
            /*
            person.Givename = "Jan";
            person.Surname = "Kowalski";
            */
            Person person = new Person();
            PersonEdit pe = new PersonEdit();
            pe.Person = person;
            if(pe.ShowDialog()==DialogResult.OK)
            {
                PersonControl pc = new PersonControl();
                pc.Person = person;
                int H = 0;
                for (int i = PnlPersonList.Controls.Count-1; i >=0 ; --i)
                {
                    H += PnlPersonList.Controls[i].Height;
                }
                pc.Top = H + 1;
                pc.Parent = PnlPersonList;
                pc.Dock = DockStyle.Top;
            }
        }
    }
}
