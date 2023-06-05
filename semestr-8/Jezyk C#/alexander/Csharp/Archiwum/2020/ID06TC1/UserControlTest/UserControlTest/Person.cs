using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UserControlTest
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string surname;
        private string givename;
        private Image picture;

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
        public string Givename
        {
            get { return givename; }
            set 
            {
                if (givename != value)
                {
                    givename = value;
                    Notify("Givename");
                }
            }
        }
        public Image Picture
        {
            get { return picture; }
            set
            {
                if (picture != value)
                {
                    picture = value;
                    //Notify("Picture");
                }
            }
        }
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
