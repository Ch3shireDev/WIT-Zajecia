using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class AClient : Form
    {
        private TcpClient cln;
        private Thread th;
        private ASCIIEncoding en;
        delegate void DelegateAppendText(string s);
        public AClient()
        {
            InitializeComponent();
            en = new ASCIIEncoding();
            th = new Thread(work);
            cln = null;
        }

        void AppendText(string s)
        {
            Log.AppendText(s + "\r\n");
        }

        void ThreadAppendText(string s)
        {
            Invoke
            (
                new DelegateAppendText(AppendText),
                new object[] { s }
            );
        }

        private void work()
        {
            cln.Client.Send(en.GetBytes(User.Text));
            byte[] buf = new byte[1024];
            while(cln.Connected)
            {
                cln.ReceiveTimeout = 5;
                try
                {
                    ThreadAppendText(en.GetString(buf, 0, cln.Client.Receive(buf)));
                }
                catch (Exception)
                {
                }
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                Line.SelectAll();
                Line.Focus();
                cln.Client.Send(en.GetBytes(Line.Text));
                AppendText(Line.Text);
            }
            catch (Exception)
            {
                AppendText("B³¹d wysy³ania");
            }
        }

        private void AClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cln != null)
            {
                th.Abort();
                th.Join();
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Enabled = false;
                Host.ReadOnly = true;
                User.ReadOnly = true;
                cln = new TcpClient(Host.Text, 8001);
                th.Start();
                Line.Enabled = true;
                Send.Enabled = true;
                Line.Focus();
            }
            catch (Exception)
            {
                AppendText("Nieudane po³¹czenie");
                cln = null;
                Connect.Enabled = true;
                Host.ReadOnly = false;
                User.ReadOnly = false;
            }

        }

        private void Line_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') Send_Click(sender, null);
        }

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') Connect_Click(sender, null);
        }

        private void Log_DoubleClick(object sender, EventArgs e)
        {
            Log.SelectionStart = Log.Text.Length;
            Log.ScrollToCaret();
        }
    }
}