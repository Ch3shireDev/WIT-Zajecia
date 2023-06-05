using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string title;
        private decimal price;

        public Product()
        {
        }
        public Product(Product product)
        {
            Restore(product);
        }
        public void Restore(Product product)
        {
            Title = product.title;
            Price = product.price;
        }
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
        public override string ToString()
        {
            return string.Format("{0,12:F2}\t{1}", price, title);
        }
    }
}
