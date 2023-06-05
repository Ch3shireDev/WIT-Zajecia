using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LinqTest
{
    public partial class LinqForm : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static string[] AllTests;
        public LinqForm()
        {
            InitializeComponent();
            var methods =
                typeof(LinqForm).GetMethods()
                .Where((method) => method.IsStatic)
                .Where((method) => method.ReturnType == typeof(void))
                .Where((method) => method.GetParameters().Count() == 1)
                .Where((method) => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                //.Where((method) => method.GetCustomAttributes().Where((attr)=>attr is DescriptionAttribute))
                .OrderBy((method) => method.Name)
                .Select((method) => method.Name)
            // Sort (description)
            // select "method: description"
            ;
            AllTests = methods.Where((name) => name != nameof(CallAllTest)).ToArray();
            CbTest.Items.AddRange(methods.ToArray());
            CbTest.SelectedIndex = 0;
        }

        private static string CallByName(string name, StringBuilder sb)
        {
            MethodInfo method = typeof(LinqForm).GetMethod(name);
            var desc = method.GetCustomAttributes().Where((attr) => attr is DescriptionAttribute);
            string description = (desc.Any() ? (desc.First() as DescriptionAttribute).Description: "? missing description ?");
            if (name != nameof(CallAllTest))
            {
                sb.AppendLine($"============ {name} ============");
                sb.AppendLine($"= {description} =");
            }
            method.Invoke(null, new object[] { sb });
            sb.AppendLine();
            return sb.ToString();
        }

        public static void CallAllTest(StringBuilder sb)
        {
            foreach(string method in AllTests) CallByName(method, sb);
        }

        public static bool IsPrime(int n)
        {
            int d = 2;
            while (d * d <= n && n % d != 0) ++d;
            return (n >= 2) && (d * d > n);
        }

        [Description("Uporządkowane (AB)")]
        public static void Test_01(StringBuilder sb)
        {
            //var result=digits.OrderBy((key) => key);
            //foreach (var item in result) sb.Append(item).Append(' ');
            //sb.Append(Environment.NewLine);
            digits.OrderBy((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.Append(Environment.NewLine);
        }

        [Description("Dlugość mniejsza od indeksu (AB)")]
        public static void Test_02(StringBuilder sb)
        {
            digits.Where((text,index) => text.Length <= index).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.Append(Environment.NewLine);
        }

        [Description("Potęgi z tablicy (AB)")]
        public static void Test_03(StringBuilder sb)
        {
            (from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n }).Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0}\t{1}\t{2}",key.n,key.n2,key.n3)).Append(Environment.NewLine));
        }

        [Description("Descending numbers (KD)")]
        public static void Test_04(StringBuilder sb)
        {
            numbers.OrderByDescending((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' ')).AppendLine();
        }

        [Description("Posortowane liczby podzielne przez 2 z tablicy (AN)")]
        public static void Test_05(StringBuilder sb)
        {
            numbers.Where((n) => (n % 2 == 0)).OrderBy((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Odd numbers (KD)")]
        public static void Test_06(StringBuilder sb)
        {
            numbers.Where((n) => n % 2 == 1).OrderByDescending((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Operacja union (MW)")]
        public static void Test_07(StringBuilder sb)
        {
            string[] add = { "ten", "eleven", "twelwe" };
            digits
                .Union(add)
                .Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '))
            ;
            sb.AppendLine();
        }

        [Description("Uprządkowanie po ilości znaków (FS)")]
        public static void Test_08(StringBuilder sb)
        {
            digits.OrderBy((key) => key.Length).Distinct().Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.Append(Environment.NewLine);
        }

        [Description("Uporzadkowane litery o długości większej od 3(KT)")]
        public static void Test_09(StringBuilder sb)
        {
            digits.OrderBy((key) => key).Where((n) => n.Length > 3).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Check is prime (OK)")]
        public static void Test_10(StringBuilder sb)
        {
            (from n in numbers where IsPrime(n) orderby n select n).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Kończące się na o (AM)")]
        public static void Test_11(StringBuilder sb)
        {
            digits.Where((text, index) => text.EndsWith("o")).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("dlugości z tablicy (AM)")]
        public static void Test_12(StringBuilder sb)
        {
            (from str in digits orderby str select new { str, len = str.Length }).Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0}\t{1}", key.str, key.len)).AppendLine());
            sb.AppendLine();
        }

        [Description("Posortowane cyfry wieksze od 2 i mniejsze od 8 tekstowo (JN)")]
        public static void Test_13(StringBuilder sb)
        {
            var query = from d in numbers
                        where 2 < d && d < 8
                        orderby d
                        select digits[d]
            ;
            query.Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Nie unikalne elementy (AS)")]        public static void Test_14(StringBuilder sb)        {            digits[digits.Length - 1] = "zero";            var test = digits.Union(new string[] { "zero", "two", "four" });            var nonUniq = test.GroupBy(v => v).Where(v => v.Count() > 1).Select(v => v.Key).ToList();            nonUniq.Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));            sb.AppendLine();
        }        [Description("Digit's length greater than number's index in numbers (KD)")]        public static void Test_15(StringBuilder sb)
        {
            numbers.OrderBy((number) => number).Where((val, index) => val > digits[index].Length).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));            sb.AppendLine();
        }        [Description("o dlugosci wiekszej niz 4, oraz czy zawierają literę 'v' (AM)")]        public static void Test_16(StringBuilder sb)
        {
            var sel =                from str in digits                orderby str                where str.Length > 4                select new { str, condition = str.Contains("v")?"true":"false" }            ;            sel.Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0}\t{1}", key.str, key.condition)).AppendLine());
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
            TxtLog.Text = CallByName(CbTest.SelectedItem.ToString(), new StringBuilder());
        }
    }
}
