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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Input.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string txt = Input.Text.Trim();
            if (txt.Length > 0)
            {
                Box.Items.Add(txt);
                Box.SelectedIndex = Box.Items.Count - 1;
                BtnRemove.Enabled = true;
            }
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

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            if ((BtnRemove.Enabled) && (e.KeyData == Keys.Delete)) BtnRemove_Click(null, null);
        }

        private void Box_DoubleClick(object sender, EventArgs e)
        {
            Object obj = Box.SelectedItem;
            if (obj != null)
            {
                Input.Text = obj.ToString();
                Input.SelectAll();
                Input.Focus();
            }
        }
    }
}
