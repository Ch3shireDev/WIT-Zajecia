using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        private IdBuilder ib=new IdBuilder();
        public Form1()
        {
            InitializeComponent();
            textLog.Text=ib.ToString();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            long id;
            if(long.TryParse(textId.Text,out id))
            {
                ib.Append(id);
                textLog.Text=ib.ToString();
            }
        }

        private void textDelimetrIfEmpty_TextChanged(object sender, EventArgs e)
        {
            ib.SetDelimetr(textDelimetr.Text).SetIfEmpty(textIfEmpty.Text);
            textLog.Text=ib.ToString();
        }
    }
}
