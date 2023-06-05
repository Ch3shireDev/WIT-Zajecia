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
            list.ListChanged += List_ListChanged;
        }

        private void List_ListChanged(object sender, ListChangedEventArgs e)
        {
            decimal sum = 0;
            foreach (Product product in list) sum += product.Price;
            TxtTotal.Text = string.Format("{0:F2}", sum);
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
            Product save = product.Clone() as Product;
            if (ProductEdit.Execute(product) != DialogResult.OK)
            {
                product.Title = save.Title;
                product.Price = save.Price;
            }
        }
    }
}
