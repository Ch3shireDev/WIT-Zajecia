using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    delegate void SendMessage(ClientTalk sender, string Text);
    delegate void ShowMessage(string Text);
    public partial class ServerMain : Form
    {

        private TcpListener srv;
        private Thread th;
        private List<ClientTalk> lst;
        public ServerMain()
        {
            InitializeComponent();
            //srv = null;
            lst = new List<ClientTalk>();
        }

        private void AppendText(string Text)
        {
            txtInfo.AppendText(Text + Environment.NewLine);
        }
        private void GetMessage(ClientTalk sender, string Text)
        {

            if (Text == null)
            {
                lock (lst)
                {
                    lst.Remove(sender);
                }
            }
            else
            {
                lock (lst)
                {
                    foreach (ClientTalk cln in lst) cln.SendText(Text);
                }
                Invoke(new ShowMessage(AppendText), Text);
            }


        }


        private void Listen()
        {
            
            while (th != null)
            {
                if (srv.Pending())
                {
                    lock (lst)
                    {
                        lst.Add(new ClientTalk(srv.AcceptSocket(), GetMessage));
                    }

                }
                else Thread.Sleep(10);
                

            }


        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (th != null)
            {
                th = null;
                srv.Stop();
                txtPort.ReadOnly = false;
                btnListen.Text = "Nasluchuj";
                AcceptButton = btnListen;
                CancelButton = null;
                AppendText("Zatrzymano nasluchiwanie");


            }

            else {

                try
                {
                    srv = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
                    srv.Start();
                    th = new Thread(Listen);
                    th.Start();
                    txtPort.ReadOnly = true;
                    btnListen.Text = "Stop";
                    AcceptButton = null;
                    CancelButton = btnListen;
                    AppendText("Wystartowal nasluchiwanie");
                }
                catch (Exception ex)
                {
                    AppendText(ex.Message);
                }
            }

        }

        private void ServerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            lock (lst)
            {
                foreach (ClientTalk cln in lst) cln.Stop();
            }
            Thread tmp = th;
            th = null;
            tmp.Join();
        }
    }


    class ClientTalk
    {
        private Socket sock;
        private event SendMessage sendProc;
        private Thread th;
        private static UTF8Encoding en = new UTF8Encoding();
        private string whoami;
        public ClientTalk (Socket sock, SendMessage sendProc)
        {
            whoami = sock.RemoteEndPoint.ToString();
            this.sock = sock;
            this.sendProc += sendProc;
            th = new Thread(work);
            th.Start();




        }


        private void work()
        {
            try
            {
                sendProc(this, whoami + ": Połączył się ");
                while (th != null)
                {

                    if (sock.Poll(0, SelectMode.SelectRead))
                    {
                        int size = sock.Available;

                        if (size <= 0) break;
                        byte[] buff = new byte[size];

                        sendProc(this, whoami + ": "+ en.GetString(buff, 0, sock.Receive(buff)));


                    }
                    else Thread.Sleep(10);
                }
                if (th != null) sendProc(this, whoami + ":Rozłączył się");
            }
            catch (Exception ex)
            {
                sendProc(this, whoami + ": " + ex.Message);
            }
            try { sock.Disconnect(true); } catch (Exception) { }
            sendProc(this, null);


        }

        public void Stop()
        {
            Thread tmp = th;
            th = null;
            tmp.Join();
           
        }

        public void SendText(string Text)
        {
            sock.Send(en.GetBytes(Text));

        }








    }

}
