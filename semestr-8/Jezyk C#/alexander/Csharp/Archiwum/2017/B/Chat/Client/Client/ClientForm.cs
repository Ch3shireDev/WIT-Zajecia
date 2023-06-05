using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        private static UTF8Encoding enc = new UTF8Encoding();
        private int port;
        private bool stoped;
        private TcpClient cln = null;
        public ClientForm()
        {
            InitializeComponent();
            EdPort_TextChanged(null, null);
        }

        private void LbPort_Click(object sender, EventArgs e)
        {
            EdPort.SelectAll();
            EdPort.Focus();
        }

        private void LbHost_Click(object sender, EventArgs e)
        {
            EdHost.SelectAll();
            EdHost.Focus();
        }

        private void EdPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled = int.TryParse(EdPort.Text, out port);
        }

        private void Listen()
        {
            stoped = false;
            string host = EdHost.Text.Trim();
            cln = new TcpClient(host, port);
            while ((!stoped) && (cln.Connected))
            {
                if (cln.Client.Poll(5, SelectMode.SelectRead))
                {
                    int size = cln.Client.Available;
                    if (size <= 0) break;
                    byte[] buff = new byte[size];
                    cln.Client.Receive(buff);
                    string message = enc.GetString(buff);
                    Invoke(new Action(() => { EdLog.AppendText(message+Environment.NewLine); }));
                }
                else Thread.Sleep(10);
            }
            if (!stoped) Invoke(new Action(() => { BtnConnect_Click(null, null); }));
            cln = null;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(cln == null)
            {
                new Thread(Listen).Start();
                BtnConnect.Text = "Disconnect";
                AcceptButton = BtnSend;
                CancelButton = BtnConnect;
                EdHost.Enabled = false;
                EdPort.Enabled = false;
                BtnSend.Enabled = true;
                EdMessage.Enabled = true;
                EdMessage.SelectAll();
                EdMessage.Focus();
            }
            else
            {
                BtnConnect.Text = "Connect";
                CancelButton = null;
                AcceptButton = BtnConnect;
                EdHost.Enabled = true;
                EdPort.Enabled = true;
                BtnSend.Enabled = false;
                EdMessage.Enabled = false;
                EdHost.SelectAll();
                EdHost.Focus();
                stoped = true;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            /*///
            string message = EdMessage.Text.Trim();
            byte[] buff = enc.GetBytes(message);
            cln.Client.Send(buff);
            /*/
            cln.Client.Send(enc.GetBytes(EdMessage.Text.Trim()));
            //*///

            EdMessage.SelectAll();
            EdMessage.Focus();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stoped = true;
        }
    }
}
