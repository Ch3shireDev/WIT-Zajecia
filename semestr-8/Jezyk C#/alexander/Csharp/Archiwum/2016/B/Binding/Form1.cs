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
    public partial class FoodForm : Form
    {
        BindingList<Food> lst;
        public FoodForm()
        {
            InitializeComponent();
            lst = new BindingList<Food>();
            Box.DataSource = lst;
            lst.ListChanged += Lst_ListChanged;
        }

        private void Lst_ListChanged(object sender, ListChangedEventArgs e)
        {
            double sum=0;
            foreach (Food food in lst) sum += food.value;
            sumValue.Text= string.Format("{0,0:0.00}", sum);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("Nowy", 0);
            lst.Add(food);
            Box.SelectedItem = null;
            Box.SelectedItem = food;
            foodName.Focus();
            foodName.SelectAll();
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            if (food == null) return;
            lst.Remove(food);
            if (lst.Count > 0) Box.SelectedItem = lst[0];
            else Box.SelectedItem = null;
            Box.Focus();
        }
        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            foodName.DataBindings.Clear();
            foodValue.DataBindings.Clear();
            if (food == null)
            {
                foodName.Clear();
                foodValue.Clear();
                foodName.ReadOnly = foodValue.ReadOnly = true;
            }
            else
            {
                foodName.DataBindings.Add("Text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodValue.DataBindings.Add("Text", food, "value", true, DataSourceUpdateMode.OnValidation, null, "0.00");
                foodName.ReadOnly = foodValue.ReadOnly = false;
            }
        }
        private void FoodForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) BtnAdd.PerformClick();
            else if((e.KeyCode == Keys.Delete)&&(e.Control)) BtnDel.PerformClick();
        }

        private void foodValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Box.Focus();
        }
    }

    class Food : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private double _value;
        public Food(string name, double value)
        {
            _name = name;
            _value = value;
        }
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }
        public double value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value");
            }
        }
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler tmp = PropertyChanged;
            if (tmp != null) tmp(this, new PropertyChangedEventArgs(name));
        }
        public override string ToString()
        {
            return string.Format("{0,9:0.00}\t{1}", _value, _name);
        }
    }
}
