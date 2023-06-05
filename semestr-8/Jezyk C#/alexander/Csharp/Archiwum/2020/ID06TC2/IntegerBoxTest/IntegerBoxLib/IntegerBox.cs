using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Design;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.Drawing;

namespace IntegerBoxLib
{
    [Category("Common controls")]
    [DefaultProperty("Value")]
    [Designer(typeof(IntegerBoxDesigner))]
    [ToolboxBitmap(@"P:\Barski\Csharp\IntegerBox.bmp")]
    public class IntegerBox : TextBox
    {
        private string savedText;
        private int savedStart, savedLength;
        private bool restoring;
        public IntegerBox() : base()
        {
            base.TextAlign = HorizontalAlignment.Right;
            savedText = "0";
            savedStart = 0;
            savedLength = savedText.Length;
            restoreValues();
        }
        [Category("Appearance")]
        [Description("Value of integer reprezentation")]
        public long Value
        {
            get
            {
                long value;
                Validate(base.Text, out value);
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
        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                long val = 0;
                if(Validate(value,out val))
                {
                    savedText = val.ToString();
                    savedStart = 0;
                    savedLength = savedText.Length;
                    restoreValues();
                }
            }
        }
        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute(false)]
        public override bool Multiline
        {
            get { return base.Multiline; }
            set { base.Multiline = false; }
        }
        private void saveValues()
        {
            savedText = base.Text;
            savedStart = base.SelectionStart;
            savedLength = base.SelectionLength;
        }
        private void restoreValues()
        {
            try
            {
                restoring = true;
                base.Text = savedText;
                base.SelectionStart = savedStart;
                base.SelectionLength = savedLength;
            }
            finally
            {
                restoring = false;
            }
        }
        private static bool Validate(string text,out long value)
        {
            value = 0;
            return (text == "") || (text == "-") || (long.TryParse(text, out value));
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (restoring) return;
            long value;
            if (Validate(base.Text, out value)) saveValues();
            else restoreValues();
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            saveValues();
            base.OnKeyDown(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            saveValues();
            base.OnKeyUp(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            saveValues();
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            saveValues();
            base.OnMouseUp(mevent);
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
        }
        internal class IntegerBoxDesignerActionList : DesignerActionList
        {
            public IntegerBoxDesignerActionList(IComponent cmp) : base(cmp)
            {
            }

            public override DesignerActionItemCollection GetSortedActionItems()
            {
                DesignerActionItemCollection items = new DesignerActionItemCollection();
                items.Add(new DesignerActionTextItem("Give startup value ...", "Category"));
                items.Add(new DesignerActionPropertyItem("Value", "Box value:", "Category", "This is ToolTip!"));
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
