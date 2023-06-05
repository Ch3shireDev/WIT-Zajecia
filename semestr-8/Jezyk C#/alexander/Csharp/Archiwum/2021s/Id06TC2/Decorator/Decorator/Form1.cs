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
            foreach (string model in CarFactory.Models) CbCars.Items.Add(model);
            foreach (string kind in CarDecoratorFactory.Kinds) ChkDecorators.Items.Add(kind);
            CbCars.SelectedIndex=0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarFactory.Make(CbCars.SelectedItem.ToString());
            foreach(string kind in ChkDecorators.CheckedItems)
            {
                car = CarDecoratorFactory.Make(kind, car);
            }
            TxtLog.AppendText(string.Format("{0,7}: {1}", car.price(), car.info()) + Environment.NewLine);
        }
    }
}
