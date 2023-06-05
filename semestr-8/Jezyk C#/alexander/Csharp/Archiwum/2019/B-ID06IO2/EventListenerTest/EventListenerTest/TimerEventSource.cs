using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventListenerTest
{
    class TimerEventSource: EventSource
    {
        private Timer timer = new Timer(1000);
        public TimerEventSource()
        {
            timer.Elapsed += new ElapsedEventHandler(CallTime);
        }
        public void Start() { timer.Start(); }
        private void CallTime(object sender, ElapsedEventArgs e) { Call(); }
        private List<Listener> lst = new List<Listener>();
        public void AddListener(Listener ls) { lst.Add(ls); }
        public void RemoveListener(Listener ls) { lst.Remove(ls); }
        public void Clear() { lst.Clear(); }
        public void Call() { foreach (Listener ls in lst) ls.Event(this); }
    }
}
