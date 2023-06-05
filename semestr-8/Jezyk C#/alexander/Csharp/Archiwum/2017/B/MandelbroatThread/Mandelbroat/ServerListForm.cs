using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbroat
{
    public partial class ServerListForm : Form
    {
        private BindingList<Server> list;
        public ServerListForm(BindingList<Server> list)
        {
            InitializeComponent();
            this.list = list;
        }
    }
}
