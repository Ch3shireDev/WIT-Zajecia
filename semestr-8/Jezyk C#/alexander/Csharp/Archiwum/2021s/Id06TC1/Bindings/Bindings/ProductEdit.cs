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
    public partial class ProductEdit : Form
    {
        private Product product;
        private ProductEdit()
        {
            InitializeComponent();
        }
        public static DialogResult Execute(Product product)
        {
            ProductEdit pe = new ProductEdit();
            pe.Rebind(product);
            return pe.ShowDialog();
        }
        private void Rebind(Product product)
        {
            TxtPrice.DataBindings.Clear();
            TxtTitle.DataBindings.Clear();
            if (product != null)
            {
                this.product = product;
                TxtTitle.DataBindings.Add(nameof(TxtTitle.Text), product, nameof(product.Title), false, DataSourceUpdateMode.OnPropertyChanged);
                TxtPrice.DataBindings.Add(nameof(TxtPrice.Text), product, nameof(product.Price), true, DataSourceUpdateMode.OnPropertyChanged,string.Format("{0:F2}",0),"F2");
            }
        }
    }
}
