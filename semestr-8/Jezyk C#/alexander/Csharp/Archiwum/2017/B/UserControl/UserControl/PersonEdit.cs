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
            Data.BindPerson(person);
        }

        public static Person Execute()
        {
            PersonEdit form = new PersonEdit();
            return (form.ShowDialog()==DialogResult.OK)?form.person:null;
        }
    }
}
