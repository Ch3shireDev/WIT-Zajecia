using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeTest
{
    public class FigureBridgeListbox : FigureBridge
    {
        private ListBox listbox;
        public FigureBridgeListbox(ListBox listbox)
        {
            this.listbox = listbox;
        }
        protected override void initialize()
        {
            listbox.Items.Clear();
        }
        protected override void finalize()
        {
            listbox.SelectedIndex = listbox.Items.Count - 1;
        }
        protected override void proceed(Figure fig)
        {
            listbox.Items.Add(fig);
        }
    }
}
