using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class LinqForm : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static List<string> all = new List<string>();
        public LinqForm()
        {
            InitializeComponent();
            all.Clear();
            var methods
            =
                typeof(LinqForm).GetMethods()
                .Where(item => item.IsStatic)
                .Where(item => item.ReturnType == typeof(string))
                .Where(item => item.GetParameters().Count() == 0)
                .OrderBy(item => item.Name)
                .Select(item => item.Name)
                .ToArray()
            ;
            //foreach (var item in methods) LbMethods.Items.Add(item);
            LbMethods.Items.AddRange(methods);
            //foreach (var item in methods) if (item != "Test_All_Them") all.Add(item);
            //all.AddRange(from name in methods where (name != "Test_All_Them") select name);
            all.AddRange(methods.Where(name => name != "Test_All_Them"));
            LbMethods.SelectedIndex = 0;
        }
        public static string Test_All_Them()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var name in all)
            {
                MethodInfo method = typeof(LinqForm).GetMethod(name);
                sb
                    .Append(string.Format("======= {0} =======", name))
                    .Append(Environment.NewLine)
                    .Append((string)method.Invoke(null, null))
                    .Append(Environment.NewLine)
                ;
            }
            return sb.ToString();
        }
        public static string TestA()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Where((name, i) => name.Length <= i);
            foreach(var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestB()
        {
            StringBuilder sb = new StringBuilder();
            var list = from d in numbers where d % 2 == 0 select digits[d];
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestC()
        {
            StringBuilder sb = new StringBuilder();
            var list = from d in numbers select new { n1 = d, n2 = d * d, n3 = d * d * d };
            foreach (var i in list) sb.Append(i.n1).Append('/').Append(i.n2).Append('/').Append(i.n3).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestD()
        {
            string[] add = { "ten" };
            StringBuilder sb = new StringBuilder();
            var list = digits.Union(add).Union(new string[] { "eleven", "twelwe" });
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestE_Barski()
        {
            /*
            StringBuilder sb = new StringBuilder();
            var list = numbers.Select((n) => n * 10 + 109);
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
            */
            return 
                numbers.Select((n) => n * 10 + 109)
                .Aggregate(new StringBuilder(), (sb, n) => sb.Append(n).Append(' '))
                .ToString()
            ;
        }
        public static string TestE_Piotrowski()
        {
            StringBuilder sb = new StringBuilder();
            var list1 = digits.OrderBy(dig => dig.Length);
            foreach (var i in list1) sb.Append(i).Append(' ');
            sb.Append(Environment.NewLine);
            var list2 = digits.OrderBy(dig => dig.Length).ThenBy(dig => dig);
            foreach (var i in list2) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestE_Nekhaiev()
        {
            StringBuilder sb = new StringBuilder();
            string[] Keys = { "even", "odd" };
            var Grouplist = numbers.GroupBy((n) => Keys[n % 2]).Select(n => new { n.Key, List = n });
            foreach (var group in Grouplist)
            {
                sb.Append(group.Key).Append(": ");
                foreach (var i in group.List) sb.Append(i).Append(' ');
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public static string TestF_Piotrowski()
        {
            StringBuilder sb = new StringBuilder();
            int[] noNum = { 5, 6, 7 };
            var list = numbers.Except(noNum);
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestE_Kania()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Średnia: ").Append(numbers.Average().ToString()).Append(Environment.NewLine);
            var list = numbers.TakeWhile(n => n < 7).Select(n => digits[n]);
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestG_Piotrowski()
        {
            StringBuilder sb = new StringBuilder();
            string[] otherDigs = { "three", "twelwe", "five", "eleven", "one" };
            var list1 = digits.Intersect(otherDigs);
            foreach (var i in list1) sb.Append(i).Append(' ');
            sb.Append(Environment.NewLine);
            var list2 = otherDigs.Intersect(digits);
            foreach (var i in list2) sb.Append(i).Append(' ');
            sb.Append(Environment.NewLine);
            var list3 = list2.OrderBy(n => n);
            foreach (var i in list3) sb.Append(i).Append(' ');
            return sb.ToString();
        }
        public static string TestE_Yushchak()
        {
            /*
            StringBuilder sb = new StringBuilder();
            var list = (digits).Reverse();
            foreach (var i in list) sb.Append(i).Append(' ');
            return sb.ToString();
            */
            return 
                digits
                .Reverse()
                .Aggregate(new StringBuilder(), (sb, n) => sb.Append(n).Append(' '))
                .ToString()
            ;
        }
        
        public static string TestZ_skip()
        {
            return digits.Skip(5).Aggregate(new StringBuilder(), (sb, n) => sb.Append(n).Append(' ')).ToString();
        }
        public static string TestZ_take()
        {
            return digits.Take(3).Aggregate(new StringBuilder(), (sb, n) => sb.Append(n).Append(' ')).ToString();
        }
        private void BtnCall_Click(object sender, EventArgs e)
        {
            string name = LbMethods.SelectedItem.ToString();
            MethodInfo method = typeof(LinqForm).GetMethod(name);
            EdLog.AppendText((string)method.Invoke(null, null) + Environment.NewLine);
        }
    }
}
