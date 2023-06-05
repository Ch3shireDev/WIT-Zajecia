using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EventListenerTest
{
    class EventListenerPanel : Panel, EventSource, Listener
    {
        private List<Listener> lst = new List<Listener>();
        private Color[] colors=new Color[] { Color.Black, Color.White };
        private int state = 0;
        public EventListenerPanel(): base() { AdjustColor(); }
        private void AdjustColor() { BackColor = colors[state]; }
        private void NextColor() { state = (state + 1) % colors.Length; }
        public void Event(EventSource es)
        {
            NextColor();
            AdjustColor();
            if (state == 0) Call();
        }
        public void AddListener(Listener ls) { lst.Add(ls); }
        public void RemoveListener(Listener ls) { lst.Remove(ls); }
        public void Clear() { lst.Clear(); }
        public void Call() { foreach (Listener ls in lst) ls.Event(this); }
    }
}
