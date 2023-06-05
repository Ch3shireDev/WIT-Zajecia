using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventListenerTest
{
    public partial class EventListenerForm : Form
    {
        private static readonly int PanelCount = 5;
        private TimerEventSource timer = new TimerEventSource();
        public EventListenerForm()
        {
            InitializeComponent();
            MakePanels();
            timer.Start();
        }
        public void MakePanels()
        {
            SuspendLayout();
            for (int i = 0; i < PanelCount; ++i)
            {
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.Fixed3D;
                p.TabIndex = i;
                p.Dock = DockStyle.Left;
                Controls.Add(p);
            }
            ResizePanels();
            ResumeLayout(false);
            ConnectPanels();
        }
        public void ConnectPanels()
        {
            EventSource es = timer;
            for (int i = 0; i < Controls.Count; ++i)
            {
                PanelEventSourceListener pes = new PanelEventSourceListener(Controls[i] as Panel);
                es.AddListener(pes);
                es = pes;
            }
        }
        public void ResizePanels()
        {
            int w = Width, x = 0;
            for (int i = 0; i < Controls.Count; ++i)
            {
                int add = (w - x) / (Controls.Count - i);
                Controls[i].Width = add;
                x += add;
            }
        }

        private void EventListenerForm_Resize(object sender, EventArgs e)
        {
            SuspendLayout();
            ResizePanels();
            ResumeLayout(false);
        }
    }
}
