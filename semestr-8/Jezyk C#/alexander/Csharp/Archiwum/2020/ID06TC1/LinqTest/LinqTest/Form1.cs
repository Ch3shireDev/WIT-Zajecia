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
            ;
            foreach (var item in methods) LbMethods.Items.Add(item);
            //foreach (var item in methods) if (item != "Test_All_Them") all.Add(item);
            //all.AddRange(from name in methods where (name != "Test_All_Them") select name);
            all.AddRange(methods.Where(name => name != "Test_All_Them"));
            LbMethods.SelectedIndex = 0;
        }
        public static string Test_All_Them()
        {
            //*/// 
            return all.Aggregate
                (
                    new StringBuilder(),
                    (sb,name) => sb
                        .Append(string.Format("======= {0} =======", name))
                        .Append(Environment.NewLine)
                        .Append((string)typeof(LinqForm).GetMethod(name).Invoke(null, null))
                        .Append(Environment.NewLine)
                )
                .ToString()
            ;
            /*/
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
            //*/// 
        }
        public static string TestA()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Where((n, i) => n.Length < i);
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestB()
        {
            StringBuilder sb = new StringBuilder();
            var list = from n in numbers where n%2 == 0 select digits[n];
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestC()
        {
            StringBuilder sb = new StringBuilder();
            var list = from n in numbers select new { n1 = n, n2 = n * n, n3 = n * n * n };
            foreach (var item in list) sb.Append(item.n1).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestD()
        {
            StringBuilder sb = new StringBuilder();
            var list = numbers.Select(n => 10 * n + 109);
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestE()
        {
            string[] add = { "ten" };
            /*///
            StringBuilder sb = new StringBuilder();
            var list = digits.Union(add).Union(new string[] { "eleven", "twelwe" }).OrderBy(n => n.Length).ThenBy(n => n);
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
            /*/
            return digits
                .Union(add)
                .Union(new string[] { "eleven", "twelwe" })
                .OrderBy(n => n.Length)
                .ThenBy(n => n)
                .Aggregate(new StringBuilder(),(sb,n) => sb.Append(n).Append(' '))
                .ToString()
             ;
            //*///
        }
        public static string TestT_Damian_Charlak()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.OrderBy(word => word.Length);
            foreach (var word in list) sb.Append(word).Append(' ');
            return sb.ToString();
        }
        public static string TestF_Jakub_Brzozowski()
        {
            StringBuilder sb = new StringBuilder();
            var list = numbers.Count(n => n % 2 == 0);
            sb.Append(list);
            return sb.ToString();
        }
        public static string TestG_Jakub_Brzozowski()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Skip(2).Take(6).SkipWhile(n => n.Length <= 3);
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestJ_Jakub_Brzozowski()
        {
            StringBuilder sb = new StringBuilder();
            var list = numbers.OrderBy(n => n).Zip(digits, (first, second) => first + " " + second);
            foreach (var item in list) sb.Append(item).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestNUM()
        {
            StringBuilder sb = new StringBuilder();
            string[] Keys = { "even", "odd" };
            var Grouplist = numbers.GroupBy((n) => Keys[n % 2]).Select(n => new { n.Key, List = n });
            foreach (var group in Grouplist)
            {
                sb.Append(group.Key).Append(": ");
                foreach (var i in group.List) sb.Append(digits[i]).Append(' ');
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public static string TestR_Remove_Last_3()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Reverse().Skip(3).Reverse();
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestS()
        {
            StringBuilder sb = new StringBuilder();
            var list = numbers.SelectMany(x => numbers, (x, y) => new { x, y, mul = x * y }).Where(p => p.x < p.y).OrderBy(p => p.x).ThenBy(p => p.y);
            foreach (var item in list) sb.Append(string.Format("{0} * {1} = {2}",item.x,item.y,item.mul)).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestT()
        {
            StringBuilder sb = new StringBuilder();
            string[] find = {"two", "cat", "one"};
            var list = find.Select(w => new { item = w, contains = digits.Contains(w) });
            foreach (var item in list) sb.Append(string.Format("{0}: {1}", item.item, item.contains)).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestZ_Damian_Charlak()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Max(w => w.Length);
            sb.Append(list);
            return sb.ToString();
        }
        private void BtnCall_Click(object sender, EventArgs e)
        {
            string name = LbMethods.SelectedItem.ToString();
            MethodInfo method = typeof(LinqForm).GetMethod(name);
            string ret = (string)method.Invoke(null, null);
            EdLog.AppendText(ret + Environment.NewLine);
        }
    }
}
