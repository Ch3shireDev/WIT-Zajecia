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
    delegate void AppendTextProc(string text);
    public partial class Form1 : Form
    {
        private bool servwerWorking,clientWorking;
        private TcpClient cln;
        private List<Socket> clients = new List<Socket>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Client(Socket sck)
        {
            clients.Add(sck);
            while (servwerWorking)
            {
                if (sck.Poll(10, SelectMode.SelectRead))
                {
                    int size = sck.Available;
                    if (size == 0) break;
                    byte[] buff = new byte[size];
                    sck.Receive(buff);
                    string clientText = sck.RemoteEndPoint.ToString() + ": " + UTF32Encoding.UTF8.GetString(buff);
                    byte[] clientBuff = UTF32Encoding.UTF8.GetBytes(clientText);
                    foreach(Socket sock in clients) sock.Send(clientBuff);
                    AppendText("From Client: " + clientText);
                }
            }
            clients.Remove(sck);
        }

        private void Listen(TcpListener tcp)
        {
            servwerWorking = true;
            tcp.Start();
            while (servwerWorking)
            {
                if (tcp.Pending())
                {
                    Socket sck = tcp.AcceptSocket();
                    string text = "Ala ma kota";
                    byte[] buff = UTF32Encoding.UTF8.GetBytes(text);
                    sck.Send(buff);
                    Thread th = new Thread(() => Client(sck));
                    th.Start();
                }
            }
            tcp.Stop();
        }

        private void AppendText(string text)
        {
            if(InvokeRequired)
            {
                Invoke(new AppendTextProc(AppendText),new object[] {text});
            }
            else EdLog.AppendText(text + Environment.NewLine);
        }

        private void Receive(TcpClient cln)
        {
            clientWorking = true;
            while (clientWorking)
            {
                if(cln.Client.Poll(10, SelectMode.SelectRead))
                {
                    int size = cln.Available;
                    byte[] buff = new byte[size];
                    cln.Client.Receive(buff);
                    AppendText("From Server: "+UTF32Encoding.UTF8.GetString(buff));
                    ///cln.Client.Send(UTF32Encoding.UTF8.GetBytes("Answer"));
                }
            }
            cln.Close();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            cln = new TcpClient("localhost", 8888);

            Thread th = new Thread(() => Receive(cln));
            th.Start();
        }

        private void BtnServer_Click(object sender, EventArgs e)
        {
            TcpListener tcp = new TcpListener(IPAddress.Any, 8888);
            Thread th = new Thread(() => Listen(tcp));
            th.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            servwerWorking = false;
            clientWorking = false;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string text = EdMessage.Text;
            cln.Client.Send(UTF8Encoding.UTF8.GetBytes(text));
        }
    }
}
