using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListenerTest
{
    interface EventSource
    {
        void AddListener(EventListener ls);
        void RemoveListener(EventListener ls);
        void Clear();
        void EventCall();
    }
}
