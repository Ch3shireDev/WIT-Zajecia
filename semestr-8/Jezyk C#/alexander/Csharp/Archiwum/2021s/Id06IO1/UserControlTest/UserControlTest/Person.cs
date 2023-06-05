using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace UserControlTest
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string givenname,surname;
        private Bitmap image=new Bitmap(1,1);

        public string Givenname
        {
            get { return givenname; }
            set
            {
                if (givenname != value)
                {
                    givenname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Givenname)));
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
