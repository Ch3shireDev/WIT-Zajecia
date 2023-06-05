using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace UserControlEmploee
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name, surname;
        private Bitmap image = new Bitmap(1,1);
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname == value) return;
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }
        public Bitmap Image
        {
            get { return image; }
            set
            {
                if (image.GetHashCode() == value.GetHashCode()) return;
                image = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
            }
        }
    }
}
