using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Binding
{
    public class Product : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string title;
        private decimal price;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    //Notify("Title");
                    Notify(nameof(Title));
                }
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify(nameof(Price));
                }
            }
        }
        private void Notify(string propertyName)
        {
            //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            Product product=new Product();
            product.title = title;
            product.price = price;
            return product;
        }
        public override string ToString()
        {
            return string.Format("{0:F2}\t{1}", price, title);
        }
    }
}
