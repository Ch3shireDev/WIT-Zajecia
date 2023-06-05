using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseForm
{
    public partial class UseForm : Form
    {
        public UseForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonPanel row = new PersonPanel();
            pBox.SuspendLayout();
            pBox.Controls.Add(row);
            pBox.ResumeLayout(false);
            pBox.PerformLayout();
        }
    }
}
