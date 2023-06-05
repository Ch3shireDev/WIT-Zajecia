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
    public partial class BuilderForm : Form
    {
        private IdBuilder ib=new IdBuilder();
        public BuilderForm()
        {
            InitializeComponent();
            EdLog.Text=ib.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            long id;
            if(long.TryParse(EdId.Text,out id))
            {
                ib.Append(id);
                EdLog.Text=ib.ToString();
            }
        }

        private void EdDelimmetr_TextChanged(object sender, EventArgs e)
        {
            ib.SetDelimetr(EdDelimmetr.Text).SetIfEmpty(EdIfEmpty.Text);
            EdLog.Text=ib.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ib.Clear();
            EdLog.Text = ib.ToString();
        }
    }
}
