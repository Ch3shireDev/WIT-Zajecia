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
    public partial class BindingForm : Form
    {
        private BindingList<Food> lst;
        public BindingForm()
        {
            InitializeComponent();
            lst = new BindingList<Food>();
            Box.DataSource = lst;
            lst.ListChanged += Lst_ListChanged;
        }
        private void Lst_ListChanged(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (var food in lst) sum += food.price;
            sumValue.Text = string.Format("{0:F2}", sum);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("nazwa", 0);
            lst.Add(food);
            Box.SelectedItem = null;
            Box.SelectedItem = food;
            foodName.SelectAll();
            foodName.Focus();
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            foodName.DataBindings.Clear();
            foodValue.DataBindings.Clear();
            bool bad = (food == null);
            foodName.ReadOnly = bad;
            foodValue.ReadOnly = bad;
            if (!bad)
            {
                foodName.DataBindings.Add("Text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodValue.DataBindings.Add("Text", food, "price", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            lst.Remove(food);
            food = (Food)Box.SelectedItem;
            Box.SelectedItem = null;
            Box.SelectedItem = food;
            if (food == null)
            {
                foodName.Clear();
                foodValue.Clear();
            }
        }

        private void foodName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
