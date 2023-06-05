using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace SpecialLibrary
{
    public class IntegerBox:TextBox
    {
        private Int64 value;
        private int oldstart, oldlength;
        private String oldtext;

        [Category("Appearance"), Description("Wprowadzona wartość")]
        public Int64 Value
        {
            get { return value; }
            set 
            {
                this.value = value; 
                Text = oldtext = value.ToString();
                SelectionStart = oldstart = 0;
                SelectionLength = oldlength = oldtext.Length;
            }
        }

        [Category("Appearance"), Description("Odpowiednik wartości jako napis")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
        }

        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }
        }

        public IntegerBox()
        {
            TextAlign = HorizontalAlignment.Right;
            oldstart = 0;
            oldlength = 1;
            value = 0;
            Text = oldtext = "0";
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Int64.TryParse(Text, out value))
            {
                oldtext = Text;
                base.OnTextChanged(e);
            }
            else
            {
                Text = oldtext;
                SelectionStart = oldstart;
                SelectionLength = oldlength;
                Invalidate();
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            oldstart = SelectionStart;
            oldlength = SelectionLength;
            base.OnKeyUp(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            oldstart = SelectionStart;
            oldlength = SelectionLength;
            base.OnMouseUp(e);
        }
    }
}
