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
            return good ? SystemColors.Window : Color.Yellow;
        }
    }
    class InputControlDouble : InputControl
    {
        public delegate void Calback(InputControl source);
        private TextBox field;
        private Calback calback;
        public bool Good { get; private set; }
        public double Value { get; private set; }
        public InputControlDouble(TextBox field, Calback calback, double defaultValue)
        {
            Good = false;
            this.field = field;
            this.calback = calback;
            field.TextChanged += Field_TextChanged;
            field.Text = defaultValue.ToString();
        }
        private void Field_TextChanged(object sender, EventArgs e)
        {
            double tempValue;
            Good = double.TryParse(field.Text.Trim(), out tempValue);
            this.Value = tempValue;
            field.BackColor = GoodColor(Good);
            calback(this);
        }
    }
}
