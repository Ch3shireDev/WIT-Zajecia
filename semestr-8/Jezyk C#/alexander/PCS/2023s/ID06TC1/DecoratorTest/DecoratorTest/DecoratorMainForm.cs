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
    public partial class DecoratorMainForm : Form
    {
        public DecoratorMainForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Audi();
            if (true) car = new AirCondition(car);
            if (true) car = new TintedWindow(car);

            TbResults.AppendText
            (
                $"{car.price(),12}: {car.info()}"+
                Environment.NewLine
            );
        }
    }
}
