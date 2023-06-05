using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Mandelbroat
{
    class MandelbroatServer
    {
        private int port;
        private bool stoped;
        private TcpListener server;
        public MandelbroatServer(int port)
        {
            this.port = port;
            new Thread(listen).Start();
        }
        private void listen()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            while (!stoped)
            {
                if (server.Pending())
                {
                    new Thread(work).Start();
                }
                else Thread.Sleep(10);
            }
            server.Stop();
        }
        private void work()
        {
            try
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                BinaryReader br = new BinaryReader(ns);
                double Lf = br.ReadDouble(), Tp = br.ReadDouble(), mul = br.ReadDouble();
                Bitmap bmp = MandelbroatFragment.fragment(Lf, Tp, mul);
                bmp.Save(ns, ImageFormat.Bmp);
                client.Client.Disconnect(false);
            }
            catch (Exception)
            {
            }
        }
        public void Stop()
        {
            stoped = true;
        }
    }
}
