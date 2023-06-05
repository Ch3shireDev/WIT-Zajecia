using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListenerTest
{
    interface Listener
    {
        void Event(EventSource es);
    }
    interface EventSource
    {
        void AddListener(Listener ls);
        void RemoveListener(Listener ls);
        void Clear();
        void Call();
    }
}
