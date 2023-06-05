using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleCalculator
{
    class InputControler
    {
        public static Color GoodColor(bool good)
        {
            return good ? SystemColors.Window : Color.Yellow;
        }
    }
    class InputControlerDouble : InputControler
    {
        public delegate void Callback(InputControler sender);
        private TextBox field;
        private Callback callback;
        public double Result { get; private set; }
        public bool Good { get; private set; }
        public InputControlerDouble(TextBox field, Callback callback, double startValue)
        {
            this.field = field;
            this.callback = callback;
            field.TextChanged += field_TextChanged;
            field.Text = startValue.ToString();
        }
        private void field_TextChanged(object sender, EventArgs e)
        {
            double result=0;
            Good = double.TryParse(field.Text.Trim(), out result);
            Result = result;
            field.BackColor = GoodColor(Good);
            callback(this);
        }
    }
}
