using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.Drawing;

namespace IntegerBox
{
    [Category("Common controls")]
    [DefaultProperty("Value")]
    [Designer(typeof(IntegerBoxDesigner))]
    [ToolboxBitmap(@"P:\Barski\Csharp\IntegerBox.bmp")]
    public class IntegerBox : TextBox
    {
        private string saveText = "0";
        private int saveStart = 0;
        private int saveLength = 1;
        private bool restoring;
        public IntegerBox() : base()
        {
            restoreValues();
        }
        private void saveValues()
        {
            saveText = base.Text;
            saveStart = base.SelectionStart;
            saveLength = base.SelectionLength;
        }
        private void restoreValues()
        {
            restoring = true;
            base.Text = saveText;
            base.SelectionStart = saveStart;
            base.SelectionLength = saveLength;
            restoring = false;
        }
        private bool isGoodValue(string text, out long value)
        {
            value = 0;
            return (text == "") || (text == "-") || (long.TryParse(text, out value));
        }
        private bool isGoodValue(string text)
        {
            long value = 0;
            return isGoodValue(text, out value);
        }
        private long GoodValue(string text)
        {
            long value = 0;
            isGoodValue(text, out value);
            return value;
        }

        [Browsable(true)]
        [Bindable(true)]
        [DefaultValueAttribute(HorizontalAlignment.Right)]
        [Category("Appearance")]
        [Description("Indicate text align")]
        protected HorizontalAlignment TextAlign
        {
            get { return base.TextAlign; }
            set { base.TextAlign = value; }
        }
        [Category("Appearance")]
        [Description("Value of long reprezentation")]
        public long Value
        {
            get { return GoodValue(base.Text); }
            set { base.Text = value.ToString(); }
        }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute("0")]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
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
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (restoring) return;
            if(isGoodValue(base.Text)) saveValues();
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
