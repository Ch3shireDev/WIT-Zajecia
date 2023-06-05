using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class UserControlForm : Form
    {
        public UserControlForm()
        {
            InitializeComponent();
        }

        private void WorkerControl_Click(object sender, EventArgs e)
        {
            WorkerEdit we = new WorkerEdit();
            we.worker = sender as Worker;
            we.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            WorkerControl wc = new WorkerControl();
            wc.worker = worker;
            wc.Dock = DockStyle.Top;
            wc.readOnly = true;
            wc.EditCall += WorkerControl_Click;
            ScrollBox.Controls.Add(wc);
            wc.Top = ScrollBox.Height + 1;
            WorkerEdit we = new WorkerEdit();
            we.worker = worker;
            if(we.ShowDialog() != DialogResult.OK)
            {
                ScrollBox.Controls.Remove(wc);
            }
        }
    }
}
