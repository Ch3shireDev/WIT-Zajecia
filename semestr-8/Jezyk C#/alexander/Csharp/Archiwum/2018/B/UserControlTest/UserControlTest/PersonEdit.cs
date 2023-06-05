using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTestNamespace
{
    public partial class PersonEdit : Form
    {
        public PersonEdit(Person person)
        {
            InitializeComponent();
            Frame.AnPerson = person;
            Frame.ReadOnly = false;
            Frame.FaceClick += Frame_Click;
        }

        private void Frame_Click(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                Frame.Face = new Bitmap(DlgOpen.FileName);
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {

        }

        private void BtnResign_Click(object sender, EventArgs e)
        {

        }
    }
}
