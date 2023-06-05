using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace UserFrameTestSpace
{
    public class Person : INotifyPropertyChanged
    {
        private string firstname, lastname;
        private Bitmap face;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    Notify("Firstname");
                }
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    Notify("Lastname");
                }
            }
        }
        public Bitmap Face
        {
            get { return face != null?(Bitmap)face.Clone():null; }
            set
            {
                face = value != null ? (Bitmap)value.Clone() : value;
                Notify("Face");
            }
        }
        private void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
