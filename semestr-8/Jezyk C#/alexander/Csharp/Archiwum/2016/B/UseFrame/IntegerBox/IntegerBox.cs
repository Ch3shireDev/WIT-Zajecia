using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace SpecialBox
{
    //[Designer(typeof(IntegerBoxDesigner))]
    //[ToolboxItem(true)]
    //[ToolboxBitmap(@"C:\temp\IntegerBox.bmp")]
    //[ToolboxBitmap(@"P:\Barski\C#\B\UseFrame\IntegerBox.bmp")]
    //[ToolboxBitmap(typeof(IntegerBox), "IntegerBox.Properties.Resources.IntegerBox")]
    //[ToolboxBitmap(typeof(IntegerBox), "IntegerBox")]
    //[ToolboxBitmap(typeof(IntegerBox), "IntegerBox.bmp")]
    [ToolboxBitmap("IntegerBox.bmp")]
    //[ToolboxBitmap(typeof(IntegerBox), @"P:\Barski\C#\B\UseFrame\IntegerBox.bmp")]
    [Category("Common controls"), Description("Enable the user to enter integer value"), DefaultProperty("Value")]
    public partial class IntegerBox : TextBox
    {
        private string GoodText;
        private int GoodStart,GoodLength;
        private bool Busy;
        public IntegerBox(): base()
        {
            TextAlign = HorizontalAlignment.Right;
            GoodText = Text = "0";
            GoodStart = 0;
            GoodLength = Text.Length;
            Busy = false;
        }
        private void RestoreGood()
        {
            Text = GoodText;
            SelectionStart = GoodStart;
            SelectionLength = GoodLength;
        }
        private void SaveGood()
        {
            GoodText = Text;
            GoodStart = SelectionStart;
            GoodLength = SelectionLength;
            bool Neg = (GoodText.Substring(0, 1) == "-");
            int n = Neg ? 1 : 0, pos = n, max = Math.Min(GoodStart, GoodText.Length - 1);
            while ((pos < max) && (GoodText[pos] == '0')) ++pos;
            pos -= n;
            if(pos > 0)
            {
                GoodStart -= pos;
                if(Neg) GoodText = "-"+GoodText.Substring(pos+1);
                else GoodText = GoodText.Substring(pos);
                RestoreGood();
            }
        }
        private void CheckValid()
        {
            if (!Busy)
            {
                Busy = true;
                int value;
                if (Text == "-")
                {
                    GoodText = "-0";
                    GoodStart = 2;
                    GoodLength = 0;
                    RestoreGood();
                }
                else if (int.TryParse(Text, out value)) SaveGood();
                else RestoreGood();
                Busy = false;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            CheckValid();
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            CheckValid();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            CheckValid();
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SelectAll();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Value = Value;
        }

        [Category("Appearance")]
        [Description("Value of integer reprezentation")]
        public int Value
        {
            get
            {
                return int.Parse(Text);
            }
            set
            {
                Text = value.ToString();
            }
        }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text { get { return base.Text; } set { base.Text = value; } }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Multiline { get { return base.Multiline; } set { base.Multiline = false; } }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new bool WordWrap { get { return base.WordWrap; } set { base.WordWrap = false; } }
    }
}
