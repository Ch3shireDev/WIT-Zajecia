using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binding
{
    public partial class BindingForm : Form
    {
        private BindingList<Product> list = new BindingList<Product>();
        public BindingForm()
        {
            InitializeComponent();
            LbPriceList.DataSource = list;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = null;
            if(new ProductEdit().Execute(ref product)==DialogResult.OK)
            {
                list.Add(product);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Product product = LbPriceList.SelectedItem as Product;
            Product save = new Product();
            save.Title = product.Title;
            save.Price = product.Price;
            if (new ProductEdit().Execute(ref product) != DialogResult.OK)
            {
                product.Title = save.Title;
                product.Price = save.Price;
            }
        }
    }
}
