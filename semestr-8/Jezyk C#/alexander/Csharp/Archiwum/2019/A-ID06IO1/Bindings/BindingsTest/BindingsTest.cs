using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingsTest
{
    public partial class BindingsTest : Form
    {
        private BindingList<Product> list = new BindingList<Product>();
        public BindingsTest()
        {
            InitializeComponent();
            ProductList.DataSource = list;
            list.ListChanged += Products_ListChanged;
        }

        private void Products_ListChanged(object sender, ListChangedEventArgs e)
        {
            bool enabled = (list.Count > 0);
            EdName.Enabled = enabled;
            EdPrice.Enabled = enabled;
            double sum=0;
            foreach (Product p in list) sum += p.Price;
            EdSum.Text = string.Format("{0:F2}", sum);
        }

        private void BindData(Product p)
        {
            EdName.DataBindings.Clear();
            EdPrice.DataBindings.Clear();
            if (p != null)
            {
                EdName.DataBindings.Add("Text", p, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
                EdPrice.DataBindings.Add("Text", p, "Price", true, DataSourceUpdateMode.OnPropertyChanged, null, "F2");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProductList.SelectedIndex = -1;
            Product p = new Product("---", 0);
            list.Add(p);
            ProductList.SelectedIndex = ProductList.Items.IndexOf(p);
            EdName.Focus();
            EdName.SelectAll();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int pos = ProductList.SelectedIndex;
            Product p = (Product)ProductList.SelectedValue;
            list.Remove(p);
            ProductList.SelectedIndex = Math.Min(pos,ProductList.Items.Count - 1);
            if(ProductList.SelectedIndex<0)
            {
                EdName.Clear();
                EdPrice.Clear();
            }
            ProductList.Focus();
        }

        private void PersonList_SelectedValueChanged(object sender, EventArgs e)
        {
            Product p = (Product)ProductList.SelectedValue;
            BindData(p);
        }

        private void BindingsTest_Load(object sender, EventArgs e)
        {
            BtnIns.PerformClick();
        }

        private void BindingsTest_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if (e.KeyData == Keys.Delete) BtnDel.PerformClick();
                else if (e.KeyData == Keys.Insert) BtnIns.PerformClick();
            }
        }
    }
}
