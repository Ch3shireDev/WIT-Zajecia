using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    delegate void SendStringInfo(string msg);
    public partial class ClientMain : Form
    {
        private static UTF8Encoding en = new UTF8Encoding();
        private TcpClient cln;
        private Thread th;
        public ClientMain()
        {
            InitializeComponent();
        }
        private void AppendInfo(string msg)
        {
            txtInfo.AppendText(DateTime.Now.ToString("T") + " - " + msg + Environment.NewLine);
        }
        private void ClientInfo(string msg)
        {
            Invoke(new SendStringInfo(AppendInfo), msg);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cln == null)
            {
                try
                {
                    cln = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
                    th = new Thread(listen);
                    th.Start();
                    btnConnect.Text = "Stop";
                    AcceptButton = btnSend;
                    CancelButton = btnConnect;
                    txtMessage.Enabled = true;
                    btnSend.Enabled = true;
                    txtMessage.SelectAll();
                    txtMessage.Focus();
                    AppendInfo("Połączenie");
                }
                catch (Exception ex)
                {
                    AppendInfo(string.Format("Błąd: {0}", ex.Message));
                    cln = null;
                    th = null;
                }
            }
            else
            {
                th = null;
                btnConnect.Text = "Połącz";
                CancelButton = null;
                AcceptButton = btnConnect;
                txtMessage.Enabled = false;
                btnSend.Enabled = false;
            }
        }
        private void listen()
        {
            while (th != null)
            {
                if (cln.Client.Poll(10, SelectMode.SelectRead))
                {
                    int size = cln.Available;
                    if (size <= 0) th = null;
                    else
                    {
                        byte[] buff = new byte[size];
                        string str = en.GetString(buff, 0, cln.Client.Receive(buff));
                        ClientInfo(str);
                    }
                }
                else Thread.Sleep(5);
            }
            cln.Client.Disconnect(true);
            ClientInfo("Rozłączono");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            cln.Client.Send(en.GetBytes(txtMessage.Text));
            txtMessage.SelectAll();
            txtMessage.Focus();
        }

        private void ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread tmp = th;
            th = null;
            tmp.Join();
        }
    }
}
