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
    public partial class ProductEdit : Form
    {
        private Product product;
        public ProductEdit(Product product)
        {
            InitializeComponent();
            ReBind(product);
        }
        public static DialogResult Execute(Product product)
        {
            return new ProductEdit(product).ShowDialog();
        }
        private void ReBind(Product product)
        {
            this.product = product;
            TxtTitle.DataBindings.Clear();
            TxtPrice.DataBindings.Clear();
            if (product != null) 
            {
                TxtTitle.DataBindings.Add(nameof(TxtTitle.Text), product, nameof(product.Title), false, DataSourceUpdateMode.OnPropertyChanged);
                TxtPrice.DataBindings.Add(nameof(TxtPrice.Text), product, nameof(product.Price), true, DataSourceUpdateMode.OnPropertyChanged,"0.00","F2");
            }
        }
    }
}
