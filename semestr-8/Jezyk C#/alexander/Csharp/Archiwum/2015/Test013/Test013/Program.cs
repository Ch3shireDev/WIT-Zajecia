using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test013
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> lst = new List<Food>();
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
            var s = 
                from food in lst 
                
                orderby food.name 
                group food by new { Chr = food.name[0], Pow = Math.Min(4,(int)(1+food.energy/food.weight)) } 
                into literpow
                
                orderby literpow.Key.Chr
                group literpow by literpow.Key.Pow
                into pow
                
                orderby pow.Key
                select pow
            ;
            foreach (var x in s)
            {
                Console.WriteLine("{0}", x.Key);
                foreach (var y in x)
                {
                    Console.WriteLine("\t{0}", y.Key.Chr);
                    foreach (var z in y)
                    {
                        Console.WriteLine("\t\t{0} ({1}) {2} {3} {4}", z.name, z.unit, z.weight, z.energy, z.pow);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            var sel = from food in lst orderby food.name group food by food.name[0] into liter orderby liter.Key select liter;
            foreach (var x in sel)
            {
                Console.WriteLine("{0}", x.Key);
                foreach (var y in x)
                {
                    Console.WriteLine("\t{0} ({1}) {2} {3} {4}", y.name, y.unit, y.weight, y.energy, y.pow);
                }
            }
            Console.ReadKey();
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
