using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlTest
{
    public class Worker:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name, surname;
        private Bitmap picture = new Bitmap(200, 250);
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    Notify("Name");
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
                    Notify("Surname");
                }
            }
        }
        public Bitmap Picture
        {
            get { return picture; }
            set
            {
                Graphics.FromImage(picture).DrawImage(value, 0, 0, 200, 250);
                Notify("Picture");
            }
        }
        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
