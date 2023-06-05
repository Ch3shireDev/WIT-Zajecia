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

namespace IntegerBox
{
    [Category("Common controls"), DefaultProperty("Value")]
    [ToolboxBitmap(@"P:\Barski\Csharp\IntegerBox.bmp")]
    [Designer(typeof(IntegerBoxDesigner))]
    public class IntegerBox : TextBox
    {
        private string saveText;
        private int saveSelectionStart, saveSelectionLength;
        private bool Busy;
        public IntegerBox() : base()
        {
            base.Text = "0";
            TextAlign = HorizontalAlignment.Right;
            Multiline = false;
            Busy = false;
        }

        [Category("Appearance"), Description("Value of integer reprezentation")]
        public long Value
        {
            get { return long.Parse(base.Text); }
            set { base.Text = value.ToString(); }
        }

        private void saveState()
        {
            saveSelectionStart = SelectionStart;
            saveSelectionLength = SelectionLength;
            saveText = base.Text;
        }
        private void restoreState()
        {
            base.Text = saveText;
            SelectionStart = saveSelectionStart;
            SelectionLength = saveSelectionLength;
        }

        private static bool goodText(string text, out long value)
        {
            value = 0;
            return (text == "") || (text == "-") || (long.TryParse(text, out value));
        }
        private static bool goodText(string text)
        {
            long value;
            return goodText(text, out value);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!Busy)
            {
                Busy = true;
                if (goodText(base.Text))
                {
                    saveState();
                    base.OnTextChanged(e);
                }
                else restoreState();
                Busy = false;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            saveState();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            saveState();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            saveState();
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
            get { return false; }
            set { base.Multiline = false; }
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