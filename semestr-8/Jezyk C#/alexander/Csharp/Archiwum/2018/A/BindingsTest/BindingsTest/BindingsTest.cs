using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingsTest
{
    public partial class BindingsTest : Form
    {
        private BindingList<Person> persons = new BindingList<Person>();
        public BindingsTest()
        {
            InitializeComponent();
            PersonList.DataSource = persons;
            persons.ListChanged += Persons_ListChanged;
        }

        private void Persons_ListChanged(object sender, ListChangedEventArgs e)
        {
            bool enabled = (persons.Count > 0);
            EdFirstname.Enabled = enabled;
            EdLastname.Enabled = enabled;
        }

        private void BindData(Person p)
        {
            EdFirstname.DataBindings.Clear();
            EdLastname.DataBindings.Clear();
            if (p != null)
            {
                EdFirstname.DataBindings.Add("Text", p, "firstname", false, DataSourceUpdateMode.OnPropertyChanged);
                EdLastname.DataBindings.Add("Text", p, "lastname", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PersonList.SelectedIndex = -1;
            Person p = new Person("Piotr", "Kowalski");
            persons.Add(p);
            PersonList.SelectedIndex = PersonList.Items.IndexOf(p);
            EdFirstname.Focus();
            EdFirstname.SelectAll();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int pos = PersonList.SelectedIndex;
            Person p = (Person)PersonList.SelectedValue;
            persons.Remove(p);
            PersonList.SelectedIndex = Math.Min(pos,PersonList.Items.Count - 1);
            if(PersonList.SelectedIndex<0)
            {
                EdFirstname.Clear();
                EdLastname.Clear();
            }
            PersonList.Focus();
        }

        private void PersonList_SelectedValueChanged(object sender, EventArgs e)
        {
            Person p = (Person)PersonList.SelectedValue;
            BindData(p);
        }

        private void BindingsTest_Load(object sender, EventArgs e)
        {
            BtnAdd.PerformClick();
        }
    }
}
