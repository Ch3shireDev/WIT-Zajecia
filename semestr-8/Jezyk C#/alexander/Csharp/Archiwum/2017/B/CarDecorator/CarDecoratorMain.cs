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
            foreach (string name in CarFactory.Names()) Kind.Items.Add(name);
            Kind.SelectedIndex = 0;
            foreach (string name in DecoratorFactory.Names()) Decorations.Items.Add(name);
        }

        private BaseCar make()
        {
            BaseCar car = CarFactory.MakeByName(Kind.Text);
            foreach(var name in Decorations.CheckedItems)
            {
                car = DecoratorFactory.MakeByName(name.ToString(), car);                
            }
            return car;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            List.Items.Add(make());
        }
    }
}
