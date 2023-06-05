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
        private static readonly int PanelCount=4;
        private EventListenerPanel[] panels = new EventListenerPanel[PanelCount];
        private TimerEventSource timer = new TimerEventSource();
        public EventListenerForm()
        {
            InitializeComponent();
            MakePanels();
            timer.Start();
        }
        private void MakePanels()
        {
            SuspendLayout();
            EventSource es = timer;
            for (int i = 0; i < PanelCount; ++i)
            {
                EventListenerPanel p = new EventListenerPanel();
                panels[i] = p;
                p.BorderStyle = BorderStyle.Fixed3D;
                p.TabIndex = i;
                Controls.Add(p);
                es.AddListener(p);
                es = p;
            }
            AdjustPanelsSize();
            ResumeLayout(false);
        }
        private void AdjustPanelsSize()
        {
            int w = Width, h = Height, x = 0;
            for (int i = PanelCount-1; i >=0 ; --i)
            {
                int add = (w - x) / (i + 1);
                EventListenerPanel p = panels[i];
                p.Location = new Point(x, 0);
                p.Size = new Size(add, h);
                x += add;
            }
        }

        private void EventListenerForm_Resize(object sender, EventArgs e)
        {
            SuspendLayout();
            AdjustPanelsSize();
            ResumeLayout(false);
        }
    }
}
