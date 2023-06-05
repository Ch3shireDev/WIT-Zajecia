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
            car = new AirCondition(car);
            car = new TintedWindow(car);
            TbResults.AppendText(car + Environment.NewLine);
        }
    }
}
