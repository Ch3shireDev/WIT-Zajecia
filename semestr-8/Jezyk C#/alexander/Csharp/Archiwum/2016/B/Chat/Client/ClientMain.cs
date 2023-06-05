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
    delegate void ShowMessage(string Text);
    public partial class ClientMain : Form
    {
        private static UTF8Encoding en = new UTF8Encoding();
        private TcpClient cln;
        private Thread th;
        public ClientMain()
        {
            InitializeComponent();
        }
        private void AppendText(string Text)
        {
            txtInfo.AppendText(Text + Environment.NewLine);
        }
        private void AppendMessage(string Text)
        {
            Invoke(new ShowMessage(AppendText), Text);
        }
        private void Work()
        {
            try
            {
                AppendMessage("Połączono");
                while (th != null)
                {
                    if (cln.Client.Poll(0, SelectMode.SelectRead))
                    {
                        int size = cln.Client.Available;
                        if (size <= 0) break;
                        byte[] buff = new byte[size];
                        AppendMessage(en.GetString(buff, 0, cln.Client.Receive(buff)));
                    }
                    else Thread.Sleep(10);
                }
                if (th != null) AppendMessage("Rozłączono");
            }
            catch (Exception ex)
            {
                AppendMessage(ex.Message);
            }
            try { cln.Client.Disconnect(true); } catch (Exception) { }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (th != null)
            {
                th = null;
                txtPort.ReadOnly = false;
                btnConnect.Text = "Polącz";
                AcceptButton = btnConnect;
                CancelButton = null;
                btnSend.Enabled = false;
                txtMessage.Enabled = false;
                AppendText("Rozłączamy");
                try { cln.Client.Disconnect(true); } catch (Exception) { }
            }
            else
            {
                try
                {
                    cln = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
                    th = new Thread(Work);
                    txtPort.ReadOnly = true;
                    btnConnect.Text = "Stop";
                    AcceptButton = btnSend;
                    CancelButton = btnConnect;
                    AppendText("Lączymy");
                    th.Start();
                    btnSend.Enabled = true;
                    txtMessage.Enabled = true;
                    txtMessage.SelectAll();
                    txtMessage.Focus();
                }
                catch (Exception ex)
                {
                    AppendText(ex.Message);
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
            if (tmp != null) tmp.Join();
        }
    }
}
