using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test016
{
    public partial class Form1 : Form
    {
        public enum Color { Red=2, Blue=7, Green=5 };
        public Dictionary<int, string> tb = new Dictionary<int, string>();
        public Student ktos;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Color));
            tb[8] = "Adam";
            tb[12] = "Piotr";
            tb[5] = "Krzysztof";
            comboBox2.ValueMember = "Key";
            comboBox2.DisplayMember = "Value";
            comboBox2.DataSource = new BindingSource(tb, null);
            ktos = new Student("Jan", "Kowalski");
            textBox1.DataBindings.Add("Text", ktos, "FirstName");
            textBox2.DataBindings.Add("Text", ktos, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox2.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ktos.FirstName + " " + ktos.LastName);
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
