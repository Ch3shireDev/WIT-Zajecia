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

namespace Test002
{
    public partial class Form1 : Form
    {
        delegate void DelegateMain();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(threadmain)).Start();
        }

        private void threadmain()
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                Invoke(new DelegateMain(main));
                //main();
            }
        }

        private void main()
        {
            progressBar1.Value = progressBar1.Value + 1;
        }

    }
}
