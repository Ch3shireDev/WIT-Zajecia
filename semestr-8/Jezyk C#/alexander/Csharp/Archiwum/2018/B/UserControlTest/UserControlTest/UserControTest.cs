using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTestNamespace
{
    public partial class UserControlTest : Form
    {
        public UserControlTest()
        {
            InitializeComponent();
        }

        private void Frame_DoubleClick(object sender, EventArgs e)
        {
            PersonFrame frame = (PersonFrame)sender;
            Person person = frame.AnPerson;
            Person copy = new Person();
            copy.Face = person.Face;
            copy.Firstname = person.Firstname;
            copy.Lastname = person.Lastname;
            if (new PersonEdit(copy).ShowDialog() == DialogResult.OK)
            {
                person.Face = copy.Face;
                person.Firstname = copy.Firstname;
                person.Lastname = copy.Lastname;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if(new PersonEdit(person).ShowDialog()==DialogResult.OK)
            {
                PersonFrame frm = new PersonFrame();
                frm.AnPerson = person;
                frm.FrameDoubleClick += Frame_DoubleClick;
                frm.Dock = DockStyle.Top;
                frm.Top = frm.Height * Box.Controls.Count;
                Box.Controls.Add(frm);
            }
        }
    }
}
