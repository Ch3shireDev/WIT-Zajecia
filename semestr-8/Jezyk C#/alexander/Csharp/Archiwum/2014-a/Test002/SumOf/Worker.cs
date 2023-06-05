using System;
using System.Threading;
using System.Windows.Forms;

namespace SumOf
{
    class Worker
    {
        const uint MaxThreadProceed = 3000000;
        const uint MaxThreadPerJob = 4;
        public delegate void WorkerEvent(Worker sender);
        private WorkerEvent Progress, Complete;
        public uint Count { get; set; }
        public uint Maximum { get; set; }
        public double Sum { get; set; }
        public bool WaitFor { get; set; }
        public ProgressBarText Bar { get; set; }

        public Worker(uint count,WorkerEvent startup, WorkerEvent progress, WorkerEvent complete)
        {
            Count = count;
            Maximum = (Count + MaxThreadProceed - 1) / MaxThreadProceed;
            Sum = 0;
            WaitFor = true;
            Progress = progress;
            Complete = complete;
            startup(this);
            Bar.Text = Count.ToString();
            for (uint start = 0, threads = 0; (start < Count) && (threads < MaxThreadPerJob); start += MaxThreadProceed, ++threads)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Execute), start);
            }
        }

        private void Execute(object param)
        {
            Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
            for(uint start = (uint)param; start < Count; start += MaxThreadPerJob*MaxThreadProceed)
            {
                double partsum = 0;
                uint stop = Math.Min(start + MaxThreadProceed, Count);
                for (uint i = start + 1; (i <= stop) && (WaitFor); ++i) partsum += 1.0 / i;
                if (WaitFor)
                {
                    Progress(this);
                    lock (this)
                    {
                        Sum += partsum;
                        if (--Maximum == 0) Complete(this);
                    }
                }
                else
                {
                    Progress = null;
                    return;
                }
            }
        }
    }
}
