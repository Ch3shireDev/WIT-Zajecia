using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UserControlTestNamespace
{
    public class Person: INotifyPropertyChanged
    {
        private string firstname, lastname;
        private Image face;
        public event PropertyChangedEventHandler PropertyChanged;
        public Person()
        {
            firstname = "";
            lastname = "";
            face = new Bitmap(1,1);
        }
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
        private static Image BmpClone(Image bmp)
        {
            return bmp;
            //return bmp != null ? (Image)bmp.Clone() : null;
        }
        public Image Face
        {
            get { return BmpClone(face); }
            set
            {
                face = BmpClone(value);
                Notify("Face");
            }
        }
        private void Notify(string PropName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropName));
        }
    }
}
