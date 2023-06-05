using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace UserControlTest
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name, _phone;
        private Bitmap _photo;
        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    Notify("name");
                }
            }
        }
        public string phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    Notify("phone");
                }
            }
        }
        public Bitmap photo
        {
            get { return _photo; }
            set
            {
                if (_photo != value)
                {
                    _photo = value;
                    Notify("photo");
                }
            }
        }
        public void Notify(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
