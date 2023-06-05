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
using System.Net;

namespace Server
{
    public partial class ServerForm : Form
    {
        private static UTF8Encoding enc = new UTF8Encoding();
        private int port;
        private bool stoped;
        private TcpListener srv = null;
        private List<Socket> clientList = new List<Socket>();

        public ServerForm()
        {
            InitializeComponent();
            EdPort_TextChanged(null, null); // Tego brakowało, port miał wartość 0
        }

        private void LbPort_Click(object sender, EventArgs e)
        {
            EdPort.SelectAll();
            EdPort.Focus();
        }

        private void EdPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled = int.TryParse(EdPort.Text, out port);
        }

        private void Client()
        {
            Socket client = srv.AcceptSocket();
            string whoAmI = client.RemoteEndPoint.ToString();
            lock (clientList) clientList.Add(client);
            Invoke(new Action(() => { EdLog.AppendText("Connected: " + whoAmI); }));
            while (client.Connected)
            {
                if (client.Poll(5, SelectMode.SelectRead))
                {
                    int size = client.Available;
                    if (size <= 0)
                    {
                        client.Disconnect(false);
                        break;
                    }
                    byte[] buff = new byte[size];
                    client.Receive(buff);
                    string message = whoAmI + ": " + enc.GetString(buff);
                    lock (clientList) foreach (Socket cln in clientList) cln.Send(enc.GetBytes(message));
                    Invoke(new Action(() => { EdLog.AppendText(message + Environment.NewLine); }));
                }
                else Thread.Sleep(10);
            }
            Invoke(new Action(() => { EdLog.AppendText("Disconnected: " + whoAmI); }));
            lock (clientList) clientList.Remove(client);
        }

        private void Listen()
        {
            stoped = false;
            srv = new TcpListener(IPAddress.Any, port);
            srv.Start();
            while (!stoped)
            {
                if (srv.Pending()) new Thread(Client).Start();
                else Thread.Sleep(10);
            }
            srv.Stop();
            srv = null;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (srv == null)
            {
                new Thread(Listen).Start();
                BtnConnect.Text = "Disconnect";
                AcceptButton = null;
                CancelButton = BtnConnect;
                EdPort.Enabled = false;
            }
            else
            {
                BtnConnect.Text = "Connect";
                CancelButton = null;
                AcceptButton = BtnConnect;
                EdPort.Enabled = true;
                stoped = true;
            }
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stoped = true;
        }
    }
}
