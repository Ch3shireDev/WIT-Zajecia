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
    public partial class BuilderTest : Form
    {
        private IdBuilder ib = new IdBuilder();
        private long idvalue=0;
        public BuilderTest()
        {
            InitializeComponent();
            ActiveControl=EdIdValue;
        }
        private void BackToEdit()
        {
            EdIdValue.SelectAll();
            EdIdValue.Focus();
        }
        private void EdIdValue_TextChanged(object sender, EventArgs e)
        {
            BtnAdd.Enabled = long.TryParse(EdIdValue.Text, out idvalue);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ib.Add(idvalue);
            BackToEdit();
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            Log.AppendText(ib.ToString() + Environment.NewLine);
            BackToEdit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ib.Clear();
            BackToEdit();
        }
    }
}
