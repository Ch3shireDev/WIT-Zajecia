using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingsTest
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstname, _lastname;
        public string firstname
        {
            get { return _firstname; }
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    Notify("firstname");
                }
            }
        }
        public string lastname
        {
            get { return _lastname; }
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    Notify("firstname");
                }
            }
        }
        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }
        private void Notify(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }
    }
}
