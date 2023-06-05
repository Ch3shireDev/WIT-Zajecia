using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test012
{
    public partial class Form1 : Form
    {
        private List<Food> lst;

        private void Bind(IEnumerable<Food> lst)
        {
            grid.DataSource = new BindingSource(lst,null);
        }

        public Form1()
        {
            InitializeComponent();
            lst = new List<Food>();
            lst.Add(new Food("Papaya", "1 wedge", 150, 39));
            lst.Add(new Food("Curry puff, potato & spices", "One", 40, 128));
            lst.Add(new Food("Peanut, roasted", "2 tbsp", 30, 171));
            lst.Add(new Food("Yoghurt, natural, plain", "1 cup", 200, 170));
            lst.Add(new Food("Peanut butter", "1 dsp", 15, 90));
            lst.Add(new Food("Hamburger", "One", 100, 267));
            lst.Add(new Food("Fruit cocktail, canned", "0.5 cup", 128, 100));
            lst.Add(new Food("Fruit cake", "1 wedge", 50, 177));
            lst.Add(new Food("Potato crisp", "1 packet", 35, 187));
            lst.Add(new Food("Cow’s milk, whole", "1 glass", 250, 163));
            Bind(lst);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bind(from food in lst where food.energy / food.weight > 4 orderby food.energy / food.weight descending select food);
            List<Food> L=(from food in lst where food.energy / food.weight > 4 orderby food.energy / food.weight descending select food).ToList();
            Food[] A = (from food in lst where food.energy / food.weight > 4 orderby food.energy / food.weight descending select food).ToArray();
        }
    }

    internal class Food
    {
        public string name { get; set; }
        public string unit { get; set; }
        public double weight { get; set; }
        public double energy { get; set; }
        public double pow { get { return energy / weight; } }
        public Food(string name, string unit, double weight, double energy)
        {
            this.name = name;
            this.unit = unit;
            this.weight = weight;
            this.energy = energy;
        }
    }
}
