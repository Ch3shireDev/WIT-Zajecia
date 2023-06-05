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
        private Person person=null;
        public PersonControl()
        {
            InitializeComponent();
            PersonControl_Resize(null, null);
            BindPerson();
        }
        private void BindPerson()
        {
            EdGivename.DataBindings.Clear();
            EdSurname.DataBindings.Clear();
            ImgPicture.DataBindings.Clear();
            if (person != null) 
            {
                EdSurname.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.OnPropertyChanged);
                EdGivename.DataBindings.Add("Text", person, "Givename", false, DataSourceUpdateMode.OnPropertyChanged);
                ImgPicture.DataBindings.Add("Image", person, "Picture", true, DataSourceUpdateMode.OnPropertyChanged);
                //ImgPicture.Image = person.Picture;
            }
        }
        public Person Person
        {
            get { return person; }
            set 
            {
                person = value;
                BindPerson();
            }
        }

        private void ImgPicture_DoubleClick(object sender, EventArgs e)
        {
            if(DlgOpen.ShowDialog()==DialogResult.OK)
            {
                Image img=Image.FromFile(DlgOpen.FileName);
                //ImgPicture.Image = img;
                person.Picture = img;
            }
        }

        private void PersonControl_Resize(object sender, EventArgs e)
        {
            ImgPicture.Width = ImgPicture.Height * 3 / 4;
        }
    }
}
