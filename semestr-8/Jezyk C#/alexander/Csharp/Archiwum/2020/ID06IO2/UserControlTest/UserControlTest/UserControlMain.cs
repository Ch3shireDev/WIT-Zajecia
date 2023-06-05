using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class UserControlForm : Form
    {
        public UserControlForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PersonEdit pe = new PersonEdit();
            if(pe.ShowDialog()==DialogResult.OK)
            {
                PersonData pd = new PersonData();
                pd.Givename = pe.Givename;
                pd.Surname = pe.Surname;
                pd.Picture = pe.Picture;
                pd.Dock = DockStyle.Top;
                pd.Parent = EdList;
            }
        }
    }
}
