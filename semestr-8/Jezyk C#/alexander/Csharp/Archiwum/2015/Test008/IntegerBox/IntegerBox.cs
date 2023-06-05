using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Drawing;

namespace SpecialBox
{
    [Category("Common controls"), DefaultProperty("Value")]
    [Designer(typeof(IntegerBoxDesigner))]
    [ToolboxBitmap(@"P:\Barski\C#\IntegerBox.bmp")]
    public class IntegerBox : TextBox
    {
        private bool saveDo;
        private string saveText;
        private int saveSelectionStart, saveSelectionLength;
        public IntegerBox()
        {
            //InitializeComponent();
            TextAlign = HorizontalAlignment.Right;
            saveDo = false;
            base.Text = saveText = "0";
            saveSelectionStart = 0;
            saveSelectionLength = 1;
        }

        [Category("Appearance"), Description("Value of integer reprezentation")]
        public int Value
        {
            get
            {
                return (base.Text.Length == 0) || (base.Text == "-") ? 0 : int.Parse(base.Text);
            }
            set
            {
                base.Text = value.ToString();
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!saveDo)
            {
                saveDo = true;
                int v;
                if ((base.Text.Length == 0) || (base.Text == "-") || (int.TryParse(base.Text, out v)))
                {
                    saveText = base.Text;
                    saveSelectionStart = SelectionStart;
                    saveSelectionLength = SelectionLength;
                }
                else
                {
                    base.Text = saveText;
                    SelectionStart = saveSelectionStart;
                    SelectionLength = saveSelectionLength;
                }
                saveDo = false;
            }
            base.OnTextChanged(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            saveSelectionStart = SelectionStart;
            saveSelectionLength = SelectionLength;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            saveSelectionStart = SelectionStart;
            saveSelectionLength = SelectionLength;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if ((base.Text.Length == 0) || (base.Text == "-"))
            {
                base.Text = saveText = "0";
            }
            SelectAll();
            saveSelectionStart = SelectionStart;
            saveSelectionLength = SelectionLength;
        }

        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text { get { return base.Text; } set { base.Text = value; } }

        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute(false)]
        public override bool Multiline { get { return base.Multiline; } set { base.Multiline = false; } }

        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
