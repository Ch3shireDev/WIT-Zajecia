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
            LstServers.DataSource = list;
        }

        private void LstServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server server  = (Server)LstServers.SelectedItem;
            EdHost.DataBindings.Clear();
            EdPort.DataBindings.Clear();
            if (server != null)
            {
                EdHost.DataBindings.Add(new Binding("Text", server, "host", false, DataSourceUpdateMode.OnPropertyChanged));
                EdPort.DataBindings.Add(new Binding("Text", server, "port", false, DataSourceUpdateMode.OnPropertyChanged));
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            list.Add(new Server("localhost", MandelbroatForm.defaultPort));
            EdHost.SelectAll();
            EdHost.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Server server = (Server)LstServers.SelectedItem;
            if (server != null) list.Remove(server);
            LstServers.Focus();
        }
    }
}
