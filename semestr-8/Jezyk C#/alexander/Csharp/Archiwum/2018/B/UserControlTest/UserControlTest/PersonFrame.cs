using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTestNamespace
{
    public partial class PersonFrame : UserControl
    {
        private Person person;
        public event EventHandler FrameDoubleClick;
        public event EventHandler FaceClick;
        public PersonFrame()
        {
            InitializeComponent();            
        }
        public Person AnPerson
        {
            get { return person; }
            set
            {
                person = value;
                ImgFace.DataBindings.Clear();
                Firstname.DataBindings.Clear();
                Lastname.DataBindings.Clear();
                if (person != null)
                {
                    ImgFace.DataBindings.Add("Image", person, "Face", false, DataSourceUpdateMode.OnPropertyChanged);
                    Firstname.DataBindings.Add("Text", person, "Firstname", false, DataSourceUpdateMode.OnPropertyChanged);
                    Lastname.DataBindings.Add("Text", person, "Lastname", false, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }
        public bool ReadOnly
        {
            get { return Firstname.ReadOnly && Lastname.ReadOnly;  }
            set
            {
                Firstname.ReadOnly = value;
                Lastname.ReadOnly = value;
            }
        }
        public Image Face
        {
            get { return person.Face; }
            set
            {
                person.Face = value;
                ImgFace.Image = value;
            }
        }
        private void Face_Click(object sender, EventArgs e)
        {
            FaceClick?.Invoke(this, e);
        }
        private void Frame_DoubleClick(object sender, EventArgs e)
        {
            FrameDoubleClick?.Invoke(this, e);
        }
    }
}
