using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Mandelbroat
{
    public class Server : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _host;
        private int _port;
        public Server(string host, int port)
        {
            _host = host;
            _port = port;
        }
        private void Notify(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
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

        public override string ToString()
        {
            return _host+":"+_port.ToString();
        }
    }
}
