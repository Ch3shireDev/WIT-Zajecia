using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ClientServer
{
    public partial class AClient : Form
    {
        private TcpClient Cln;
        private Thread Th;
        private ASCIIEncoding en;
        private bool Work;
        private delegate void SetText(string str);
        private delegate void SetBool(bool val);

        public AClient()
        {
            InitializeComponent();
            en = new ASCIIEncoding();
            //en.CodePage = 1250;
            Th = null;
            Cln = null;
        }

        public void AppendText(string str)
        {
            Log.AppendText(str + "\n");
        }

        public void ThreadAppendText(string str)
        {
            Invoke
            (
                new SetText(AppendText),
                //                AppendText,
                new Object[] { str }
            );
        }

        public void StartCln(bool val)
        {
            Host.Enabled = !val;
            BtnSend.Enabled = val;
        }

        public void ThreadStartCln(bool val)
        {
            Invoke
            (
                new SetBool(StartCln),
                new Object[] { val }
            );
        }

        private void work()
        {
            ThreadStartCln(true);
            byte[] buf = new byte[1024];
            Cln = new TcpClient(Host.Text, 8001);
            Cln.ReceiveTimeout = 5;
            while (Work)
            {
                try
                {
                    string cmd = en.GetString(buf, 0, Cln.Client.Receive(buf));
                    ThreadAppendText(cmd);
                }
                catch (Exception)
                {
                }
            }
            Cln.Close();
            Cln = null;
        }

        private void BtnConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (Th != null)
            {
                Work = false;
                Th.Join();
                StartCln(false);
                Th = null;
            }
            else
            {
                Work = true;
                Th = new Thread(work);
                Th.Priority = ThreadPriority.BelowNormal;
                Th.Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Cln.Client.Send(en.GetBytes(Line.Text));
            Line.SelectAll();
            Line.Focus();
        }

        private void AClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Work = false;
            if (Cln != null) Th.Join();
        }

    }
}