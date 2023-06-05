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
    public partial class PersonEdit : Form
    {
        private Person person = new Person();
        public PersonEdit()
        {
            InitializeComponent();
            PersonBox.BindPerson(person);
        }

        public static Person Execute()
        {
            using (PersonEdit frm = new PersonEdit())
            {
                return (frm.ShowDialog() == DialogResult.OK) ? frm.person : null;
            }
        }
    }
}
