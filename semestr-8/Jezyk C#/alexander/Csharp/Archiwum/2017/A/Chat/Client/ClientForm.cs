using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        public delegate void AppendLogProc(string message);
        private int port;
        private bool stoped;
        private UTF8Encoding enc = new UTF8Encoding();
        private TcpClient cln;
        public ClientForm()
        {
            InitializeComponent();
            EdPort_TextChanged(null, null);
        }
        private void AppendLog(string message)
        {
            EdLog.AppendText(message + Environment.NewLine);
        }
        private void AppendLogInvoke(string message)
        {
            //Invoke(new AppendLogProc(AppendLog), new object[] { message });
            Invoke(new Action(() => { AppendLog(message); }));
        }
        private void Listener()
        {
            stoped = false;
            string host = EdHost.Text;
            try
            {
                cln = new TcpClient(host, port);
                while ((!stoped) && (cln.Connected))
                {
                    if (cln.Client.Poll(5, SelectMode.SelectRead))
                    {
                        int size = cln.Available;
                        if (size <= 0) break;
                        byte[] buffer = new byte[size];
                        cln.Client.Receive(buffer);
                        string message = enc.GetString(buffer);
                        AppendLogInvoke(message);
                    }
                    else Thread.Sleep(10);
                }
            }
            catch(Exception ex)
            {
                AppendLogInvoke("Error: " + ex.Message);
            }
            cln.Client.Disconnect(false);
            cln = null;
            if (!stoped) Invoke(new Action(() => { BtnConnect_Click(null, null); }));
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (cln == null)
            {
                new Thread(Listener).Start();
                EdHost.Enabled = false;
                EdPort.Enabled = false;
                BtnConnect.Text = "Disconnect";
                AcceptButton = BtnSend;
                CancelButton = BtnConnect;
                EdMessage.ReadOnly = false;
                BtnSend.Enabled = true;
            }
            else
            {
                stoped = true;
                EdHost.Enabled = true;
                EdPort.Enabled = true;
                BtnConnect.Text = "Connect";
                CancelButton = null;
                AcceptButton = BtnConnect;
                EdMessage.ReadOnly = true;
                BtnSend.Enabled = false;
            }
            EdMessage.Focus();
        }
        private void EdPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled = int.TryParse(EdPort.Text, out port);
        }
        private void LbHost_Click(object sender, EventArgs e)
        {
            EdHost.Focus();
        }

        private void LbPort_Click(object sender, EventArgs e)
        {
            EdPort.Focus();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stoped = true;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            cln.Client.Send(enc.GetBytes(EdMessage.Text.Trim()));
            EdMessage.SelectAll();
            EdMessage.Focus();
        }
    }
}
