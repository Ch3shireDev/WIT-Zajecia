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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button NewButton = new Button();
            NewButton.Text = "Nowy";
            ButtonOptions bo = new ButtonOptions(NewButton);
            if(bo.ShowDialog()==DialogResult.OK)
            {
                NewButton.Click += new EventHandler(NewButtonClick);
                Box.Controls.Add(NewButton);
            }
        }

        private void NewButtonClick(object sender, EventArgs e)
        {
            Button NewButton = (Button)sender;
            ButtonOptions bo = new ButtonOptions(NewButton);
            DialogResult ret = bo.ShowDialog();
            if (ret == DialogResult.No)
            {
                Box.Controls.Remove(NewButton);
            }
        }
    }
}
