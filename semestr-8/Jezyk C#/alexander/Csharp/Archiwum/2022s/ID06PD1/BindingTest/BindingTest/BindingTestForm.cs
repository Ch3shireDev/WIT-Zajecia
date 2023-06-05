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
        private BindingList<Product> Products = new BindingList<Product>();
        public BindingTestForm()
        {
            InitializeComponent();
            LbProducts.DataSource = Products;
            Products.ListChanged += BindList_ListChanged;
        }

        private int count = 0;
        private void BindList_ListChanged(object Owner, ListChangedEventArgs ev)
        {
            TbTotal.Text = (++count).ToString();
        }

        private void Bind(Product product)
        {
            TbPrice.DataBindings.Clear();
            TbTitle.DataBindings.Clear();
            if (product == null) return;
            TbTitle.DataBindings.Add(nameof(TbTitle.Text), product, nameof(product.Title), false, DataSourceUpdateMode.OnPropertyChanged);
            TbPrice.DataBindings.Add(nameof(TbPrice.Text), product, nameof(product.Price), true, DataSourceUpdateMode.OnPropertyChanged, "0", "F2");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Title = "Nowy";
            Products.Add(product);
            LbProducts.SelectedItem = product;
        }

        private void LbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            Bind((Product)LbProducts.SelectedItem);
        }
    }
}
