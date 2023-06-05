using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePatern
{
    public class BridgeShapeListToListBox : BridgeShapeList
    {
        private ListBox field;
        public BridgeShapeListToListBox(ListBox field)
        {
            this.field = field;
        }
        public override void InitialiseProcess()
        {
            field.Items.Clear();
        }

        public override void Proceed(Shape shape)
        {
            field.Items.Add(shape.ToString());
        }

        public override void FinaliseProcess()
        {
            field.SelectedIndex = field.Items.Count - 1;
        }

    }
}