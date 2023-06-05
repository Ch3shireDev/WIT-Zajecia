using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorTest
{
    public partial class DecoratorForm : Form
    {
        public DecoratorForm()
        {
            InitializeComponent();
            foreach (string decor in CarDecorator.keys()) CbDecorators.Items.Add(decor);
            foreach (string kind in Car.keys()) CbKind.Items.Add(kind);
            CbKind.SelectedIndex = 0;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            Car car = Car.make(CbKind.SelectedItem.ToString());
            foreach(string decor in CbDecorators.CheckedItems) car = CarDecorator.make(decor, car);
            EdLog.AppendText(car + Environment.NewLine);
            CbDecorators.Focus();
        }
    }
}
