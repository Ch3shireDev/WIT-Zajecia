using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bindings
{
    public partial class PriceList : Form
    {
        private BindingList<Product> list = new BindingList<Product>();
        public PriceList()
        {
            InitializeComponent();
            LbPriceList.DataSource = list;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            list.Add(product);
            if(ProductEdit.Execute(product)!=DialogResult.OK)
            {
                list.Remove(product);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Product product = LbPriceList.SelectedItem as Product;
            Product save = new Product(product);
            if (ProductEdit.Execute(product) != DialogResult.OK)
            {
                product.Restore(save);
            }
        }
    }
}
