using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Drawing;
using System.IO;

namespace Mandelbroat
{
    class MandelbroatThread
    {
        public delegate void MandelbroadResultReport(int X, int Y, Bitmap bmp);
        public delegate ServerNode MandelbroadRandServer();
        private double Lf, Tp, mul;
        private int X, Y;
        private MandelbroadResultReport report;
        private MandelbroadRandServer rand;
        public MandelbroatThread(double Lf, double Tp, double mul, int X, int Y, MandelbroadRandServer rand, MandelbroadResultReport report)
        {
            this.Lf = Lf;
            this.Tp = Tp;
            this.mul = mul;
            this.X = X;
            this.Y = Y;
            this.report = report;
            this.rand = rand;
            new Thread(run).Start();
        }
        private void run()
        {
            while(true) // Check still active
            {
                try
                {
                    ServerNode srv = rand();
                    TcpClient cln = new TcpClient(srv.host, srv.port);
                    NetworkStream st = cln.GetStream();
                    BinaryWriter bw = new BinaryWriter(st);
                    bw.Write(Lf);
                    bw.Write(Tp);
                    bw.Write(mul);
                    report(X, Y, new Bitmap(st));
                    break;
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
