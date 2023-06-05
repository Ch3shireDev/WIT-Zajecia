using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseForm
{
    public partial class PersonPanel : UserControl
    {
        public PersonPanel()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            picPhoto.Image = new Bitmap(@"P:\Barski\C#\A\UseForm\Person.jpg");
        }

        private void picPhoto_DoubleClick(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog()==DialogResult.OK)
            {
                picPhoto.Image = new Bitmap(dlgOpen.FileName);
            }
        }
    }
}
