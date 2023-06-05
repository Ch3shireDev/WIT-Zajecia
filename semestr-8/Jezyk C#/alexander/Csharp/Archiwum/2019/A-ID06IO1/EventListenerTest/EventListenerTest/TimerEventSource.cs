using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventListenerTest
{
    class TimerEventSource: EventSourceBase
    {
        private Timer timer = new Timer(1000);
        public TimerEventSource() { timer.Elapsed += ((s, e) => EventCall()); }
        public void Start() { timer.Start(); }
    }
}
