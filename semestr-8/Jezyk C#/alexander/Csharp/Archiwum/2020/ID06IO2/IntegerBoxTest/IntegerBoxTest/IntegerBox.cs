using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Design;
using System.Drawing;

namespace IntegerBoxTest
{
    //[Category("Common controls")]
    [Category("Typowe kontrolki")]
    [DefaultProperty("Value")]
    [Designer(typeof(IntegerBoxDesigner))]
    [ToolboxBitmap(@"P:\Barski\Csharp\IntegerBox.bmp")]
    public class IntegerBox : TextBox
    {
        private string savedText;
        private int savedStart, savedLength;
        private bool changing;
        public IntegerBox() : base()
        {
            TextAlign = HorizontalAlignment.Right;
            base.Text = savedText = "0";
            savedStart = 0;
            savedLength = 1;
        }
        private bool isGoodValue(string text, out long value)
        {
            value = 0;
            return (text == "") || (text == "-") || (long.TryParse(text, out value));
        }

        private bool isGoodValue(string text)
        {
            long value;
            return isGoodValue(text, out value);
        }
        private void saveValues()
        {
            savedText = base.Text;
            savedStart = base.SelectionStart;
            savedLength = base.SelectionLength;
        }
        private void restoreValues()
        {
            base.Text = savedText;
            base.SelectionStart = savedStart;
            base.SelectionLength = savedLength;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!changing)
            {
                try
                {
                    changing = true;
                    if (isGoodValue(base.Text)) saveValues();
                    else restoreValues();
                }
                finally
                {
                    changing = false;
                }
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            saveValues();
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            saveValues();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            saveValues();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            saveValues();
        }
        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute(false)]
        public override bool Multiline
        {
            get { return false; }
            set { base.Multiline = false; }
        }

        [Category("Appearance")]
        [Description("Wartość pola (liczba całkowita)")]
        public long Value
        {
            get
            {
                long value = 0;
                isGoodValue(base.Text, out value);
                return value;
            }
            set
            {
                savedText = value.ToString();
                savedStart = 0;
                savedLength = savedText.Length;
                restoreValues();
            }
        }
        internal class IntegerBoxDesigner : ControlDesigner
        {
            public override DesignerActionListCollection ActionLists
            {
                get
                {
                    DesignerActionListCollection lst = new DesignerActionListCollection();
                    lst.Add(new IntegerBoxDesignerActionList(Component));
                    return lst;
                }
            }
            internal class IntegerBoxDesignerActionList : DesignerActionList
            {
                public IntegerBoxDesignerActionList(IComponent cmp) : base(cmp)
                {
                }
                public override DesignerActionItemCollection GetSortedActionItems()
                {
                    DesignerActionItemCollection items = new DesignerActionItemCollection();
                    items.Add(new DesignerActionTextItem("Podaj wartość początkową ...", "Category"));
                    items.Add(new DesignerActionPropertyItem("Value", "Wartość kontrolki:", "Category", "This is ToolTip!"));
                    return items;
                }
                public long Value
                {
                    get { return ((IntegerBox)base.Component).Value; }
                    set { ((IntegerBox)base.Component).Value = value; }
                }
            }
        }
    }
}