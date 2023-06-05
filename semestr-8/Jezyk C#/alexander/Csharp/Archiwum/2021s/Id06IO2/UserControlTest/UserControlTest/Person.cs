using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace UserControlTest
{
    public class Person:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name, surname;
        private Bitmap image;

        public string Name
        {
            get { return name; }
            set
            {
                if(name!=value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
                }
            }
        }
        public Bitmap Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
                }
            }
        }
    }
}
