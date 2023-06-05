using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingTest
{
    internal class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double price;
        private string title;
        public double Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                price = value;
                Notify(nameof(Price));
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                Notify(nameof(Title));
            }
        }

        private void Notify(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            //if(PropertyChanged!=null) PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public override string ToString()
        {
            return string.Format("{0:F2}\t{1}", price, title);
        }
    }
}
