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
    public partial class TCPChat : Form
    {
        private delegate void AppendLogProc(string text);
        private UInt16 Port=8881;
        private bool Connected;
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients=new List<Socket>();
        public TCPChat()
        {
            InitializeComponent();
            TxtPort.Text=Port.ToString();
        }

        private void AppendLog(string text)
        {
            if(InvokeRequired) Invoke(new AppendLogProc(AppendLog),text);
            else TxtLog.AppendText(text+Environment.NewLine);
        }

        private void TxtPort_TextChanged(object sender,EventArgs e)
        {
            BtnConnect.Enabled=UInt16.TryParse(TxtPort.Text,out Port);
        }

        private void ServerClient()
        {
            Socket client=server.AcceptSocket();
            string who=client.RemoteEndPoint.ToString();
            AppendLog("Connected: "+who);
            clients.Add(client);
            while(Connected)
            {
                if(client.Poll(100000,SelectMode.SelectRead))
                {
                    int size=client.Available;
                    if(size<=0) break;
                    byte[] buff=new byte[size];
                    client.Receive(buff);
                    string message=who+": "+UTF8Encoding.UTF8.GetString(buff);
                    byte[] sendBuff=UTF8Encoding.UTF8.GetBytes(message);
                    foreach(Socket socket in clients) socket.Send(sendBuff);
                    AppendLog(message);
                }
            }
            client.Disconnect(false);
            clients.Remove(client);
            AppendLog("Disconnected: "+who);
        }

        private void Listen()
        {
            AppendLog("Server started");
            server.Start();
            Connected=true;
            while(Connected)
            {
                while ((Connected)&&(!server.Pending())) {}
                if(Connected) new Thread(ServerClient).Start();
                else break;
            }
            AppendLog("Server stoped");
        }

        private void StartServer(UInt16 port)
        {
            server = new TcpListener(port);
            new Thread(Listen).Start();
        }

        private void ClientServer()
        {
            AppendLog("Connected");
            Connected=true;
            while(Connected)
            {
                if(client.Client.Poll(100000, SelectMode.SelectRead))
                {
                    int size=client.Available;
                    if(size<=0) break;
                    byte[] buff=new byte[size];
                    client.Client.Receive(buff);
                    string message=UTF8Encoding.UTF8.GetString(buff);
                    AppendLog(message);
                }
            }
            client.Client.Disconnect(false);
            AppendLog("Disconnected");
        }

        private void StartClient(string host,UInt16 port)
        {
            client=new TcpClient(host,port);
            new Thread(ClientServer).Start();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(Connected) 
            {
                Connected=false;
            }
            else
            {
                if(ChkServer.Checked)
                {
                    StartServer(Port);
                }
                else
                {
                    StartClient(TxtHost.Text, Port);
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string message=TxtMessage.Text.Trim();
            byte[] buff=UTF8Encoding.UTF8.GetBytes(message);
            client.Client.Send(buff);
        }
    }
}
