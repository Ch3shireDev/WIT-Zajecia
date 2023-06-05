using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingTest
{
    public partial class BindingTest : Form
    {
        private Person p;
        private BindingList<Person> list = new BindingList<Person>();
        public BindingTest()
        {
            InitializeComponent();
            ListBox.DataSource = list;
            p = new Person("Kowalski", "Jan");
            EdFirstnameA.DataBindings.Add("Text", p, "firstname", false, DataSourceUpdateMode.OnPropertyChanged);
            EdFirstnameB.DataBindings.Add("Text", p, "firstname", false, DataSourceUpdateMode.OnPropertyChanged);
            EdLastnameA.DataBindings.Add("Text", p, "lastname", false, DataSourceUpdateMode.OnPropertyChanged);
            EdLastnameB.DataBindings.Add("Text", p, "lastname", false, DataSourceUpdateMode.OnPropertyChanged);
            list.Add(p);
        }
    }
}
