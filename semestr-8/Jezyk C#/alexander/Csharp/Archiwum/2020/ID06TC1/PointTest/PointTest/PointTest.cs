using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointTest
{
    public partial class PointTest : Form
    {
        public PointTest()
        {
            InitializeComponent();
            //foreach(string kind in AnimalFabric.keys()) CbNames.Items.Add(kind);
            CbNames.Items.AddRange(AnimalFabric.keys().ToArray());
            CbNames.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Point p=new Point();
            /*
            p.X = 5;
            p.X = 5;
            p.X = 7;
            p.X = 7;
            */
            Point pt = new Point().SetX(3).SetY(5);
            object ob = (object)pt;
            EdLog.AppendText(ob.ToString() + Environment.NewLine);
            Cat cat=new Cat("Puszek");
            EdLog.AppendText(cat.ToString() + Environment.NewLine);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            Animal animal = AnimalFabric.make(CbNames.SelectedItem.ToString(), EdName.Text);
            EdLog.AppendText(animal + Environment.NewLine);
        }
    }
}
