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
    public partial class DecoratorForm : Form
    {
        public DecoratorForm()
        {
            InitializeComponent();
            CbModels.Items.AddRange(CarFactory.Keys);
            CbModels.SelectedIndex = 0;
            CklDecorators.Items.AddRange(CarDecoratorFactory.Keys);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarFactory.Make(CbModels.SelectedItem.ToString());
            foreach(string kind in CklDecorators.CheckedItems)
            {
                car = CarDecoratorFactory.Make(kind, car);
            }
            TxtLog.AppendText(string.Format("{0,9} - {1}{2}", car.price(), car.info(), Environment.NewLine));
        }
    }
}
