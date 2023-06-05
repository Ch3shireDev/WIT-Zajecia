using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    delegate void sendMessage(ClientTalk sender, string text);
    delegate void showText(string text);


    public partial class ServerMain : Form
    {
        private TcpListener srv;
        private Thread th;
        private List<ClientTalk> lst;
        public ServerMain()
        {
            InitializeComponent();
            lst = new List<ClientTalk>();
            //srv = null;
        }

        private void appendText(string text) {
            txtInfo.AppendText(text + Environment.NewLine);
        }

        private void getMessage(ClientTalk sender, string text) {
            if (text == null)
            {
                lock (lst)
                {
                    lst.Remove(sender);
                }
            }
            else {

                lock (lst)
                {
                    foreach (ClientTalk tlk in lst) tlk.sendText(text);
                }


                Invoke(new showText(appendText), text);


            }
        }

        private void listen() {
            
            while (th!=null)
            {
                if (srv.Pending())
                {
                    lock (lst)
                    {
                        lst.Add(new ClientTalk(srv.AcceptSocket(), getMessage));
                    }
                }
                else Thread.Sleep(10);
            }

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (th != null) {
                srv.Stop();
                th = null;
                txtPort.ReadOnly = false;
                btnListen.Text = "Nalsluchuj";
                AcceptButton = btnListen;
                CancelButton = null;
                appendText("zatrzymano");
                
                lock (lst) {
                    lst.Clear();
                }
            }
            else {
                try
                {
                    srv = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
                    srv.Start();
                    th = new Thread(listen);
                    
                    
                    txtPort.ReadOnly = true;
                    btnListen.Text = "Stop";
                    AcceptButton = null;
                    CancelButton = btnListen;
                    appendText("Wystartowalo nasluchiwanie");
                    th.Start();
                }
                catch (Exception ex)
                {
                    appendText(ex.Message);

                }
            }
        }

        private void ServerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Thread tmp = th;
            th = null;
            if (tmp != null)
            {
                tmp.Join();
                lock (lst)
                {
                    foreach (ClientTalk cln in lst) cln.stop();
                }
            }
        }
    }

    class ClientTalk {

        Socket sock;
        private event sendMessage sendProc;
        private Thread th;
        private static UTF8Encoding en = new UTF8Encoding();
        private string whoAmI;

        public ClientTalk(Socket sock, sendMessage sendProc) {
            whoAmI = sock.RemoteEndPoint.ToString();
            this.sock = sock;
            this.sendProc += sendProc;
            th = new Thread(work);
            th.Start();

        }

        private void work() {

            try
            {
                sendProc(this, whoAmI + " polaczyl sie");
                while (th != null)
                {

                    if (sock.Poll(0, SelectMode.SelectRead))
                    {
                        int size = sock.Available;
                        if (size <= 0)
                        {
                            break;
                        }
                        byte[] buff = new byte[size];
                        sendProc(this, whoAmI+": " + en.GetString(buff, 0, sock.Receive(buff)));
                    }
                    else {
                        Thread.Sleep(10);
                    }
                }
                if (th != null) sendProc(this, whoAmI + " rozlaczyl sie");
            }

            catch (Exception ex)
            {
                sendProc(this, whoAmI + ": " + ex.Message);
            }
            try { sock.Disconnect(true); }
            catch (Exception) { }
            sendProc(this, null);
        }
        public void stop() {
            Thread tmp = th;
            th = null;
            if (th != null) tmp.Join();
        }
        public void sendText(string text)
        {
            sock.Send(en.GetBytes(text));
        }
    }
}
