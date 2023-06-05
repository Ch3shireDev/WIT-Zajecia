using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Test021
{
    public partial class Form1 : Form
    {
        delegate void AppendEvent(string str);
        private uint value;
        private Thread[] th = new Thread[20];
        public Form1()
        {
            InitializeComponent();
        }


        void Append(string Text)
        {
            if(InvokeRequired)
            {
                Invoke(new AppendEvent(Append), new object[] { Text });
                return;
            }
            Box.AppendText(Text + Environment.NewLine);
        }

        void Proc()
        {
            for (uint i = 0; i < 10; ++i)
            {
                lock (th)
                {
                    Append((++value).ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value=0;
            for (uint i = 0; i < th.Length; ++i) th[i] = new Thread(Proc);
            for (uint i = 0; i < th.Length; ++i) th[i].Start();
            //for (uint i = 0; i < th.Length; ++i) th[i].Join();
        }
    }
}
