using System;
using System.Windows.Forms;

namespace Builder
{
    public partial class IdBuilderTest : Form
    {
        private long id;
        private IdListBuilder ib = new IdListBuilder("-");
        public IdBuilderTest()
        {
            InitializeComponent();
            id = 0;
            ActiveControl = EdId;
        }
        private void BackToEdit()
        {
            EdId.SelectAll();
            EdId.Focus();
        }
        private void EdId_TextChanged(object sender, EventArgs e)
        {
            BtnAdd.Enabled = long.TryParse(EdId.Text, out id);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ib.Append(id);
            BackToEdit();
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            EdInfo.AppendText(ib.ToString() + Environment.NewLine);
            BackToEdit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ib.Clear();
            BackToEdit();
        }
    }
}
