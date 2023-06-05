using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingTest
{
    public partial class BindingTestForm : Form
    {
        private BindingList<Product> bind = new BindingList<Product>();
        public BindingTestForm()
        {
            InitializeComponent();
            EdList.DataSource = bind;
            EdList.SelectedIndex = -1;
            bind.ListChanged += EdList_ListChanged;
        }
        private void EdList_ListChanged(object source, ListChangedEventArgs arg)
        {
            
        }
        private void Bind(Product product)
        {
            EdTitle.DataBindings.Clear();
            EdPrice.DataBindings.Clear();
            if (product!=null)
            {
                EdTitle.DataBindings.Add("Text", product, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
                EdPrice.DataBindings.Add("Text", product, "Price", true, DataSourceUpdateMode.OnPropertyChanged, "0", "F2");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Title = "Nowy";
            bind.Add(product);
            EdList.SelectedItem = product;
        }

        private void EdList_SelectedValueChanged(object sender, EventArgs e)
        {
            Product product = (Product)EdList.SelectedItem;
            Bind(product);
        }        
    }
}
