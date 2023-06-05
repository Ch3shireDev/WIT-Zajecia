using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Drawing;

namespace IntegerBox
{
    [Category("Common Controls")]
    [Description("Enable the user input the integer value.")]
    [DefaultProperty("Value")]
    [ToolboxBitmap(@"P:\Barski\C#\A\IntegerBox\IntegerBox.bmp")]
    [Designer(typeof(IntegerBoxDesigner))]
    public class IntegerBox : TextBox
    {
        private string GoodText;
        private int GoodSelectionStart, GoodSelectionLength;
        private bool Busy;
        public IntegerBox() : base()
        {
            Busy = false;
            TextAlign = HorizontalAlignment.Right;
            SetGood("0", 0, 1);
            RestoreGood();
        }
        private void SetGood(string Text, int Start, int Length)
        {
            GoodText = Text;
            GoodSelectionStart = Start;
            GoodSelectionLength = Length;
        }
        private void SaveGood()
        {
            SetGood(Text, SelectionStart, SelectionLength);
        }
        private void RestoreGood()
        {
            Text = GoodText;
            SelectionStart = GoodSelectionStart;
            SelectionLength = GoodSelectionLength;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!Busy)
            {
                Busy = true;
                int value;
                if(Text=="-")
                {
                    SetGood("-0", 2, 0); RestoreGood();
                }
                if (int.TryParse(Text, out value)) SaveGood();
                else RestoreGood();
                Busy = false;
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            SaveGood();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            SaveGood();
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SelectAll();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Text = int.Parse(Text).ToString();
        }
        [Category("Appearance")]
        [Description("The integer value associated with the control.")]
        public int Value
        {
            get { return int.Parse(Text); }
            set { Text = value.ToString(); }
        }
        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text { get { return base.Text; } set { base.Text = value.ToString(); } }
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
    class IntegerBoxDesigner : ControlDesigner
    {
        private DesignerActionListCollection lst;
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (lst == null)
                {
                    lst = new DesignerActionListCollection();
                    lst.Add(new IntegerBoxDesignerActionList(Component));
                }
                return lst;
            }
        }
    }
    internal class IntegerBoxDesignerActionList : DesignerActionList
    {
        public IntegerBoxDesignerActionList(IComponent box)
            : base(box)
        {
        }
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            //items.Add(new DesignerActionTextItem("Give startup value ...", "Category"));
            items.Add(new DesignerActionPropertyItem("Value", "Box value: ", "Category", "This is ToolTip !!!"));
            return items;
        }
        public int Value
        {
            get { return ((IntegerBox)base.Component).Value; }
            set { ((IntegerBox)base.Component).Value = value; }
        }

    }
}
