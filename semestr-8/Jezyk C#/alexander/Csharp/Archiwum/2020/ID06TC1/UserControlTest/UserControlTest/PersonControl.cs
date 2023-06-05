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
        private Person person = new Person();
        public PersonControl()
        {
            InitializeComponent();
            PersonControl_Resize(null, null);
            Bind(person);
        }
        public Person Person
        {
            get { return person; }
            set
            {
                person = value;
                Bind(person);
            }
        }
        private void Bind(Person person)
        {
            EdGivename.DataBindings.Clear();
            EdSurname.DataBindings.Clear();
            ImgPicture.DataBindings.Clear();
            if (person != null) 
            {
                EdGivename.DataBindings.Add("Text", person, "Givename", false, DataSourceUpdateMode.OnPropertyChanged);
                EdSurname.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.OnPropertyChanged);
                ImgPicture.Image = person.Picture;
                //ImgPicture.DataBindings.Add("Image", person, "Picture", false, DataSourceUpdateMode.OnPropertyChanged);
                //nameof(person.Picture) - dla nowszysch VS
            }
        }

        private void PersonControl_Resize(object sender, EventArgs e)
        {
            int H = ImgPicture.Height;
            int W = (int)Math.Round((double)(H * 3 / 4.0))-ImgPicture.Width;
            PnlImage.Width += W;
        }

        private void ImgPicture_DoubleClick(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                ImgPicture.Image = Image.FromFile(DlgOpen.FileName);
                person.Picture = ImgPicture.Image;
            }
        }
    }
}
