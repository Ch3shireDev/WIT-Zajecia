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
    public partial class PersonControl : UserControl
    {
        private Person person;
        public PersonControl()
        {
            InitializeComponent();
        }

        public void BindPerson(Person person)
        {
            this.person = person;
            EdSurname.DataBindings.Add("Text", person, "surname", false, DataSourceUpdateMode.OnPropertyChanged);
            EdName.DataBindings.Add("Text", person, "name", false, DataSourceUpdateMode.OnPropertyChanged);
            //Image.DataBindings.Add("Image", person, "photo", false, DataSourceUpdateMode.OnPropertyChanged);
            Image.Image = person.photo;
        }

        private void Image_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open photo ...";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    person.photo = new Bitmap(dlg.FileName);
                    Image.Image = person.photo;
                }
            }
        }
    }
}
