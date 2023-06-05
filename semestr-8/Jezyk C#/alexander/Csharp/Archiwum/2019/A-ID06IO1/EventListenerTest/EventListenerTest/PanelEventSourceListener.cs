using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EventListenerTest
{
    class PanelEventSourceListener : EventSourceBase, EventListener
    {
        private Panel panel;
        private Color[] colors=new Color[] { Color.Black, Color.White };
        private int state = 0;
        public PanelEventSourceListener(Panel panel) : base()
        {
            this.panel = panel;
            AdjustColor();
        }
        private void AdjustColor() { panel.BackColor = colors[state]; }
        private void NextColor() { state = (state + 1) % colors.Length; }
        public void Event(EventSource es)
        {
            NextColor();
            AdjustColor();
            if (state == 0) EventCall();
        }
    }
}
