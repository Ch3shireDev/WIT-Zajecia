using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test007
{
    public partial class HarmForm : Form
    {
        private uint N;
        private BindingList<HarmThread> Lst = new BindingList<HarmThread>();

        public HarmForm()
        {
            InitializeComponent();
            Count.Text = "1000000000";
            List.DataSource = Lst;
            List.DisplayMember = "show";
        }

        private void Count_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = uint.TryParse(Count.Text, out N);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            HarmThread h=new HarmThread(this, N);
            Lst.Add(h);
            List.SelectedItem = h;
            Count.SelectAll();
            Count.Focus();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int p = List.SelectedIndex;
            HarmThread h = (HarmThread)List.SelectedItem;
            h.Abort();
            Lst.Remove(h);
            if (p >= List.Items.Count) --p;
            if (p >= 0) List.SelectedIndex = p;
            List.Focus();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnDel.Enabled = (List.SelectedIndex >= 0);
        }

        private void HarmForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (BtnDel.Enabled) BtnDel_Click(BtnDel, null);
                e.Handled = true;
            }
        }
    }

    class HarmThread : INotifyPropertyChanged
    {
        private uint N;
        private ISynchronizeInvoke frm;
        private Thread th;

        public HarmThread(ISynchronizeInvoke frm, uint N)
        {
            this.frm = frm;
            this.N = N;
            show = string.Format("{0}\t{1}", N, "Calculated");
            th = new Thread(work);
            th.Start();
        }

        private void work()
        {
            show = string.Format("{0}\t{1}", N, sum(N));
            frm.Invoke(new MethodInvoker(OnPropertyChanged), null);
        }

        private double sum(uint N)
        {
            double s = 0;
            for (uint i = 1; i <= N; ++i) s += 1.0 / i;
            return s;
        }

        public void Abort()
        {
            th.Abort();
        }

        public string show { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged()
        {
            PropertyChangedEventHandler tmp = PropertyChanged;
            if (tmp != null) tmp(this, new PropertyChangedEventArgs("show"));
        }
    }
}
