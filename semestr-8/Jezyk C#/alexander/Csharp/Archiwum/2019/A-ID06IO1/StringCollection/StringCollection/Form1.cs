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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Box.Items.Add(Input.Text);
            BtnRemove.Enabled = true;
            Input.SelectAll();
            Input.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int idx = Box.SelectedIndex;
            Box.Items.RemoveAt(idx);
            int cnt = Box.Items.Count;
            Box.SelectedIndex = Math.Min(cnt, idx) - 1;
            BtnRemove.Enabled = (cnt > 0);
            Box.Focus();
        }

        private void Box_DoubleClick(object sender, EventArgs e)
        {
            int idx = Box.SelectedIndex;
            if (idx >= 0) Input.Text = Box.Items[idx].ToString();
        }

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Box.Items.Count > 0) && (e.KeyData == Keys.Delete)) BtnRemove_Click(null, null);
        }
    }
}
