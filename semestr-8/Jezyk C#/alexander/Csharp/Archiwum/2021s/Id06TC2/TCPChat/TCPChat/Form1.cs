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
using System.Net;
using System.Net.Sockets;

namespace TCPChat
{
    public partial class Form1 : Form
    {
        private delegate void AppendLogProc(string text);
        private UInt16 port=8881;
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients=new List<Socket>();
        private bool connected;
        public Form1()
        {
            InitializeComponent();
            TxtPort.Text=port.ToString();
        }

        private void AppendLog(string text)
        {
            if(InvokeRequired) Invoke(new AppendLogProc(AppendLog),text);
            else TxtLog.AppendText(text+Environment.NewLine);
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled=UInt16.TryParse(TxtPort.Text,out port);
        }

        private void ClientProcess()
        {
            client=new TcpClient(TxtHost.Text.Trim(),port);
            Socket socket=client.Client;
            AppendLog("Connected to server");
            connected=true;
            while(connected)
            {
                if(socket.Poll(50000,SelectMode.SelectRead))
                {
                    int size=socket.Available;
                    if(size<=0) break;
                    byte[] buffer=new byte[size];
                    socket.Receive(buffer);
                    string message=UTF8Encoding.UTF8.GetString(buffer);
                    AppendLog(message);
                }
            }
            AppendLog("Disconnected to server");
            socket.Disconnect(false);
        }

        private void ServerClientProcess()
        {
            Socket socket=server.AcceptSocket();
            clients.Add(socket);
            string who=socket.RemoteEndPoint.ToString();
            AppendLog(who+" connected");
            while (connected)
            {
                if(socket.Poll(50000,SelectMode.SelectRead))
                {
                    int size=socket.Available;
                    if(size<=0) break;
                    byte[] buffer=new byte[size];
                    socket.Receive(buffer);
                    string message=who+": "+UTF8Encoding.UTF8.GetString(buffer);
                    buffer=UTF8Encoding.UTF8.GetBytes(message);
                    foreach(Socket s in clients) s.Send(buffer);
                    AppendLog(message);
                }
            }
            AppendLog(who+" disconnected");
            clients.Remove(socket);
            socket.Disconnect(false);
        }

        private void ServerProcess()
        { 
            server=new TcpListener(IPAddress.Any,port);
            server.Start();
            AppendLog("Connected");
            connected=true;
            while(connected)
            {
                if (server.Pending()) new Thread(ServerClientProcess).Start();
            }
            AppendLog("Disconnected");
            server.Stop();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(connected)
            {
                connected=false;
            }
            else
            {
                if(ChkServer.Checked) new Thread(ServerProcess).Start();
                else new Thread(ClientProcess).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string message=TxtMessage.Text.Trim();
            byte[] buffer=UTF8Encoding.UTF8.GetBytes(message);
            if(ChkServer.Checked)
            {
            }
            else
            {
                client.Client.Send(buffer);
            }
        }
    }
}
