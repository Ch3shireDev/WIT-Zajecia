using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.IO;
using System.Net.Sockets;

namespace Mandelbroat
{
    class MandelbroatThread
    {
        public delegate void CalbackProc(int x, int y, Bitmap bmp);
        public delegate Server GetServer();
        private double Lf, Tp, mul;
        private int X, Y;
        private CalbackProc calback;
        private GetServer connection;
        public MandelbroatThread(double Lf, double Tp, double mul, int X, int Y, CalbackProc calback, GetServer connection)
        {
            this.Lf = Lf;
            this.Tp = Tp;
            this.mul = mul;
            this.X = X;
            this.Y = Y;
            this.calback = calback;
            this.connection = connection;
            new Thread(connect).Start();
            //
        }
        private void connect()
        {
            while(true)
            {
                Server server = connection();
                try
                {
                    TcpClient client = new TcpClient(server.host, server.port);
                    NetworkStream nw = client.GetStream();
                    BinaryWriter bw = new BinaryWriter(nw);
                    bw.Write(Lf);
                    bw.Write(Tp);
                    bw.Write(mul);
                    calback(X, Y, new Bitmap(nw));
                    break;
                }
                catch(Exception)
                {
                }
            }
        }
    }
}
