using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.ss = "abc";
            //Data.sn = "";
            Data data = new DataX(form_callback);
            data.sn = "def";
            //data.ss = "";
            data.SN = "*";
            string x = data.SN;
            data.calculate();
        }

        private void form_callback(Data data)
        {

        }
    }

    public abstract class Data
    {
        public delegate void Callback(Data data);
        public string sn;
        public static string ss;
        protected Callback callback;
        public Data(Callback callback)
        {
            this.callback = callback;
        }
        public string SN { get { return sn; } set { sn = value; } }
        public int x { get; set; }
        public int y { get; private set; }

        public abstract double calculate();

        public void foo_n()
        {
            sn = "";
            ss = "";
            foo_s();
        }
        public static void foo_s()
        {
            ss = "";
            //sn = "";
            //foo_n();
        }
    }

    public class DataX : Data
    {
        public DataX(Callback callback) : base(callback)
        {
        }

        public override double calculate()
        {
            callback(this);
            return 0;
        }
    }
}
