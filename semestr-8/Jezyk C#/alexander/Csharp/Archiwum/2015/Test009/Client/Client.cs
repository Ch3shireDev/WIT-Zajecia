using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Client : Form
    {
        private ASCIIEncoding en = new ASCIIEncoding();
        private TcpClient cln;
        private Thread thr;
        private bool Run;
        public delegate void CallAppendText(string Str);

        public Client()
        {
            InitializeComponent();
        }

        private void AppendText(string Str)
        {
            if (InvokeRequired)
            {
                Invoke(new CallAppendText(AppendText), new Object[] { Str });
            }
            else LogBox.AppendText(Str + Environment.NewLine);
        }

        private void work()
        {
            ASCIIEncoding en = new ASCIIEncoding();
            byte[] bufer = new byte[1024];
            while(Run)
            {
                if(cln.Client.Poll(5,SelectMode.SelectRead))
                {
                    if (cln.Client.Available <= 0) break;
                    AppendText(en.GetString(bufer, 0, cln.Client.Receive(bufer)));
                }
            }
            cln.Client.Disconnect(true);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (Port.ReadOnly)
            {
                Port.ReadOnly = false;
                Host.ReadOnly = false;
                ToSend.ReadOnly = true;
                Run = false;
                BtnConnect.Text = "Połącz";
            }
            else
            {
                cln = new TcpClient(Host.Text, int.Parse(Port.Text));
                Port.ReadOnly = true;
                Host.ReadOnly = true;
                ToSend.ReadOnly = false;
                Run = true;
                thr = new Thread(work);
                thr.Start();
                BtnConnect.Text = "Zatrzymaj";
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (Port.ReadOnly)
            { 
                byte[] bufer = new byte[1024];
                AppendText("Ja => " + ToSend.Text);
                cln.Client.Send(en.GetBytes(ToSend.Text));
                ToSend.SelectAll();
                ToSend.Focus();
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
        }

    }
}
