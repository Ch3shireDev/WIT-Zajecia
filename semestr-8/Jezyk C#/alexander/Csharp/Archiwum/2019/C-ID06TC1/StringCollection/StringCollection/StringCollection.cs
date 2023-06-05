using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCollection
{
    public partial class StringCollection : Form
    {
        public StringCollection()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            BtnAdd.Enabled = (Input.Text.Trim().Length > 0);
        }

        private void StringCollection_Activated(object sender, EventArgs e)
        {
            Input.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Box.Items.Add(Input.Text.Trim());
            Box.SelectedIndex = Box.Items.Count - 1;
            BtnRemove.Enabled = true;
            Input.SelectAll();
            Input.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int pos = Box.SelectedIndex;
            Box.Items.RemoveAt(pos);
            int count = Box.Items.Count;
            Box.SelectedIndex = Math.Min(pos, count - 1);
            BtnRemove.Enabled = (count > 0);
            Box.Focus();
        }

        private void StringCollection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) BtnRemove.PerformClick();
        }
    }
}
