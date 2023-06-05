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
    [Category("Common controls"), DefaultProperty("Value")]
    [Designer(typeof(IntegerBoxDesigner))]
    [ToolboxBitmap(@"P:\Barski\Csharp\2019\IntegerBox.bmp")]
    public class IntegerBox : TextBox
    {
        private string GoodText = "0";
        private int GoodStart, GoodLength;
        public IntegerBox() : base()
        {
            TextAlign = HorizontalAlignment.Right;
            SelectAll();
            SaveGoodParams();
            Size sz = ClientSize;
            SetClientSizeCore(sz.Width - 20, sz.Height);
        }

        public IntegerBox(IContainer container)
        {
            container.Add(this);
        }

        private void SaveGoodParams()
        {
            GoodText = base.Text;
            GoodStart = base.SelectionStart;
            GoodLength = base.SelectionLength;
        }

        [Category("Appearance"), Description("Value of integer reprezentation")]
        public int Value
        {
            get { return base.Text.Length>0?int.Parse(base.Text):0; }
            set { base.Text = value.ToString(); }
        }

        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValueAttribute(false)]
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
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            string text = base.Text;
            int value = 0;
            if ((text.Length > 0) && (!int.TryParse(text, out value)))
            {
                base.Text = GoodText;
                base.SelectionStart = GoodStart;
                base.SelectionLength = GoodLength;
            }
        }

        protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyUp(e);
            SaveGoodParams();
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            SaveGoodParams();
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
        public int Value
        {
            get { return (base.Component as IntegerBox).Value; }
            set { (base.Component as IntegerBox).Value = value; }
        }
    }
}
