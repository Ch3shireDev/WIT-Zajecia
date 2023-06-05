using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleCalculator
{
    delegate void FieldsChecker();
    class DobleFieldControler
    {
        private double _Value;
        private TextBox TbValue;
        private FieldsChecker Checker;

        public double Value { get { return _Value; } }

        public DobleFieldControler(double Value, TextBox TbValue, FieldsChecker Checker = null)
        {
            this._Value = Value;
            this.TbValue = TbValue;
            this.Checker = Checker;
            TbValue.Text = Value.ToString();
            TbValue.TextChanged += TbValue_TextChanged;
        }

        private void TbValue_TextChanged(object sender, EventArgs e)
        {
            bool ok = double.TryParse(TbValue.Text, out _Value);
            TbValue.BackColor = ok ? SystemColors.Window : Color.Yellow;
            if(Checker!=null) Checker();
        }
    }
}
