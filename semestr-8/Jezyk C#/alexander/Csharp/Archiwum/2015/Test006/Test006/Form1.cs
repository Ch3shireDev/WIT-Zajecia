using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test006
{
    public partial class Form1 : Form
    {
        private BindingList<Food> lst = new BindingList<Food>();
        public Form1()
        {
            InitializeComponent();
            Box.DataSource = lst;
            BtnAdd_Click(null, null);
        }

        private void Box_SelectedValueChanged(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            if ((food != null) && (Box.Tag != food))
            {
                foodName.DataBindings.Clear();
                foodValue.DataBindings.Clear();
                foodName.DataBindings.Add("Text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodValue.DataBindings.Add("Text", food, "value", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
                foodName.ReadOnly = false;
                foodValue.ReadOnly = false;
                Box.Tag = food;
            }
            double sum=0;
            foreach (Food f in lst) sum += f.value;
            sumValue.Text = string.Format("{0:0.00}", sum);
        }

        private void foodName_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (!Box.Focused) Box.Focus();
            else if (!foodName.ReadOnly) foodName.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("New", 0);
            lst.Add(food);
            Box.SelectedItem = food;
            Box_SelectedValueChanged(null, null);
            foodName.SelectAll();
            foodName.Focus();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int at = Box.SelectedIndex;
            if (at>=0)
            {
                Food food = (Food)Box.SelectedItem;
                lst.Remove(food);
                if (Box.Items.Count >= at) --at;
                if (at >= 0) Box.SelectedIndex = at;
                else
                {
                    foodName.ReadOnly = true;
                    foodValue.ReadOnly = true;
                    foodName.Clear();
                    foodValue.Clear();
                }
                Box_SelectedValueChanged(null, null);
            }
            Box.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Insert)
            {
                BtnAdd_Click(null, null);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                BtnDel_Click(null, null);
                e.Handled = true;
            }
        }
    }

    public class Food : INotifyPropertyChanged
    {
        private string _name;
        private double _value;
        public string name { get { return _name; } set { _name = value; OnPropertyChanged(); } }
        public double value { get { return _value; } set { _value = value; OnPropertyChanged(); } }
        public string show { get { return string.Format("{0}\t{1:0.00}", name, value); } }
        public Food(string name, double value) { this.name = name; this.value = value; }
        public override string ToString() { return show; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged()
        {
            PropertyChangedEventHandler tmp = PropertyChanged;
            if (tmp != null) tmp(this, new PropertyChangedEventArgs("show"));
        }
    }
}
