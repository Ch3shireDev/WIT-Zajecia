using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Cln
{
    public partial class Form1 : Form
    {
        private TcpClient Cln;
        private Stream str;
        private BinaryReader rd;
        private BinaryWriter wr;
        private Thread Thr;
        private bool Run;

        public Form1()
        {
            InitializeComponent();
            Run = true;
            Thr = new Thread(work);
            Thr.Priority = ThreadPriority.BelowNormal;
            Thr.Start();
        }

        private void work()
        {
            try
            {
                Cln = new TcpClient("localhost", 3336);
                str = new NetworkStream(Cln.Client, FileAccess.ReadWrite, true);
                rd = new BinaryReader(str, Encoding.UTF8);
                wr = new BinaryWriter(str, Encoding.UTF8);
                double d = 100;
                wr.Write(d);
                Cln.ReceiveTimeout = 50;
                while (Cln.Connected && Run)
                {
                    try
                    {
                        if (Cln.Client.Poll(5, SelectMode.SelectRead))
                        {
                            if (Cln.Available > 0)
                            {
                                d = rd.ReadDouble();
                                MessageBox.Show(d.ToString());
                                break;
                            }
                            else break;
                        }
                        else
                        {
                            Thread.Sleep(50);
                        }
                    }
                    catch (Exception e)
                    {
                        if (Run) MessageBox.Show("B³¹d komunikacji: " + e.Message);
                    }
                }
                Cln.Close();
                Cln = null;
            }
            catch (Exception e)
            {
                if (Run) MessageBox.Show("B³¹d po³¹czenia: " + e.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
            if (Thr != null) Thr.Join();
        }
    }
}