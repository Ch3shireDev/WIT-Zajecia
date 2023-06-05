using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbModel.Items.AddRange(CarFactory.Models);
            cklDecorators.Items.AddRange(CarDecoratorFactory.Decorators);
            cbModel.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarFactory.Make(cbModel.SelectedItem.ToString());
            foreach(string decor in cklDecorators.CheckedItems)
            {
                car = CarDecoratorFactory.Make(decor, car);
            }
            txtLog.AppendText(string.Format("{0,9} | {1}",car.price(),car.info())+Environment.NewLine);
        }
    }
}
