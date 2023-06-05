using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpecialBox
{
    public partial class IntegerBox : System.Windows.Forms.TextBox
    {
        private int Value;

        public IntegerBox()
        {
            Value = 1;
            Text = "1";
            TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!System.Int32.TryParse(Text,out Value)) Text = Value.ToString();
        }

    }
}
