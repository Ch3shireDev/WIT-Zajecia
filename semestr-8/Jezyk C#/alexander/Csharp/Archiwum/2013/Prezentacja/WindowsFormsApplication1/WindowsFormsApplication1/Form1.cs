using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        delegate void RearrangeProgressBarsHandler();
        delegate void NewListBoxHandler(HarmonicThread ht);
        delegate void SetProgressBarValueHandler(HarmonicThread ht);

        public Form1()
        {
            InitializeComponent();
        }

        public void ThreadRearrange()
        {
            Invoke(new RearrangeProgressBarsHandler(RearrangeProgressBar));
        }

        public void RearrangeProgressBar()
        {
            Int32 separator;

            separator = 25;

            foreach (ProgressBar item in this.panel1.Controls.OfType<ProgressBar>().AsQueryable())
            {
                item.Top = separator;
                separator = separator + item.Height;
            }
        }

        public void SetProgressBarValue(HarmonicThread ht)
        {
            ht.getPBar().Value = ht.progress;
        }

        public void SetProgressBarValueThread(HarmonicThread ht)
        {
            Invoke(new SetProgressBarValueHandler(SetProgressBarValue), ht);
        }

        public void NewListBox(HarmonicThread ht)
        {
            listBox1.Items.Add(ht.getCount().ToString() + '\t' + ht.GetResult().ToString());
            RearrangeProgressBar();
            panel1.Controls.Remove(ht.getPBar());
        }

        public void NewListBoxThread(HarmonicThread ht)
        {
            Invoke(new NewListBoxHandler(NewListBox), ht);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HarmonicBackgroundWorker(Int32.Parse(textBox1.Text), this);
            ThreadRearrange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HarmonicThread(Int32.Parse(textBox1.Text), this).StartThread();
            ThreadRearrange();
        }
    }
}
