using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorProject
{
    public partial class DecoratorProjectMainForm : Form
    {
        public DecoratorProjectMainForm()
        {
            InitializeComponent();
            CklDecorators.Items.AddRange(CarDecoratorFactory.Decorators);
            CbModels.Items.AddRange(CarFactory.Models);
            CbModels.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarFactory.make(CbModels.SelectedItem.ToString());
            foreach(string decorator in CklDecorators.CheckedItems)
            {
                car = CarDecoratorFactory.make(decorator,car);
            }
            TbPriceList.AppendText($"{car.price(),12}: {car.info()}"+Environment.NewLine);
        }
    }
}
