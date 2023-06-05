using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Drawing;
using System.ComponentModel;

namespace IntegerEdit
{
    [Category("Common controls"), DefaultProperty("Value")]
    [ToolboxBitmap(@"P:\Barski\C#\IntegerBox.bmp")]
    public class IntegerEdit : TextBox
    {
        private string saveText;
        private int saveSelectionStart, saveSelectionLength;

        public IntegerEdit() : base()
        {
            Text = "0";
            Multiline = false;
            TextAlign = HorizontalAlignment.Right;
        }
        private static bool goodZero(string text)
        {
            return (text == "") || (text == "-");
        }
        private static bool goodText(string text, out long value)
        {
            if (goodZero(text))
            {
                value = 0;
                return true;
            }
            return long.TryParse(text, out value);
        }
        private bool goodText(out long value)
        {
            return goodText(base.Text, out value);
        }
        private bool goodText()
        {
            long value;
            return goodText(base.Text, out value);
        }
        private void saveSelection()
        {
            saveSelectionStart = SelectionStart;
            saveSelectionLength = SelectionLength;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (goodText())
            {
                saveText = base.Text;
                saveSelection();
            }
            else
            {
                base.Text = saveText;
                SelectionStart = saveSelectionStart;
                SelectionLength = saveSelectionLength;
            }
        }

        [Category("Appearance"), Description("Value of integer reprezentation")]
        public long Value
        {
            get
            {
                long ret;
                goodText(out ret);
                return ret;
            }
            set
            {
                base.Text = value.ToString();
            }
        }
        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute(false)]
        public override bool Multiline
        {
            get { return base.Multiline; }
            set { base.Multiline = false; }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            saveSelection();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            saveSelection();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            saveSelection();
        }
    }
}
