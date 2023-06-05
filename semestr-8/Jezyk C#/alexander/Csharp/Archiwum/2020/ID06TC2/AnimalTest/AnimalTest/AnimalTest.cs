using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalTestNamespace
{
    public partial class AnimalTest : Form
    {
        public AnimalTest()
        {
            InitializeComponent();
            //for(int i=0; i<AnimalFactory.keys().Length; ++i) CbNames.Items.Add(AnimalFactory.keys()[i]);
            foreach (string kind in AnimalFactory.keys()) CbNames.Items.Add(kind);
            CbNames.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            Animal p = new Cat("Puszek");
            EdLog.AppendText(p + Environment.NewLine);

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            Animal animal = AnimalFactory.make(CbNames.SelectedItem.ToString(), EdName.Text);
            EdLog.AppendText(animal + Environment.NewLine);
        }
    }
}
