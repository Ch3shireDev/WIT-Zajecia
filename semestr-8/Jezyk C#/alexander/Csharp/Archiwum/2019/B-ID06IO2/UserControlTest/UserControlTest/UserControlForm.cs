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
            WorkerControl row = sender as WorkerControl;
            WorkerEditor we = new WorkerEditor();
            we.Person = row.Person;
            we.ShowDialog(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Worker person = new Worker();
            WorkerControl row = new WorkerControl();
            row.DblClick += WorkerControl_Click;
            row.ReadOnly = true;
            row.Person = person;
            row.Location = new Point(0, Client.Height + 1);
            row.Dock = DockStyle.Top;
            Client.Controls.Add(row);
            WorkerEditor we = new WorkerEditor();
            we.Person = person;
            if (we.ShowDialog(this) != DialogResult.OK)
            {
                Client.Controls.Remove(row);
            }
        }
    }
}
