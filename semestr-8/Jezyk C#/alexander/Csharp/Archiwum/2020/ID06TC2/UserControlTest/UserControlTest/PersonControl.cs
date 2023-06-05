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
        private event EventHandler picture_click;
        public PersonControl(EventHandler OnClick = null)
        {
            InitializeComponent();
            Bind(person);
            if (OnClick != null)
            {
                EdGivename.ReadOnly = true;
                EdSurname.ReadOnly = true;
                ImgPicture.DoubleClick -= ImgPicture_DoubleClick;
                picture_click += OnClick;
            }
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
            if(person != null)
            {
                EdGivename.DataBindings.Add("Text", person, "Givename", false, DataSourceUpdateMode.OnPropertyChanged);
                EdSurname.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.OnPropertyChanged);
                //ImgPicture.DataBindings.Add("Image", person, "Picture", false, DataSourceUpdateMode.OnPropertyChanged);
                ImgPicture.Image = person.Picture;
            }
        }

        private void ImgPicture_DoubleClick(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(DlgOpen.FileName);
                ImgPicture.Image = img;
                person.Picture = img;
            }
        }

        private void PersonControl_Resize(object sender, EventArgs e)
        {
            int H = ImgPicture.Height;
            int W = (int)Math.Round(H * 3.0 / 4) - ImgPicture.Width;
            PnlPicture.Width += W;
        }

        private void ImgPicture_Click(object sender, EventArgs e)
        {
            if (picture_click != null) picture_click(this, e);
        }
    }
}
