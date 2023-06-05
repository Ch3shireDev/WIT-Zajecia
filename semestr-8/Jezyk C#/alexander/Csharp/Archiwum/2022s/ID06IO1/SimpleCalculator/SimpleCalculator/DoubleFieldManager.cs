using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleCalculator
{
    delegate void DoubleFieldNotify();
    class DoubleFieldManager
    {
        private static Color BadFieldColor = Color.Yellow;
        private double value;
        private TextBox TbValue;
        private DoubleFieldNotify notify;
        public double Value { get { return value; } }

        public DoubleFieldManager(double value, TextBox TbValue, DoubleFieldNotify notify=null)
        {
            this.value = value;
            this.TbValue = TbValue;
            this.notify = notify;
            TbValue.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TbValue.BackColor
            =
                double.TryParse(TbValue.Text, out value) ?
                SystemColors.Window : BadFieldColor
            ;
            if (notify != null) notify();
        }
    }
}
