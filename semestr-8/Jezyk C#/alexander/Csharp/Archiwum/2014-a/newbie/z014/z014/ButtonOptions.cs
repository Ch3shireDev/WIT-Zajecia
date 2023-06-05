using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z014
{
    public partial class ButtonOptions : Form
    {
        private Button Btn;
        public ButtonOptions(Button btn)
        {
            InitializeComponent();
            Btn = btn;
            EName.Text = Btn.Text;
            EName.ForeColor = Btn.ForeColor;
            EName.Font = Btn.Font;            
            BtnRemove.Visible = (Btn.Tag != null);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Btn.Dock = DockStyle.Top;
            Btn.UseVisualStyleBackColor = true;
            Btn.Text = EName.Text;
            Btn.ForeColor = EName.ForeColor;
            Btn.Font = EName.Font;
            Btn.Tag = true;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = EName.ForeColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                EName.ForeColor = dlgColor.Color;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = EName.Font;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                EName.Font = dlgFont.Font;
            }
        }
    }
}
