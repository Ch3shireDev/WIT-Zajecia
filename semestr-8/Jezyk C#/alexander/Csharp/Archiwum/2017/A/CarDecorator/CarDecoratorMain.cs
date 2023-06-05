using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDecorator
{
    public partial class CarDecoratorMain : Form
    {
        public CarDecoratorMain()
        {
            InitializeComponent();
            foreach (string name in BaseCar.CarNames()) Kind.Items.Add(name);
            Kind.SelectedIndex = 0;
            foreach (string name in BaseCar.DecoratorCarNames()) Decorations.Items.Add(name);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BaseCar car = BaseCar.MakeCarByName(Kind.Text);
            foreach(var item in Decorations.CheckedItems)
            {
                car = BaseCar.MakeDecoratorByName(item.ToString(), car);
            }
            PriceList.Items.Add(car);
        }
    }
}
