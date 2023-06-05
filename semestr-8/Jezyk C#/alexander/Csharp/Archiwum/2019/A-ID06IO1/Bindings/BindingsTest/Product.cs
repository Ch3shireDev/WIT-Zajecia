using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingsTest
{
    class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private double price;
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
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify("Price");
                }
            }
        }
        public Product(string Name, double Price)
        {
            name = Name;
            price = Price;
        }
        private void Notify(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public override string ToString()
        {
            return string.Format("{1:F2}: {0}", name, price);
        }
    }
}
