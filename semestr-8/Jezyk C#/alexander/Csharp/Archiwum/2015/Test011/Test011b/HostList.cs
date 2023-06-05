using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test011
{
    public partial class HostList : Form
    {
        public HostList()
        {
            InitializeComponent();
        }

        public static void Execute(ref string hoststr)
        {
            HostList frm = new HostList();
            frm.Hosts.Text = hoststr.Replace("\n", "\r\n");
            if(frm.ShowDialog()==DialogResult.OK)
            {
                hoststr = frm.Hosts.Text.Replace("\r\n","\n");
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
