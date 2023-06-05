using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GetPutCalc
{
    public partial class GetPutCalc : Form
    {
        public List Lst;
        public delegate void SetVoid();
        public delegate void SetDouble(double Value);
        private int PutSleep,GetSleep;

        public int putSleep { get { return PutSleep; } }
        public int getSleep { get { return GetSleep; } }

        public GetPutCalc()
        {
            InitializeComponent();
            Lst=new List();
            PutSleep = 50;
            GetSleep = 100;
        }

        public void SetCount()
        {
            uint Count;
            lock (Lst)
            {
                Count=Lst.count;
            }
            ECount.Text = Count.ToString();
            if (Count < 10) { PutSleep = 50; GetSleep = 100; }
            else if (Count > 90) { PutSleep = 100; GetSleep = 50; }
        }

        public void ThreadSetCount()
        {
            Invoke(new SetVoid(SetCount));
        }

        public void SetMin(double Value)
        {
            EMin.Text = String.Format("{0:0.00}", Value);
        }

        public void ThreadSetMin(double Value)
        {
            Invoke(new SetDouble(SetMin), new object[] { Value });
        }

        public void SetAvg(double Value)
        {
            EAvg.Text = String.Format("{0:0.00}", Value);
        }

        public void ThreadSetAvg(double Value)
        {
            Invoke(new SetDouble(SetAvg), new object[] { Value });
        }

        public void SetMax(double Value)
        {
            EMax.Text = String.Format("{0:0.00}", Value);
        }

        public void ThreadSetMax(double Value)
        {
            Invoke(new SetDouble(SetMax), new object[] { Value });
        }

        private void BtnPut_Click(object sender, EventArgs e)
        {
            new Putter(this);
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            new Getter(this);
        }

        private void GetPutCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriterBase.AbortAll();
        }

        private void GetPutCalc_Load(object sender, EventArgs e)
        {
            new CalcMin(this);
            new CalcMax(this);
            new CalcAvg(this);
        }
    }

    public class WriterBase
    {
        protected static WriterBase First=null;
        protected WriterBase Next;
        protected GetPutCalc Frm;
        protected Thread Th;

        public WriterBase next { get { return Next; } }
        public WriterBase first() { return First; }

        protected WriterBase(GetPutCalc Frm)
        {
            this.Frm = Frm;
            Next = First;
            First = this;
            Th = new Thread(execute);
            Th.Priority = ThreadPriority.Lowest;
        }

        public static void AbortAll()
        {
            for(WriterBase i=First;i!=null;i=i.Next) i.Th.Abort();
            while (First!=null)
            {
                First.Th.Join();
                First = First.Next;
            }
        }

        public virtual void execute()
        {
        }
    }

    public class ReaderBase : WriterBase
    {
        protected ulong LstId;

        protected ReaderBase(GetPutCalc Frm):base(Frm)
        {
            LstId = UInt64.MaxValue;
        }

        public bool NeedRead()
        {
            return LstId != Frm.Lst.id;
        }

        public void Reading()
        {
            LstId = Frm.Lst.id;
        }

    }

    public class CalcMin : ReaderBase
    {
        public CalcMin(GetPutCalc Frm):base(Frm)
        {
            Th.Start();
        }

        public override void execute()
        {
            while (true)
            {
                if (NeedRead())
                {
                    double Min = 0;
                    bool F = true;
                    Frm.Lst.ReaderEnter();
                    try
                    {
                        Reading();
                        for (List.Item i = Frm.Lst.first; i != null; i = i.next)
                        {
                            if ((F) || (Min > i.data)) Min = i.data;
                            F = false;
                        }

                    }
                    finally
                    {
                        Frm.Lst.ReaderLeave();
                    }
                    Frm.ThreadSetMin(Min);
                }
            }
        }
    }

    public class CalcMax : ReaderBase
    {
        public CalcMax(GetPutCalc Frm):base(Frm)
        {
            Th.Start();
        }

        public override void execute()
        {
            while (true)
            {
                if (NeedRead())
                {
                    double Max = 0;
                    bool F = true;
                    Frm.Lst.ReaderEnter();
                    try
                    {
                        Reading();
                        for (List.Item i = Frm.Lst.first; i != null; i = i.next)
                        {
                            if ((F) || (Max < i.data)) Max = i.data;
                            F = false;
                        }

                    }
                    finally
                    {
                        Frm.Lst.ReaderLeave();
                    }
                    Frm.ThreadSetMax(Max);
                }
            }
        }
    }

    public class CalcAvg : ReaderBase
    {
        public CalcAvg(GetPutCalc Frm):base(Frm)
        {
            Th.Start();
        }

        public override void execute()
        {
            while (true)
            {
                if (NeedRead())
                {
                    double Sum = 0;
                    uint Count = 1;
                    bool F = false;
                    Frm.Lst.ReaderEnter();
                    try
                    {
                        Reading();
                        for (List.Item i = Frm.Lst.first; i != null; i = i.next)
                        {
                            Sum += i.data;
                            F = true;
                        }
                        if (F) Count = Frm.Lst.count;
                    }
                    finally
                    {
                        Frm.Lst.ReaderLeave();
                    }
                    Frm.ThreadSetAvg(Sum / Count);
                }
            }
        }
    }

    public class Putter : WriterBase
    {
        private Random Rnd;

        public Putter(GetPutCalc Frm):base(Frm)
        {
            Rnd = new Random();
            Th.Start();
        }

        public override void execute()
        {
            while (true)
            {
                double Data 
                =
                    10+
                    (
                      Rnd.Next(0, 900) +
                      Rnd.Next(0, 900) +
                      Rnd.Next(0, 900) +
                      Rnd.Next(0, 900) +
                      Rnd.Next(0, 900)
                    )
                    /
                    50.0
                ;

                Frm.Lst.put(Data);
                Frm.ThreadSetCount();
                Thread.Sleep(Frm.putSleep);
            }
        }
    }

    public class Getter : WriterBase
    {
        public Getter(GetPutCalc Frm):base(Frm)
        {
            Th.Start();
        }

        public override void execute()
        {
            while (true)
            {
                Frm.Lst.get();
                Frm.ThreadSetCount();
                Thread.Sleep(Frm.getSleep);
            }
        }
    }

    public class List
    {
        public class Item
        {
            private double Data;
            private Item Next;
            public double data { get { return Data; } }
            public Item next { get { return Next; } }

            public Item(double Data)
            {
                this.Data = Data;
                Next = null;
            }

            public void Connect(Item co)
            {
                if (Next == null) Next = co;
            }
        }

        private ReaderWriterLock Rw;
        private Item First;
        private Item Last;
        private uint Count;
        private ulong Id;

        public Item first { get { return First; } }
        public Item last { get { return Last; } }
        public uint count { get { return Count; } }
        public ulong id { get { return Id; } }

        public List()
        {
            Rw = new ReaderWriterLock();
            First = Last = null;
            Count = 0;
            Id = 0;
        }

        public void ReaderEnter()
        {
            Rw.AcquireReaderLock(Timeout.Infinite);
        }

        public void ReaderLeave()
        {
            Rw.ReleaseReaderLock();
        }

        public void put(double data)
        {
            Item tmp = new Item(data);
            Rw.AcquireWriterLock(Timeout.Infinite);
            try
            {
                if (Last != null) Last.Connect(tmp);
                else First=tmp;
                Last = tmp;
                ++Count;
                unchecked { ++Id; }
            }
            finally
            {
                Rw.ReleaseWriterLock();
            }
        }

        public double get()
        {
            Rw.AcquireWriterLock(Timeout.Infinite);
            try
            {
                if (First != null)
                {
                    double Data = First.data;
                    First = First.next;
                    if (First == null) Last = null;
                    --Count;
                    unchecked { ++Id; }
                    return Data;
                }
            }
            finally
            {
                Rw.ReleaseWriterLock();
            }
            return 0;
        }
    }
}