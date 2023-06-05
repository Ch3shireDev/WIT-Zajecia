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

namespace Server
{
    public partial class ServerForm : Form
    {
        delegate void DelegateAppendText(string s);
        private TcpListener srv;
        private Thread th;
        private bool Stopped;

        public ServerForm()
        {
            InitializeComponent();
            srv = null;
            th = null;
            Stopped = true;
        }

        void AppendText(string s)
        {
            if (InvokeRequired)
            {
                if (!Stopped)
                {
                    Invoke
                    (
                        new DelegateAppendText(AppendText),
                        new object[] { s }
                    );
                }
            }
            else ELog.AppendText(s + "\n");
        }

        private void listen()
        {
            try
            {
                srv.Start();
                AppendText("Serwer wystartował");
                while (true)
                {
                    try
                    {
                        while ((!Stopped) && (!srv.Pending())) {}
                        if (Stopped)
                        {
                            srv.Stop();
                            break;
                        }
                        new Thread(work).Start(srv.AcceptSocket());
                    }
                    catch (Exception)
                    {
                        AppendText("Błąd przy połączeniu");
                    }
                }
            }
            catch (Exception)
            {
                AppendText("Błąd startu");
            }
            th = null;
        }

        private void work(object os)
        {
            Socket s = null;
            ASCIIEncoding en;
            try
            {
                s = os as Socket;
                AppendText("Połączył się klient " + s.RemoteEndPoint.ToString());
                en = new ASCIIEncoding();
                byte[] buf = new byte[1024];
                while ((!Stopped)&&(s.Connected))
                {
                    try
                    {
                        if (s.Poll(5, SelectMode.SelectRead))
                        {
                            if (s.Available > 0)
                            {
                                String question = en.GetString(buf, 0, s.Receive(buf));
                                String answer;
                                int value = 0;
                                if (Int32.TryParse(question, out value)) answer = (2 * value).ToString();
                                else answer = "Error";
                                s.Send(en.GetBytes(answer));
                                AppendText(s.RemoteEndPoint.ToString() + ": " + question + " -> " + answer);
                            }
                            else break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (s.Connected) s.Disconnect(true);
                AppendText("Rozłączył się klient " + s.RemoteEndPoint.ToString());
            }
            catch (Exception)
            {
                AppendText("Błąd klienta");
                if (s.Connected) s.Disconnect(true);
            }
            th = null;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (AcceptButton == BtnConnect)
            {
                AcceptButton = null;
                CancelButton = BtnConnect;
                BtnConnect.Text = "Rozłącz";
                EPort.ReadOnly = true;
                int Port = 8083;
                Int32.TryParse(EPort.Text, out Port);
                EPort.Text = Port.ToString();
                srv = new TcpListener(IPAddress.Any, Port);
                th = new Thread(listen);
                Stopped = false;
                th.Start();
            }
            else
            {
                CancelButton = null;
                AcceptButton = BtnConnect;
                BtnConnect.Text = "Połącz";
                EPort.ReadOnly = false;
                Stopped = true;
                srv = null;
                th = null;
            }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null)
            {
                Stopped = true;
                th.Join();
            }
        }
    }
}
