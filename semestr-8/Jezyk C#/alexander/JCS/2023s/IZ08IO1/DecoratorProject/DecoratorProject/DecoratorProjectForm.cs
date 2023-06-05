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
    public partial class DecoratorProjectForm : Form
    {
        public DecoratorProjectForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Audi();
            //foreach(string decorator in CkbDecorators.CheckedItems)
            {
                car = new AirCondition(car);
            }
            TbResults.AppendText($"{car.price(),12}: {car.info()}"+Environment.NewLine);
        }
    }
}
