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
    public partial class BindingTestMain : Form
    {
        private BindingList<Food> lst=new BindingList<Food>();
        
        public BindingTestMain()
        {
            InitializeComponent();
            Box.DataSource = lst;
            lst.ListChanged += Lst_Changed;
        }

        private void Lst_Changed(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (var food in lst) sum += food.price;
            sumValue.Text = string.Format("{0:F2}", sum);
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            bool ro = (food == null);
            foodName.ReadOnly = ro;
            foodValue.ReadOnly = ro;
            foodName.DataBindings.Clear();
            foodValue.DataBindings.Clear();
            if (!ro)
            {
                foodName.DataBindings.Add("Text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodValue.DataBindings.Add("Text", food, "price", true, DataSourceUpdateMode.OnPropertyChanged, "0.00");
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            lst.Remove(food);
            food = (Food)Box.SelectedItem;
            Box.SelectedItem = null;
            Box.SelectedItem = food;
            Box.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("Nowy", 0);
            lst.Add(food);
            Box.SelectedItem = null;
            Box.SelectedItem = food;
            foodName.SelectAll();
            foodName.Focus();
        }

        private void BindingTestMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Insert) BtnAdd.PerformClick();
                else if (e.KeyCode == Keys.Delete) BtnDel.PerformClick();
            }
        }
    }
}
