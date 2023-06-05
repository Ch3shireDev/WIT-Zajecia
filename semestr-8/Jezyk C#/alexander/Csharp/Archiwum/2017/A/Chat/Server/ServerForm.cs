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
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace Server
{
    public partial class ServerForm : Form
    {
        private TcpListener srv;
        private int port;
        private bool stoped;
        private List<Socket> clientList=new List<Socket>();
        private UTF8Encoding enc = new UTF8Encoding();
        public ServerForm()
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
            Invoke(new Action(() => { AppendLog(message); }));
        }
        private void ServerClient()
        {
            Socket client = srv.AcceptSocket();
            string whoAmI = client.RemoteEndPoint.ToString();
            AppendLogInvoke("Connected:" + whoAmI);
            lock (clientList) clientList.Add(client);
            while (client.Connected)
            {
                if (client.Poll(5,SelectMode.SelectRead))
                {
                    int size = client.Available;
                    if (size <= 0) break;
                    byte[] buffer = new byte[size];
                    client.Receive(buffer);
                    string message = whoAmI + ": " + enc.GetString(buffer);
                    buffer = enc.GetBytes(message);
                    lock (clientList) foreach (Socket cl in clientList) cl.Send(buffer);
                    AppendLogInvoke(message);
                }
                else Thread.Sleep(10);
            }
            lock (clientList) clientList.Remove(client);
            AppendLogInvoke("Disconnected:" + whoAmI);
        }

        private void ServerListen()
        {
            stoped = false;
            srv = new TcpListener(IPAddress.Any,port);
            srv.Start();
            while (!stoped)
            {
                if (srv.Pending()) new Thread(ServerClient).Start();
                else Thread.Sleep(10);
            }
            srv.Stop();
            srv = null;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (srv == null)
            {
                new Thread(ServerListen).Start();
                EdPort.Enabled = false;
                BtnConnect.Text = "Disconnect";
                AcceptButton = null;
                CancelButton = BtnConnect;
            }
            else
            {
                stoped = true;
                EdPort.Enabled = true;
                BtnConnect.Text = "Connect";
                CancelButton = null;
                AcceptButton = BtnConnect;
            }
            EdLog.Focus();
        }

        private void EdPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled=int.TryParse(EdPort.Text, out port);
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stoped = true;
        }

        private void LbPort_Click(object sender, EventArgs e)
        {
            EdPort.Focus();
        }
    }
}
