using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Mandelbroat
{
    class CalcServer
    {
        private TcpListener srv;
        private bool stoped;
        public CalcServer(int port)
        {
            srv = new TcpListener(IPAddress.Any, port);
            new Thread(Listener).Start();
        }
        private void Listener()
        {
            srv.Start();
            try
            {
                while (!stoped)
                {
                    if (srv.Pending())
                    {
                        new Thread(Calculate).Start();
                    }
                    else Thread.Sleep(10);
                }
            }
            catch(Exception)
            {
            }
            srv.Stop();
        }
        private void Calculate()
        {
            try
            {
                TcpClient cln = srv.AcceptTcpClient();
                NetworkStream st = cln.GetStream();
                BinaryReader br = new BinaryReader(st);
                double Lf = br.ReadDouble(), Tp = br.ReadDouble(), mul = br.ReadDouble();
                Bitmap bmp = MandelbroatFragment.calculate(Lf, Tp, mul);
                bmp.Save(st, ImageFormat.Bmp);
                cln.Client.Disconnect(false);
            }
            catch(Exception) {}
        }
        public void Stop()
        {
            stoped = true;
        }
    }
}
