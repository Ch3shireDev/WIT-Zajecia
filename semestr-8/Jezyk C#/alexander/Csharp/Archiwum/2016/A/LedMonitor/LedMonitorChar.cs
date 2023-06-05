using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedMonitor
{
    class LedMonitorChar
    {
        private bool[,] data;
        public LedMonitorChar(int width,string rep)
        {
            int height = rep.Length/width;
            this.data = new bool[height, width];
            for (int h = 0, i = 0; h < height; ++h)
            {
                for (int w = 0; w < width; ++w, ++i)
                {
                    data[h,w]=(rep[i]=='@');
                }
            }
        }
        public int width { get { return data.GetLength(1); } }
        public int height { get { return data.GetLength(0); } }
        public bool[,] getData() { return data; }
        public static LedMonitorChar Space()
        {
            return new LedMonitorChar
            (
                1,
                "-" +
                "-" +
                "-" +
                "-" +
                "-"
            );
        }

        public static LedMonitorChar digit0()
        {
            return new LedMonitorChar
            (
                3,
                "-@-" +
                "@-@" +
                "@-@" +
                "@-@" +
                "-@-" 
            );
        }
        public static LedMonitorChar digit1()
        {
            return new LedMonitorChar
            (
                3,
                "-@-" +
                "@@-" +
                "-@-" +
                "-@-" +
                "@@@"
            );
        }
        public static LedMonitorChar digit2()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "@-@" +
                "-@-" +
                "@--" +
                "@@@"
            );
        }
        public static LedMonitorChar digit3()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "--@" +
                "-@-" +
                "--@" +
                "@@@"
            );
        }
        public static LedMonitorChar digit4()
        {
            return new LedMonitorChar
            (
                3,
                "@-@" +
                "@-@" +
                "@@@" +
                "--@" +
                "--@"
            );
        }
        public static LedMonitorChar digit5()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "@--" +
                "@@@" +
                "--@" +
                "@@@"
            );
        }
        public static LedMonitorChar digit6()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "@--" +
                "@@@" +
                "@-@" +
                "@@@"
            );
        }
        public static LedMonitorChar digit7()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "--@" +
                "-@-" +
                "@--" +
                "@--"
            );
        }
        public static LedMonitorChar digit8()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "@-@" +
                "@@@" +
                "@-@" +
                "@@@"
            );
        }
        public static LedMonitorChar digit9()
        {
            return new LedMonitorChar
            (
                3,
                "@@@" +
                "@-@" +
                "@@@" +
                "--@" +
                "@@@"
            );
        }
    }
}
