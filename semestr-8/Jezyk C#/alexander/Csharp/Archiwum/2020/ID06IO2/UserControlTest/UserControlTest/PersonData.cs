using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class PersonData : UserControl
    {
        public PersonData()
        {
            InitializeComponent();
        }

        public string Surname
        {
            get { return EdSurname.Text; }
            set { EdSurname.Text = value; }
        }
        public string Givename
        {
            get { return EdName.Text; }
            set { EdName.Text = value; }
        }
        public Image Picture
        {
            get { return EdPicture.Image; }
            set 
            {
                EdPicture.Image = value;
                EdPicture.Invalidate();
            }
        }

        private void EdPicture_DoubleClick(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(DlgOpen.FileName);
                Picture = img;
            }
        }

        private void PersonData_Resize(object sender, EventArgs e)
        {
            int H = EdPicture.Height;
            int W = H * 3 / 4;
            EdPicture.Width = W;
            EdSurname.Left = W + 16;
            EdSurname.Width = Width - EdSurname.Left - 8;
            EdName.Left = W + 16;
            EdName.Width = Width - EdName.Left - 8;
        }
    }
}
