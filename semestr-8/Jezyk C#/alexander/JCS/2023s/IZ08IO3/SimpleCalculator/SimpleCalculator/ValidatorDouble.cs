using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    class Validator
    {

    }
    class ValidatorDouble: Validator
    {
        public delegate void Callback(Validator validator);
        private Callback callback;
        private TextBox textbox;
        public ValidatorDouble(TextBox textbox, Callback callback)
        {
            this.textbox = textbox;
            this.callback = callback;
            textbox.TextChanged += Textbox_TextChanged;

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {

            callback(this);
        }
    }
}
