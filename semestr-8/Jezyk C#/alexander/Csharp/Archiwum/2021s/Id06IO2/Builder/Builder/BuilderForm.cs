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
        private IdBuilder idb=new IdBuilder();
        public BuilderForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            long id;
            if(long.TryParse(EdId.Text, out id))
            {
                idb.Append(id);
            }
            EdLog.Text=idb.ToString();
        }

        private void EdDelimeter_TextChanged(object sender, EventArgs e)
        {
            idb.SetDelimeter(EdDelimeter.Text);
            EdLog.Text = idb.ToString();
        }

        private void EdIfEmpty_TextChanged(object sender, EventArgs e)
        {
            idb.SetIfEmpty(EdIfEmpty.Text);
            EdLog.Text = idb.ToString();
        }
    }
}
