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
    public partial class BindingLinq : Form
    {
        private List<Food> lst;
        public BindingLinq()
        {
            InitializeComponent();
            lst = new List<Food>();
            lst.Add(new Food("A", 10, 100));
            lst.Add(new Food("B", 15, 100));
            lst.Add(new Food("C", 20, 100));
            lst.Add(new Food("D", 25, 100));
            lst.Add(new Food("E", 30, 100));
            lst.Add(new Food("F", 35, 100));
            BindList(lst);
            //BtnAdd_Click(null, null);
        }
        private void BindList(IEnumerable<Food> forshow)
        {
            BindingList<Food> tmp = new BindingList<Food>(forshow.ToList());
            tmp.ListChanged += Lst_ListChanged;
            Box.DataSource = tmp;
        }

        private void Lst_ListChanged(object sender, ListChangedEventArgs e)
        {
            double sum = 0;
            foreach (Food food in lst) sum += food.energy;
            sumEnergy.Text = string.Format("{0:0.00}", sum);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(test.ToString());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Food food = new Food("Nowy", 0, 0);
            lst.Add(food);
            //Box.SelectedItem = food;
            //Box_SelectedIndexChanged(null, null);
            btnAll.PerformClick();
            for (int i = 0; i < Box.Rows.Count; ++i) Box.Rows[i].Selected = false;
            Box.Rows[lst.Count - 1].Selected = true;
            foodName.SelectAll();
            foodName.Focus();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            /*
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
            */
            Box.Focus();
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Food food = (Food)Box.SelectedItem;
            foodName.DataBindings.Clear();
            foodEnergy.DataBindings.Clear();
            if (food != null)
            {
                foodName.ReadOnly = false;
                foodName.DataBindings.Add("text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                foodEnergy.ReadOnly = false;
                foodEnergy.DataBindings.Add("text", food, "value", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
            }
            */
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

        private void Box_SelectionChanged(object sender, EventArgs e)
        {
            if (Box.SelectedRows.Count == 1)
            {
                Food food = (Food)Box.SelectedRows[0].DataBoundItem;
                foodName.DataBindings.Clear();
                foodWeight.DataBindings.Clear();
                foodEnergy.DataBindings.Clear();
                if (food != null)
                {
                    foodName.ReadOnly = false;
                    foodName.DataBindings.Add("text", food, "name", false, DataSourceUpdateMode.OnPropertyChanged);
                    foodWeight.ReadOnly = false;
                    foodWeight.DataBindings.Add("text", food, "weight", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
                    foodEnergy.ReadOnly = false;
                    foodEnergy.DataBindings.Add("text", food, "energy", true, DataSourceUpdateMode.OnPropertyChanged, 0, "0.00");
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindList(from food in lst where food.pow>4 select food);
            Box.Focus();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            BindList(lst);
            Box.Focus();
        }
    }

    public class Food : INotifyPropertyChanged
    {
        private string _name;
        private double _weight;
        private double _energy;

        public event PropertyChangedEventHandler PropertyChanged;

        public Food(string name, double weight, double energy)
        {
            _name = name;
            _weight = weight;
            _energy = energy;
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
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    Notify("name");
                }
            }
        }
        public double weight
        {
            get { return _weight; }
            set
            {
                if (value != _weight)
                {
                    _weight = value;
                    Notify("weight");
                    Notify("pow");
                }
            }
        }
        public double energy
        {
            get { return _energy; }
            set
            {
                if (value != _energy)
                {
                    _energy = value;
                    Notify("energy");
                    Notify("pow");
                }
            }
        }
        public double pow { get { return _weight != 0 ? _energy / _weight : 0; } }
    }
}
