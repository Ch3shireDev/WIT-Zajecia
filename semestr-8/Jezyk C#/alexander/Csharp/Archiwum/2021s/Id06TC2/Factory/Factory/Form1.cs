using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach(string kind in AnimalFactory.keys())
            {
                cbKind.Items.Add(kind);
            }
            cbKind.SelectedIndex=0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMake_Click(object sender, EventArgs e)
        {
            string Kind=cbKind.SelectedItem.ToString();
            string Name=txtName.Text;
            Animal animal = AnimalFactory.make(Kind, Name);
            txtLog.AppendText(animal.ToString()+Environment.NewLine);
        }
    }
}
