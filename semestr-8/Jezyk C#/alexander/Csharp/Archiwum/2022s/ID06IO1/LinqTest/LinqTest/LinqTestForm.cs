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
    public partial class LinqTestForm : Form
    {
        private static string[] AllTest;
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqTestForm()
        {
            InitializeComponent();
            var methods=
                typeof(LinqTestForm)
                .GetMethods()
                .Where(method => method.IsStatic)
                .Where(method => method.ReturnType == typeof(void))
                .Where(method => method.GetParameters().Count() == 1)
                .Where(method => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Where(method => method.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                .Select(method => new { method.Name, Desc = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description } )
                .OrderBy(method => method.Name)
            ;
            AllTest = methods.Where(method => method.Name != nameof(RunAllTests)).Select(method => method.Name+": "+ method.Desc).ToArray();
            CbMethods.Items.AddRange(methods.Select(method => method.Name + ": " + method.Desc).ToArray());
            CbMethods.SelectedIndex = 0;
            StringBuilder sb = new StringBuilder();
            methods.Aggregate(sb, (sb_, method) => sb_.AppendFormat("{0}\t{1}", method.Name, method.Desc).AppendLine());
            TbLog.Text = sb.ToString();
        }

        public static void CallByName(string method,StringBuilder sb)
        {
            string[] pair = method.Split(":".ToCharArray());
            string name = pair[0], description=pair[1];
            MethodInfo proc=typeof(LinqTestForm).GetMethod(name);
            if(name!=nameof(RunAllTests)) sb.AppendLine(method);
            proc.Invoke(null, new object[] { sb });
            if (name != nameof(RunAllTests))
            {
                sb.AppendLine();
                sb.AppendLine("--------------------------------");
            }
        }

        [Description("Uruchomenie wszystkich testów")]
        public static void RunAllTests(StringBuilder sb)
        {
            foreach (string name in AllTest) CallByName(name, sb);
        }

        [Description("Posortowane słowa")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy(word => word).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Cyfry słownie")]
        public static void Test_AB_02(StringBuilder sb)
        {
            numbers.Select(digit => digits[digit]).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Tablica potęg")]
        public static void Test_AB_03(StringBuilder sb)
        {
            var table = from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var row in table) sb.AppendFormat("{0}\t{1}\t{2}",row.n,row.n2,row.n3).AppendLine();
        }

        [Description("Liczby parzyste")]
        public static void Test_TM_01(StringBuilder sb)
        {
            var table = numbers.Where(n => n % 2 == 0);
            foreach (var row in table) sb.Append(row).AppendLine();
        }

        [Description("Średnia z liczb")]
        public static void Test_JG_01(StringBuilder sb)
        {
            //double table = numbers.Sum(); // numbers.Average();
            //var size = numbers.Length;
            //sb.Append(table / size).AppendLine();
            sb.Append(numbers.Select(num => 1.0*num).Average()).AppendLine();
        }

        [Description("Najwieksza parzysta liczba")]
        public static void Test_YM_01(StringBuilder sb)
        {
            var query = numbers.Max(n => n % 2 == 0 ? n : 0);
            sb.AppendLine(query.ToString());
        }

        [Description("Pomin pierwsze trzy")]
        public static void Test_NW_01(StringBuilder sb)
        {
            digits.Skip(3).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Sprawdzanie zawartości tablicy")]
        public static void Test_DS_01(StringBuilder sb)
        {
            //var result = numbers.Contains(5);
            //sb.Append("sequence contains the value 5: ").Append(result);
            sb.AppendFormat("sequence contains the value 5: {0}",numbers.Contains(5));
        }

        [Description("Pierwsza litera")]
        public static void Test_DS_02(StringBuilder sb)
        {
            var result = digits.Any(n => n.StartsWith("f"));
            sb.Append("Does any of the names start with the letter 'f': ").Append(result);
        }

        [Description("Wartości na poszczególnych indeksach.")]
        public static void Test_TM_02(StringBuilder sb)
        {
            var table = numbers.Select((w, i) => new
            {
                Index = i,
                Value = w
            });
            foreach (var row in table) sb.AppendFormat($"Na indeksie {row.Index} znajduje się: {row.Value}").AppendLine();
        }

        [Description("Liczby które są na swoich miejscach")]
        public static void Test_WH_02(StringBuilder sb)
        {
            numbers.Select((n, i) => n == i).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Porządkowanie liczb po wartości (od największej)")]
        public static void Test_ED_01(StringBuilder sb)
        {
            var result = numbers.OrderByDescending(n => n);
            foreach (int number in result) sb.Append(number).AppendLine();
        }

        [Description("Połączenie tablic bo czemu nie.")]
        public static void Test_TM_03(StringBuilder sb)
        {
            string[] result = { "{" };
            var table = result.Concat(digits).Concat(Array.ConvertAll(numbers, num => num.ToString())).Concat(new string[] { "}" });
            foreach (var row in table) sb.Append(row).AppendLine();
        }

        [Description("Liczby podzielne przez 3 prez tworzenie grup")]
        public static void Test_DS_03(StringBuilder sb)
        {
            var result = numbers.GroupBy(n => (n % 3 == 0));
            foreach (IGrouping<bool, int> group in result)
            {
                sb.Append(group.Key ? "Divisible by 3: " : "Not Divisible by 3: ");

                foreach (int number in group)
                    sb.Append(number);
            }
        }

        [Description("Liczby podzielne przez 3 prez tworzenie grup")]
        public static void Test_AB_04(StringBuilder sb)
        {
            numbers.GroupBy(n => (n % 3 == 0)).
            Select((g) => g.Aggregate("", (s, item) => s + " " + item.ToString())).
            Select((list, index) => (index > 0 ? "Divisible by 3: " : "Not Divisible by 3: ") + list).
            Aggregate(sb, (sb_, line) => sb_.AppendLine(line));
        }

        [Description("Odwrócenie tabeli")]
        public static void Test_JG_02(StringBuilder sb)
        {
            /*
            foreach (var digit in digits.Reverse())
            {
                sb.AppendLine(digit);
            }
            */
            digits.Reverse().Aggregate(sb, (sb_, line) => sb_.AppendLine(line));
        }

        [Description("Pobieranie z tablicy do warunku")]
        public static void Test_ED_04(StringBuilder sb)
        {
            var result = numbers.TakeWhile(n => n < 7);
            foreach (int number in result) sb.Append(number).AppendLine();
        }

        [Description("Dlugosci slow w tablicy")]
        public static void Test_YM_02(StringBuilder sb)
        {
            //var table = from n in digits orderby n select new { n, nlenght = n.Length };
            //foreach (var s in table) sb.Append($"Długość = { s.nlenght }\tElement = { s.n }").AppendLine();
            var data = from n in digits
                       orderby n
                       select $"Długość = { n.Length }\tElement = { n }";
            data.Aggregate(sb, (sb_, line) => sb_.AppendLine(line));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            CallByName(CbMethods.SelectedItem.ToString(),sb);
            TbLog.Text = sb.ToString();
        }
    }
}
