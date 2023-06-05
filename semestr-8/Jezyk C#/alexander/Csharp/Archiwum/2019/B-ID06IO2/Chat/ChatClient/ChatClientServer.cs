using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ChatClient
{
    delegate void MessageProc(string msg);
    delegate void PortProc(int port);
    delegate void AdjustProc(bool state);
    public partial class ChatClientServer : Form
    {
        private static string[] Caption = new string[] { "Połącz", "Rozłącz" };
        private static string[] Title = new string[] { "Chat Klient ...", "Chat Serwer ..." };
        private Button[] BtnAutoCancel, BtnAutoAccept;
        private HashSet<TcpClient> clients = new HashSet<TcpClient>();
        private Socket sock = null;
        private Thread th = null;
        private bool active;
        public ChatClientServer()
        {
            InitializeComponent();
            BtnAutoCancel = new Button[] { null, BtnConnect };
            BtnAutoAccept = new Button[] { BtnConnect, BtnSend };
            BtnServer_CheckedChanged(null, null);
        }

        private void SetPort(int port)
        {
            EdPort.Text = port.ToString();
        }
        private void InvokeSetPort(int port)
        {
            Invoke(new PortProc(SetPort), new object[] { port });
        }
        private int GetPort()
        {
            int port;
            if (!int.TryParse(EdPort.Text, out port))
            {
                port = 5555;
                InvokeSetPort(port);
            }
            return port;
        }
        private void AppendText(string msg)
        {
            EdLog.AppendText(msg + Environment.NewLine);
        }
        private void InvokeAppendText(string msg)
        {
            try { Invoke(new MessageProc(AppendText), new object[] { msg }); } catch {}
        }
        private void AdjustButtons(bool state)
        {
            EdHost.Enabled = !state;
            EdPort.Enabled = !state;
            EdMessage.Enabled = state;
            BtnSend.Enabled = state;
            int p = (state ? 1 : 0);
            BtnConnect.Text = Caption[p];
            CancelButton = BtnAutoCancel[p];
            AcceptButton = BtnAutoAccept[p];
        }
        private void InvokeAdjustButtons(bool state)
        {
            try { Invoke(new AdjustProc(AdjustButtons), new object[] { state }); } catch { }
        }
        private void ClientThread()
        {
            active = true;
            InvokeAdjustButtons(true);
            InvokeAppendText("Klient próbuje wystartować");
            try
            {
                TcpClient cln = new TcpClient(EdHost.Text, GetPort());
                sock = cln.Client;
                InvokeAppendText("Klient wystartował");
                while (active)
                {
                    if (sock.Poll(10, SelectMode.SelectRead))
                    {
                        int size = cln.Available;
                        if (size <= 0) break;
                        byte[] buff = new byte[size];
                        sock.Receive(buff);
                        string msg = UTF8Encoding.UTF8.GetString(buff);
                        InvokeAppendText(msg);
                    }
                }
                cln.Close();
            }
            catch (Exception) { }
            InvokeAppendText("Klient zatrzymany");
            InvokeAdjustButtons(false);
            th = null;
        }
        private void ServerThread()
        {
            active = true;
            InvokeAdjustButtons(true);
            InvokeAppendText("Serwer próbuje wystartować");
            try
            {
                TcpListener srv = new TcpListener(IPAddress.Any, GetPort());
                srv.Start();
                InvokeAppendText("Serwer wystartował");
                while (active)
                {
                    if (srv.Pending())
                    {
                        TcpClient cln = srv.AcceptTcpClient();
                        InvokeAppendText("Połączył się: " + cln.Client.RemoteEndPoint.ToString());
                        lock (clients) { clients.Add(cln); } 
                    }
                    else CheckClients();
                }
                srv.Stop();
            }
            catch{}
            InvokeAppendText("Serwer zatrzymany");
            InvokeAdjustButtons(false);
            th = null;
        }
        private void CheckClients()
        {
            try
            {
                foreach (TcpClient cln in clients)
                {
                    if (!active) break;
                    try { CheckClient(cln); } catch { }
                }
            }
            catch{}
        }
        private void CheckClient(TcpClient cln)
        {
            if (cln.Client.Poll(1, SelectMode.SelectRead))
            {
                int size = cln.Available;
                if (size <= 0)
                {
                    InvokeAppendText("Rozłączył się: " + cln.Client.RemoteEndPoint.ToString());
                    lock (clients) { clients.Remove(cln); }
                }
                else
                {
                    byte[] buff = new byte[size];
                    cln.Client.Receive(buff);
                    string msg
                    =
                        cln.Client.RemoteEndPoint.ToString() +
                        ": " +
                        UTF8Encoding.UTF8.GetString(buff)
                    ;
                    try { SendToAll(msg); } catch {}
                }
            }
        }
        private void SendToAll(string msg)
        {
            InvokeAppendText(msg);
            byte[] buff = UTF8Encoding.UTF8.GetBytes(msg);
            foreach (TcpClient cc in clients)
            {
                if (!active) break;
                try { cc.Client.Send(buff); } catch { }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(th == null)
            {
                if (BtnServer.Checked) th = new Thread(ServerThread);
                else th = new Thread(ClientThread);                    
                th.Start();
            }
            else active = false;
        }
        private void ChatClientServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            active = false;
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            string msg = EdMessage.Text.Trim();
            if (msg.Length > 0) sock.Send(UTF8Encoding.UTF8.GetBytes(msg));
            EdMessage.SelectAll();
            EdMessage.Focus();
        }
        private void BtnServer_CheckedChanged(object sender, EventArgs e)
        {
            bool cl = !BtnServer.Checked;
            Footer.Visible = cl;
            EdHost.Visible = cl;
            Text = Title[cl ? 0 : 1];
        }
    }
}
