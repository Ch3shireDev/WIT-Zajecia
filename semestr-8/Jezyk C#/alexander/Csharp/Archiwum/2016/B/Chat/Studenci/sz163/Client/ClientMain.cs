using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    delegate void showText(string text);
    public partial class ClientMain : Form
    {
        
        private TcpClient cln;
        private Thread th;
        private static UTF8Encoding en = new UTF8Encoding();
        public ClientMain()
        {
            InitializeComponent();

        }

        private void appendText(string text)
        {
            txtInfo.AppendText(text + Environment.NewLine);
        }


        private void getMessage(string text)
        {
            Invoke(new showText(appendText), text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (th != null)
            {
                th = null;
                txtPort.ReadOnly = false;
                btnConnect.Text = "Polacz";
                AcceptButton = btnConnect;
                CancelButton = null;
                btnSend.Enabled = false;
                txtMessage.Enabled = false;
                appendText("rozlaczamy");
                try { cln.Client.Disconnect(true); }
                catch (Exception) { }
            }
            else {
                try
                {
                    cln = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
                    th = new Thread(work);
                    

                    txtPort.ReadOnly = true;
                    btnConnect.Text = "Stop";
                    AcceptButton = btnSend;
                    CancelButton = btnConnect;

                    appendText("laczymy ");
                    txtMessage.SelectAll();
                    txtMessage.Focus();
                    th.Start();
                    btnSend.Enabled = true;
                    txtMessage.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    appendText(ex.Message);

                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            cln.Client.Send(en.GetBytes(txtMessage.Text));
            txtMessage.SelectAll();
            txtMessage.Focus();
        }

        private void ClientMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread tmp = th;
            th = null;
            if (tmp != null)tmp.Join();

        }

        private void work()
        {

            try
            {
                getMessage("polaczyl sie");
                while (th != null)
                {

                    if (cln.Client.Poll(0, SelectMode.SelectRead))
                    {
                        int size = cln.Client.Available;
                        if (size <= 0)
                        {
                            break;
                        }
                        byte[] buff = new byte[size];
                        getMessage(en.GetString(buff, 0, cln.Client.Receive(buff)));
                    }
                    else {
                        Thread.Sleep(10);
                    }
                    
                }
                if (th != null) getMessage("rozlaczyl sie");
            }

            catch (Exception ex)
            {
                getMessage(ex.Message);
            }
            try { cln.Client.Disconnect(true); }
            catch (Exception) { }

        }

    }
}
