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
    public partial class BindingMainForm : Form
    {
        private BindingList<Product> list = new BindingList<Product>();
        public BindingMainForm()
        {
            InitializeComponent();
            list.ListChanged += List_ListChanged;
            LbBuyList.DataSource = list;
            BtnAppend_Click(this, null);
        }

        private void List_ListChanged(object sender, ListChangedEventArgs e)
        {
            double sum = 0;
            foreach(Product product in list)
            {
                sum += product.Amount;
            }
            TbSumAmount.Text = sum.ToString("F2");
        }

        private void BtnAppend_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            list.Add(product);
            LbBuyList.SelectedIndex = list.Count - 1;
        }

        private void LbBuyList_SelectedValueChanged(object sender, EventArgs e)
        {
            TbTitle.DataBindings.Clear();
            TbAmount.DataBindings.Clear();
            Product product = (Product)LbBuyList.SelectedItem;// as Product;
            if (product == null) return;
            TbTitle.DataBindings.Add(nameof(TbTitle.Text), product, nameof(product.Title), false, DataSourceUpdateMode.OnPropertyChanged);
            TbAmount.DataBindings.Add(nameof(TbAmount.Text), product, nameof(product.Amount), true, DataSourceUpdateMode.OnPropertyChanged, "0,00", "F2");
        }
    }
}
