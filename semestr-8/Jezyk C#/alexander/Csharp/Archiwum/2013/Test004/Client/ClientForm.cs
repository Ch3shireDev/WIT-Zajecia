using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        private TcpClient cln;
        private Thread th;
        private ASCIIEncoding en;
        private bool Stopped;
        delegate void DelegateSetText(string s);

        public ClientForm()
        {
            InitializeComponent();
            en = new ASCIIEncoding();
            cln = null;
        }

        void SetText(string s)
        {
            if (InvokeRequired)
            {
                if (!Stopped)
                {
                    Invoke
                    (
                        new DelegateSetText(SetText),
                        new object[] { s }
                    );
                }
            }
            else EAnswer.Text = s;
        }

        private void work()
        {
            Stopped = false;
            byte[] buf = new byte[1024];
            while ((!Stopped) && (cln.Client.Connected))
            {
                try
                {
                    if (cln.Client.Poll(5, SelectMode.SelectRead))
                    {
                        if (cln.Available > 0)
                        {
                            SetText(en.GetString(buf, 0, cln.Client.Receive(buf)));
                        }
                        else break;
                    }

                }
                catch (Exception)
                {
                }
            }
            try
            {
                cln.Client.Disconnect(true);
            }
            catch (Exception)
            {
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (AcceptButton == BtnConnect)
            {
                try
                {
                    BtnConnect.Enabled = false;
                    int Port = 8083;
                    Int32.TryParse(EPort.Text, out Port);
                    EPort.Text = Port.ToString();
                    cln = new TcpClient(EHost.Text, Port);
                    th = new Thread(work);
                    th.Start();
                    BtnSend.Enabled = true;
                    AcceptButton = BtnSend;
                    CancelButton = BtnConnect;
                    BtnConnect.Text = "Rozłącz";
                    EPort.ReadOnly = true;
                    EHost.ReadOnly = true;
                    EQuestion.Focus();
                    BtnConnect.Enabled = true;
                }
                catch (Exception)
                {
                    cln = null;
                    BtnConnect.Enabled = true;
                }
            }
            else
            {
                BtnSend.Enabled = false;
                CancelButton = null;
                AcceptButton = BtnConnect;
                BtnConnect.Text = "Połącz";
                EPort.ReadOnly = false;
                EHost.ReadOnly = false;
                Stopped = true;
                th.Join();
                cln = null;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            cln.Client.Send(en.GetBytes(EQuestion.Text));
            EQuestion.SelectAll();
            EQuestion.Focus();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cln != null)
            {
                Stopped = true;
                th.Join();
            }
        }
    }
}
