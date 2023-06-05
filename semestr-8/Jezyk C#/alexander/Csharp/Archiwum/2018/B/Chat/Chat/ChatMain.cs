using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    delegate void ProcWithString(string text);
    public partial class ChatMain : Form
    {
        private TcpListener srv = null;
        private TcpClient cln = null;
        private int port = 8888;
        private string myname;
        private bool Running = false;
        //private List<Socket> sockets = new List<Socket>();
        private Dictionary<string, Socket> sockets = new Dictionary<string, Socket>();
        private UTF8Encoding enc = new UTF8Encoding();
        public ChatMain()
        {
            InitializeComponent();
            AdjustButtonConnect();
            CheckParameters();
        }
        private void AdjustButtonDisconnect()
        {
            BtnServer.Enabled = false;
            EdHost.Enabled = false;
            EdPort.Enabled = false;
            EdName.Enabled = false;
            BtnStart.Text = "Rozłącz";
            AcceptButton = BtnSend;
            CancelButton = BtnStart;
            EdSendText.Enabled = true;
            BtnSend.Enabled = true;
        }
        private void AdjustButtonConnect()
        {
            BtnServer.Enabled = true;
            EdHost.Enabled = true;
            EdPort.Enabled = true;
            EdName.Enabled = true;
            BtnStart.Text = "Połącz";
            AcceptButton = BtnStart;
            CancelButton = null;
            EdSendText.Enabled = false;
            BtnSend.Enabled = false;
        }
        private void InvokeAdjustButtonConnect()
        {
            Invoke(new ThreadStart(AdjustButtonConnect));
        }
        private int getPort()
        {
            return port;
        }
        private void LogAppend(string text)
        {
            Log.AppendText(text + Environment.NewLine);
        }
        private void InvokeLogAppend(string text)
        {
            Invoke(new ProcWithString(LogAppend),new object[] { text });
        }
        private void CheckParameters()
        {
            myname = EdName.Text.Trim();
            BtnStart.Enabled
            =
                int.TryParse(EdPort.Text, out port) &&
                myname.Length > 0
            ;
        }
        private static void TryDisconnect(Socket soc)
        {
            try
            {
                if (soc.Connected) soc.Disconnect(false);
            }
            catch (Exception)
            {
            }
        }
        private void SendForAll(string text)
        {
            byte[] buff = enc.GetBytes(text);
            lock (sockets)
            {
                foreach (var s in sockets) s.Value.Send(buff);
            }
            InvokeLogAppend(text);
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(BtnServer.Enabled)
            {
                AdjustButtonDisconnect();
                if(BtnServer.Checked)
                {
                    new Thread(SrvLoop).Start();
                }
                else
                {
                    new Thread(ClnLoop).Start();
                }
            }
            else
            {
                AdjustButtonConnect();
                Running = false;
            }
        }
        private void SrvLoop()
        {
            try
            {
                srv = new TcpListener(IPAddress.Any, getPort());
                srv.Start();
                InvokeLogAppend("polączono: " + myname);
            }
            catch (Exception)
            {
                InvokeAdjustButtonConnect();
                return;
            }
            Running = true;
            while (Running)
            {
                if (srv.Pending())
                {
                    new Thread(SocLoop).Start(srv.AcceptSocket());
                }
                else Thread.Sleep(10);
            }
            if (Running) SendForAll("rozłączono: " + myname);
            srv.Stop();
            srv = null;
            if(Running) InvokeAdjustButtonConnect();
        }
        private void SocLoop(object obj)
        {
            Socket soc = (Socket)obj;
            string callname;
            if (soc.Poll(5000, SelectMode.SelectRead))
            {
                int len = soc.Available;
                byte[] buff = new byte[len];
                soc.Receive(buff);
                callname = enc.GetString(buff);
            }
            else callname = myname;
            if(callname == myname)
            {
                TryDisconnect(soc);
                return;
            }
            lock (sockets)
            {
                if (sockets.ContainsKey(callname))
                {
                    SendForAll("rozłączono: " + callname);
                    TryDisconnect(sockets[callname]);
                    sockets.Remove(callname);
                }
                //sockets.Add(soc);
                SendForAll("połączono: " + callname);
                sockets.Add(callname, soc);
            }            
            while(Running)
            {
                try
                {
                    if (soc.Poll(10, SelectMode.SelectRead))
                    {
                        int len = soc.Available;
                        if (len <= 0) break;
                        byte[] buff = new byte[len];
                        soc.Receive(buff);
                        string text = callname + ": " + soc.RemoteEndPoint + ": " + enc.GetString(buff);
                        SendForAll(text);
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            SendForAll("rozłączono: " + callname);
            lock (sockets)
            {
                //sockets.Remove(soc);
                sockets.Remove(callname);
            }
            TryDisconnect(soc);
        }
        private void ClnLoop()
        {
            try
            {
                cln = new TcpClient();
                cln.Connect(EdHost.Text, getPort());
            }
            catch(Exception)
            {
                InvokeAdjustButtonConnect();
                return;
            }
            Socket soc = cln.Client;
            soc.Send(enc.GetBytes(myname));
            Running = true;
            while (Running)
            {
                try
                {
                    if (soc.Poll(10, SelectMode.SelectRead))
                    {
                        int len = soc.Available;
                        if (len <= 0) break;
                        byte[] buff = new byte[len];
                        soc.Receive(buff);
                        InvokeLogAppend(enc.GetString(buff));
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
            TryDisconnect(soc);
            cln = null;
            if (Running) InvokeAdjustButtonConnect();
        }
        private void ChatMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Running = false;
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (BtnServer.Checked)
            {
                string text = myname + ": "+srv.LocalEndpoint + ": " + EdSendText.Text;
                SendForAll(text);
            }
            else cln.Client.Send(enc.GetBytes(EdSendText.Text));
            EdSendText.SelectAll();
            EdSendText.Focus();
        }
        private void EdPort_TextChanged(object sender, EventArgs e)
        {
            CheckParameters();
        }
        private void BtnServer_CheckedChanged(object sender, EventArgs e)
        {
            EdHost.Visible = !BtnServer.Checked;
        }
        private void EdName_TextChanged(object sender, EventArgs e)
        {
            CheckParameters();
        }
    }
}
