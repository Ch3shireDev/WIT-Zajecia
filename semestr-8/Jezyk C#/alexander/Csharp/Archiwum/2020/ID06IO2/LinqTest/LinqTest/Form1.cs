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
        private static int[] numbers = { 5,4,1,3,9,8,6,7,2,0 };
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
            foreach (var item in methods) LbMethod.Items.Add(item);
            //foreach (var item in methods) if (item != "Test_All_Them") all.Add(item);
            //all.AddRange(from name in methods where (name != "Test_All_Them") select name);
            all.AddRange(methods.Where(name => name != "Test_All_Them"));
            LbMethod.SelectedIndex = 0;
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
            StringBuilder sb=new StringBuilder();
            var shortDigits = digits.Where((text,index) => text.Length <= index);
            foreach (var item in shortDigits) sb.Append(item.ToString()).Append(' ');
            return sb.ToString();
        }
        public static string TestB()
        {
            StringBuilder sb = new StringBuilder();
            var conversion = from item in numbers select item*100+2;
            foreach (var item in conversion) sb.Append(item.ToString()).Append(' ');
            return sb.ToString();
        }
        public static string TestC()
        {
            StringBuilder sb = new StringBuilder();
            var conversion = from n in numbers select new { n1 = n, n2 = n*n, n3=n*n*n };
            foreach (var item in conversion) sb.Append(item.n1).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);
            return sb.ToString();
        }
        public static string TestD()
        {
            StringBuilder sb = new StringBuilder();
            var list = from n in numbers where (n&1)!=0 orderby n select digits[n];
            foreach (var item in list) sb.Append(item.ToString()).Append(' ');
            return sb.ToString();
        }
        public static string TestDxxx()
        {
            return numbers.Where(n => (n & 1) != 0).OrderBy(n => n).Aggregate(new StringBuilder(), (sb, n) => sb.Append(digits[n]).Append(' ')).ToString();
        }
        public static string TestE()
        {
            string[] add = { "ten", "eleven", "twelwe" };
            StringBuilder sb = new StringBuilder();
            var list = digits.Union(add);
            foreach (var item in list) sb.Append(item.ToString()).Append(' ');
            return sb.ToString();
        }
        public static string TestN() //Wybieranie co 5 liczby
        {
            StringBuilder sb = new StringBuilder();
            var numbers = Enumerable.Range(1, 50).Where(n => n % 5 == 0);
            foreach (var n in numbers)
            {
                sb.Append(n).Append(" ");
            }
            return sb.ToString();
        }
        public static string TestF()
        {
            StringBuilder sb = new StringBuilder();
            string startsWithFirst = digits.First(s => s[0] == 's');
            sb.Append(startsWithFirst).Append(' ');
            string startsWithLast = digits.Last(s => s[0] == 's');
            sb.Append(startsWithLast).Append(' ');
            return sb.ToString();
        }
        public static string TestL()
        {
            StringBuilder sb = new StringBuilder();
            var first3 = digits.Take(5);
            var skipFirst4 = digits.Skip(4);
            var firstLessThan9 = digits.TakeWhile(n => n.Length < 5); // "three".Length==5
            foreach (var n in first3) sb.Append(n).Append(' ');
            sb.Append(Environment.NewLine);
            foreach (var n in skipFirst4) sb.Append(n).Append(' '); 
            sb.Append(Environment.NewLine);
            foreach (var n in firstLessThan9) sb.Append(n).Append(' ');
            return sb.ToString();
        }
        public static string TestF_malikm()
        {
            return new StringBuilder().Append("Where number % 2 == 0: ").Append(numbers.Distinct().Count(n => n % 2 == 0)).ToString();
            /*
            StringBuilder sb = new StringBuilder();
            var tmpList = numbers.Distinct().Count(n => n % 2 == 0);
            sb.Append("Where number % 2 == 0:  " + tmpList);
            return sb.ToString();

            */
        }
        public static string TestU()
        {
            StringBuilder sb = new StringBuilder();
            int[] vectorA = { 3, 2, 1 };
            int[] vectorB = { 1, 2, 3 };
            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum(); // 3*1 + 2*2 + 1*3
            sb.Append(dotProduct).Append(Environment.NewLine);
            sb.Append("Suma kwadratów: ").Append(vectorA.Zip(vectorA, (a, b) => a * b).Sum()); // suma kwadratów
            return sb.ToString();
        }
        public static string TestG_malikm()
        {
            StringBuilder sb = new StringBuilder();
            var wordGroups = digits.GroupBy(w => w[0]).Select(g => new { FirstLetter = g.Key, Words = g });
            foreach (var g in wordGroups)
            {
                sb.Append(string.Format("Początek na litere {0} :",g.FirstLetter));
                foreach (var w in g.Words) sb.Append(' ').Append(w);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public static string TestM()
        {
            object[] array = { null, 1.3, "two", 3, "four", 5, "six", 7.6 };
            return array.OfType<double>().Aggregate(new StringBuilder(), (sb, next) => sb.Append(next).Append(' ')).ToString();
            /*
            StringBuilder sb = ;
            var doubles = array.OfType<double>();
            foreach (double item in doubles)
            {
                sb.Append(item).Append(' ');
            }
            return sb.ToString();
            */
        }
        private void BtnRun_Click(object sender, EventArgs e)
        {
            string name = LbMethod.SelectedItem.ToString();
            MethodInfo method = typeof(LinqForm).GetMethod(name);
            EdLog.AppendText(((string)method.Invoke(null, null)) + Environment.NewLine);
        }
    }
}
