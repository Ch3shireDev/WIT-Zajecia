using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    class BridgeShapeListToListBox : BridgeShapeList
    {
        private ListBox field;
        public BridgeShapeListToListBox(ListBox field)
        {
            this.field = field;
        }

        protected override void InitialiseProcess()
        {
            field.Items.Clear();
        }

        protected override void Proceed(ShapeBase shape)
        {
            field.Items.Add(shape.ToString());
        }

        protected override void FinaliseProcess()
        {
            field.SelectedIndex = field.Items.Count - 1;
        }
    }
}
