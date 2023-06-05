using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Mandelbroat
{
    class ServerNode : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _host;
        private int _port;
        public ServerNode(string host, int port)
        {
            _host = host;
            _port = port;
        }
        public string host
        {
            get { return _host; }
            set
            {
                if (_host != value)
                {
                    _host = value;
                    Notify("host");
                }
            }
        }
        public int port
        {
            get { return _port; }
            set
            {
                if (_port != value)
                {
                    _port = value;
                    Notify("port");
                }
            }
        }
        private void Notify(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }
    }
}
