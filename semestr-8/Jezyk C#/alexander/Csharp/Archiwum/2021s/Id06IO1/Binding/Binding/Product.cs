using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Binding
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string title;
        private double price;
        public string Title
        {
            get { return title; }
            set
            {
                if(title!=value)
                {
                    //Notify("Info"); => Notify("Title");
                    title = value;
                    Notify(nameof(Title));
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
                    //Notify("Price");
                    price = value;
                    Notify(nameof(Price));
                }
            }
        }
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return string.Format("{0:F2}\t{1}", price, title);
        }
    }
}
