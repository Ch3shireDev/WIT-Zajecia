using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    class InputControl
    {
        public static Color GoodColor(bool good)
        {
            return good?SystemColors.Window:Color.Yellow;
        }
    }
    class InputControlDouble : InputControl
    {
        public delegate void Callback(InputControl sender);
        private TextBox field;
        private Callback callback;
        public double Result { get; private set; }
        public bool Good { get; private set; }
        public InputControlDouble(TextBox field,double value, Callback callback)
        {
            this.field = field;
            this.callback = callback;
            field.TextChanged += field_TextChanged;
            field.Text = value.ToString();
        }
        private void field_TextChanged(object sender, EventArgs e)
        {
            double Result;
            Good = double.TryParse(field.Text.Trim(), out Result);
            this.Result = Result;
            field.BackColor = GoodColor(Good);
            callback(this);
        }
    }
}
