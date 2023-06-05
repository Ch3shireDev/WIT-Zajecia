using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmSer
{
    public partial class HarmSerMain : Form
    {
        BindingList<Node> list;
        private const uint threadcount = 4;
        private Abakus[] ab;
        public HarmSerMain()
        {
            InitializeComponent();
            list = new BindingList<Node>();
            Viewer.DataSource = list;
            ab = new Abakus[threadcount];
        }
        private void txtCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsDigit((char)e.KeyValue)) { }
            else if (e.KeyCode == Keys.Left) { }
            else if (e.KeyCode == Keys.Right) { }
            else if (e.KeyCode == Keys.Home) { }
            else if (e.KeyCode == Keys.End) { }
            else if (e.KeyCode == Keys.Back) { }
            else e.Handled = true;
        }
        private double Calculate(uint count)
        {
            double sum = 0;
            for(uint i=1;i<= count;++i) sum += 1.0 / i;
            return sum;
        }
        private void Add(Node node)
        {
            list.Add(node);
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            uint count;
            if (uint.TryParse(txtCount.Text, out count))
            {
                double total = 0;
                for (uint i = 0; i < threadcount; ++i) ab[i] = new Abakus(i, count, threadcount);
                for (uint i = 0; i < threadcount; ++i) ab[i].Start();
                for (uint i = 0; i < threadcount; ++i) total += ab[i].Join();
                Add(new Node(count, total));
            }
            txtCount.Focus();
            txtCount.SelectAll();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            uint count;
            if (uint.TryParse(txtCount.Text, out count))
            {
                double total = 0;
                for (uint i=1; i <= count; ++i) total += 1.0 / i;
                Add(new Node(count, total));
            }
            txtCount.Focus();
            txtCount.SelectAll();
        }
    }

    class Abakus
    {
        private uint i, count, step;
        private double sum;
        private Thread th;
        public Abakus(uint i, uint count, uint step)
        {
            this.i = i + 1;
            this.count = count;
            this.step = step;
            sum = 0;
            th = new Thread(calculate);
        }
        private void calculate()
        {
            for (; i <= count; i += step) sum += 1.0 / i;
        }
        public void Start()
        {
            th.Start();
        }
        public double Join()
        {
            th.Join();
            return sum;
        }
    }

    class Node
    {
        public uint Count { get; set; }
        public double Value { get; set; }
        public Node(uint Count, double Value)
        {
            this.Count = Count;
            this.Value = Value;
        }
    }
}
