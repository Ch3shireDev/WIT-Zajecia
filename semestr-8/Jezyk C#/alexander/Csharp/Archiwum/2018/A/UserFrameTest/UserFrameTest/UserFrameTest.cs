using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFrameTestSpace
{
    public partial class UserFrameTest : Form
    {
        private BindingList<PersonFrame> lst = new BindingList<PersonFrame>();
        public UserFrameTest()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PersonEdit edit = new PersonEdit();
            edit.AnPerson = new Person();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                PersonFrame frame = new PersonFrame();
                frame.AnPerson = edit.AnPerson;
                ScrollBox.Controls.Add(frame);
                frame.Top = int.MaxValue >> 1;
                frame.Dock = DockStyle.Top;
                frame.Top = int.MaxValue >> 1;
                lst.Add(frame);
                frame.FrameClick = Frame_FrameClick;
            }
        }

        private void Frame_FrameClick(object sender, MouseEventArgs e)
        {
            PersonFrame frame = (PersonFrame)sender;
            PersonEdit edit = new PersonEdit();
            Person person = new Person();
            person.Firstname = frame.AnPerson.Firstname;
            person.Lastname = frame.AnPerson.Lastname;
            person.Face = frame.AnPerson.Face;
            edit.AnPerson = person;
            if (edit.ShowDialog() == DialogResult.OK)
            {
                frame.AnPerson = edit.AnPerson;
            }
        }
    }
}
