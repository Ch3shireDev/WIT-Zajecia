using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingTest
{
    class Food : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private double _price;

        public Food(string name, double price)
        {
            _name = name;
            _price = price;
        }

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

        public double price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify("price");
                }
            }
        }

        private void Notify(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return string.Format("{0}: {1:F2}", _name, _price);
        }
    }
}
