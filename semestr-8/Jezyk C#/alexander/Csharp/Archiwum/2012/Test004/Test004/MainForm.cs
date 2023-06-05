using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Test004
{
    public partial class MainForm : Form
    {
        private Thread min, max, avg, add, sub;
        private ReaderWriterLock rw;
        private uint AddCount, SubCount;
        private List Lst;
        private bool Run;
        private delegate void VoidEvent();
        private delegate void SetDouble(double value);

        public MainForm()
        {
            InitializeComponent();
            Lst = new List();
            Run = true;
            rw = new ReaderWriterLock();
            add = new Thread(new ThreadStart(addproc));
            add.Priority = ThreadPriority.Lowest;
            add.Start();
            sub = new Thread(new ThreadStart(subproc));
            sub.Priority = ThreadPriority.Lowest;
            sub.Start();
            min = new Thread(new ThreadStart(minproc));
            min.Priority = ThreadPriority.Lowest;
            min.Start();
            avg = new Thread(new ThreadStart(avgproc));
            avg.Priority = ThreadPriority.Lowest;
            avg.Start();
            max = new Thread(new ThreadStart(maxproc));
            max.Priority = ThreadPriority.Lowest;
            max.Start();
            
            AddCount = SubCount = 0;
        }

        void ShowAdd()
        {
            AddBox.Text=AddCount.ToString();
            CntBox.Text = Lst.count.ToString();
            //Thread.Sleep(10);
        }

        void ThreadShowAdd()
        { 
            Invoke(new VoidEvent(ShowAdd));
        }

        void ShowSub()
        {
            SubBox.Text = SubCount.ToString();
            CntBox.Text = Lst.count.ToString();
            //Thread.Sleep(10);
        }

        void ThreadShowSub()
        { 
            Invoke(new VoidEvent(ShowSub));
        }

        void ShowMin(double Value)
        {
            MinBox.Text=String.Format("{0:0.00}",Value);
        }

        void ThreadShowMin(double Value)
        { 
            Invoke(new SetDouble(ShowMin),new Object[] { Value });
        }

        void ShowAvg(double Value)
        {
            AvgBox.Text=String.Format("{0:0.00}",Value);
        }

        void ThreadShowAvg(double Value)
        { 
            Invoke(new SetDouble(ShowAvg),new Object[] { Value });
        }

        void ShowMax(double Value)
        {
            MaxBox.Text=String.Format("{0:0.00}",Value);
        }

        void ThreadShowMax(double Value)
        { 
            Invoke(new SetDouble(ShowMax),new Object[] { Value });
        }

        private void addproc()
        {
            Random rnd=new Random();
            while(Run)
            {
                int R = rnd.Next(10000) - 1000;
                if(R>Lst.count)
                {
                    try
                    {
                        rw.AcquireWriterLock(100);
                        try
                        {
                            Lst.Add(rnd.Next(9999) / 100.0);
                            ++AddCount;
                            if (Run) ThreadShowAdd();
                        }
                        finally
                        {
                            rw.ReleaseWriterLock();
                        }
                    }
                    catch
                    {
                    }
                }
                //else Thread.Sleep(10);
            }
        }

        private void subproc()
        {
            Random rnd = new Random();
            while (Run)
            {
                int R = 1000 + rnd.Next(5000);
                if (R < Lst.count)
                {
                    try
                    {
                        rw.AcquireWriterLock(100);
                        try
                        {
                            Lst.Drop();
                            ++SubCount;
                            if (Run) ThreadShowSub();
                        }
                        finally
                        {
                            rw.ReleaseWriterLock();
                        }
                    }
                    catch(Exception ex)
                    {
                    }
                }
                //else Thread.Sleep(10);
            }
        }

        private void minproc()
        {
            while (Run)
            {
                try
                {
                    rw.AcquireReaderLock(100);
                    try
                    {
                        double Min=0;
                        bool f=true;
                        for(Node i=Lst.head;i!=null;i=i.next,f=false)
                        {
                            double v=i.value;
                            if((f)||(Min>v)) Min=v;
                        }
                        if (Run) ThreadShowMin(Min);
                    }
                    finally
                    {
                        rw.ReleaseReaderLock();
                    }
                }
                catch(Exception ex)
                {
                }
            }
        }

        private void avgproc()
        {
            while (Run)
            {
                try
                {
                    rw.AcquireReaderLock(100);
                    try
                    {
                        double Sum=0;
                        bool f=true;
                        for(Node i=Lst.head;i!=null;i=i.next,f=false)
                        {
                            Sum+=i.value;
                        }
                        if (Run) ThreadShowAvg(Sum/Lst.count);
                    }
                    finally
                    {
                        rw.ReleaseReaderLock();
                    }
                }
                catch(Exception ex)
                {
                }
            }
        }

        private void maxproc()
        {
            while (Run)
            {
                try
                {
                    rw.AcquireReaderLock(100);
                    try
                    {
                        double Max=0;
                        bool f=true;
                        for(Node i=Lst.head;i!=null;i=i.next,f=false)
                        {
                            double v=i.value;
                            if((f)||(Max<v)) Max=v;
                        }
                        if (Run) ThreadShowMax(Max);
                    }
                    finally
                    {
                        rw.ReleaseReaderLock();
                    }
                }
                catch(Exception ex)
                {
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
        }
    }
}