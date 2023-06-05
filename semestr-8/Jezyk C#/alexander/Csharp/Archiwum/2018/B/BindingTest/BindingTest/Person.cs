using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingTest
{
    class Person : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        public event PropertyChangedEventHandler PropertyChanged;
        public string firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                Notify("firstname");
            }
        }
        public string lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                Notify("lastname");
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
            return _firstname+" "+_lastname;
        }
    }
}
