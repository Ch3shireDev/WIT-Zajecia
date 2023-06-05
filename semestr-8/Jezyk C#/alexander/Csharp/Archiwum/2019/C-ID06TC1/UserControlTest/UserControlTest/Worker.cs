using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlTest 
{
    public class Worker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Bitmap photo = new Bitmap(1, 1);
        private string name, surname;

        public Worker()
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    notify("Name");
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
                    notify("Surname");
                }
            }
        }
        public Bitmap Photo
        {
            get { return photo; }
            set
            {
                if (photo != value)
                {
                    photo = value;
                    notify("Photo");
                }
            }
        }
        private void notify(string property)
        {
            PropertyChanged(this,new PropertyChangedEventArgs(property));
        }
    }
}
