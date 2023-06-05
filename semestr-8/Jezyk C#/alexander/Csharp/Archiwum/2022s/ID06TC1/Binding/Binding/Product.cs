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
        private double amount;
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title))); // nameof(Title)=="Title"
            }
        }
        public double Amount
        {
            get { return amount; }
            set
            {
                if (amount == value) return;
                amount = value;
                if(PropertyChanged!=null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Amount))); // nameof(Amount)=="Amount"
            }
        }
        public override string ToString()
        {
            return string.Format("{0,8:F2}\t{1}",amount, title);
        }
    }
}
