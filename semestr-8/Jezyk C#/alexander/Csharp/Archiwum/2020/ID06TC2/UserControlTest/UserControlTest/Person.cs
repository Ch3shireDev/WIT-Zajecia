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
        private string surname;
        private string givename;
        private Image picture;

        public string Surname
        {
            //get => surname;
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    Notify("Surname");
                    //Notify(nameof(this.Surname));
                }
            }
        }
        public string Givename
        {
            //get => surname;
            get { return givename; }
            set
            {
                if (givename != value)
                {
                    givename = value;
                    Notify("Givename");
                    //Notify(nameof(this.Givename));
                }
            }
        }
        public Image Picture
        {
            //get => surname;
            get { return picture; }
            set
            {
                if (picture != value)
                {
                    picture = value;
                    Notify("Picture");
                    //Notify(nameof(this.Picture));
                }
            }
        }
        private void Notify(string propertyName)
        {
            //PropertyChanged?.(this, new PropertyChangedEventArgs(propertyName));
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
