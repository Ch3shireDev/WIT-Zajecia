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
        private BindingList<Product> BindList = new BindingList<Product>();
        public BindingTestForm()
        {
            InitializeComponent();
            EdList.DataSource = BindList;
            BindList.ListChanged += BindList_ListChanged;
        }
        private void BindList_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
        private void Bind(Product product)
        {
            EdTitle.DataBindings.Clear();
            EdPrice.DataBindings.Clear();
            if (product != null)
            {
                EdTitle.DataBindings.Add("Text", product, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
                EdPrice.DataBindings.Add("Text", product, "Price", true, DataSourceUpdateMode.OnPropertyChanged, "0", "F2");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Title = "Nowy";
            BindList.Add(product);
            EdList.SelectedItem = product;
        }

        private void EdList_SelectedValueChanged(object sender, EventArgs e)
        {
            Product product = (Product)EdList.SelectedItem;
            Bind(product);
        }
    }
}
