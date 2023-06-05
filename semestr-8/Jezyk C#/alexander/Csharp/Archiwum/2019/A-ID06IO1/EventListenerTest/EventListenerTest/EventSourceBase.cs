using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListenerTest
{
    class EventSourceBase : EventSource
    {
        private List<EventListener> lst = new List<EventListener>();
        public void AddListener(EventListener ls) { lst.Add(ls); }
        public void RemoveListener(EventListener ls) { lst.Remove(ls); }
        public void Clear() { lst.Clear(); }
        public void EventCall() { foreach (EventListener ls in lst) ls.Event(this); }
    }
}
