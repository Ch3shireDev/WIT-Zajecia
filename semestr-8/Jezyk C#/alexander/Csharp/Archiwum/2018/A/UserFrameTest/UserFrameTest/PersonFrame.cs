using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFrameTestSpace
{
    public partial class PersonFrame : UserControl
    {
        private Person person = null;
        public PersonFrame()
        {
            InitializeComponent();
        }

        private void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((e.PropertyName == "Face") && (person.Face != null)) 
            {
                FaceBox.Image = person.Face;
            }
        }

        public Person AnPerson
        {
            get { return person; }
            set
            {
                person = value;
                EdFirstname.DataBindings.Clear();
                EdLastname.DataBindings.Clear();
                if (person != null)
                {
                    person.PropertyChanged += Person_PropertyChanged;
                    EdFirstname.DataBindings.Add("Text", person, "Firstname", false, DataSourceUpdateMode.OnPropertyChanged);
                    EdLastname.DataBindings.Add("Text", person, "Lastname", false, DataSourceUpdateMode.OnPropertyChanged);
                    FaceBox.Image = person.Face;
                }
            }
        }
        public MouseEventHandler FaceClick
        {
            set
            {
                FaceBox.MouseClick += value;
            }
        }
        public MouseEventHandler FrameClick
        {
            set
            {
                this.MouseClick += value;
                FaceBox.MouseClick += value;
                Space.MouseClick += value;
                EdFirstname.MouseClick += value;
                EdLastname.MouseClick += value;
            }
        }
        public bool ReadOnly
        {
            get { return EdFirstname.ReadOnly && EdLastname.ReadOnly; }
            set
            {
                EdFirstname.ReadOnly = value;
                EdLastname.ReadOnly = value;
            }
        }
    }
}
