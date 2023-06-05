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
        private BindingList<Food> lst;
        public Form1()
        {
            InitializeComponent();
            lst = new BindingList<Food>();
            Box.DataSource = lst;
            lst.ListChanged += Lst_ListChanged;
            BtnAdd_Click(null, null);
        }

        private void Lst_ListChanged(object sender, ListChangedEventArgs e)
        {
            double sum = 0;
            foreach (Food food in lst) sum += food.value;
            sumValue.Text = string.Format("{0:0.00}", sum);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(test.ToString());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("Nowy", 0);
            lst.Add(food);
            Box.SelectedItem = food;
            Box_SelectedIndexChanged(null, null);
            foodName.SelectAll();
            foodName.Focus();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int at = Box.SelectedIndex;
            if (at >= 0)
            {
                Food food = (Food)Box.SelectedItem;
                lst.Remove(food);
                Box.SelectedItem = null;
                if (lst.Count == 0)
                {
                    BtnAdd.PerformClick();
                    return;
                }
                else if (at >= lst.Count) Box.SelectedIndex = at - 1;
                else Box.SelectedIndex = at;
                Box_SelectedIndexChanged(null, null);
            }
            Box.Focus();
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food food = (Food)Box.SelectedItem;
            foodName.DataBindings.Clear();
            foodValue.DataBindings.Clear();
            if (food != null)
            {
                foodName.ReadOnly = false;
                foodName.DataBindings.Add("text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodValue.ReadOnly = false;
                foodValue.DataBindings.Add("text", food, "value", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
            }
        }

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) BtnAdd.PerformClick();
            else if (e.KeyCode == Keys.Delete) BtnDel.PerformClick();
            else if (e.KeyCode == Keys.Return)
            {
                foodName.SelectAll();
                foodName.Focus();
            }
            else return;
            e.Handled = true;
        }

        private void edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) Box.Focus();
            else return;
            e.Handled = true;
        }

        private void Box_DoubleClick(object sender, EventArgs e)
        {
            foodName.SelectAll();
            foodName.Focus();
        }

    }

    public class Food : INotifyPropertyChanged
    {
        private string _name;
        private double _value;

        public event PropertyChangedEventHandler PropertyChanged;

        public Food(string name, double value)
        {
            _name = name;
            _value = value;
        }

        private void Notify(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    Notify("name");
                }
            }
        }

        public double value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value != _value)
                {
                    _value = value;
                    Notify("value");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}",_value) + "\t" + _name;
        }
    }
}
