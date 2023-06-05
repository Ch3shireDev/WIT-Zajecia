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
        public PersonEdit(Person person)
        {
            InitializeComponent();
            Person = person;
        }
        public Person Person
        {
            get { return personControl.Person; }
            set { personControl.Person = value; }
        }
    }
}
