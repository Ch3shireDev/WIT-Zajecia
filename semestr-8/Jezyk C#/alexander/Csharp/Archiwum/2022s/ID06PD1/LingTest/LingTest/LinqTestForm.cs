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

namespace LingTest
{
    public partial class LinqTestForm : Form
    {
        private static string[] AllTest;
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqTestForm()
        {
            InitializeComponent();
            var methods
            =
                typeof(LinqTestForm)
                .GetMethods()
                .Where(method => method.IsStatic)
                .Where(method => method.ReturnType ==typeof(void))
                .Where(method => method.GetParameters().Count() == 1)
                .Where(method => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Where(method => method.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                .Select(method => new { name = method.Name, desc = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description})
                .OrderBy(method => method.name)
            ;
            AllTest = methods.Where(method => method.name != nameof(RunAllTests)).Select(method => method.name).ToArray();
            CbMethods.Items.AddRange(methods.Select(method => $"{method.name}: {method.desc}").ToArray());
            CbMethods.SelectedIndex = 0;
            StringBuilder sb = new StringBuilder();
            methods
                .Where(method => method.name != nameof(RunAllTests))
                .Aggregate(sb, (sb_, method) => sb_.AppendLine($"{method.name}: {method.desc}"))
            ;
            TbLog.Text = sb.ToString();
        }

        public static void CallByName(string name, StringBuilder sb)
        {
            MethodInfo method = typeof(LinqTestForm).GetMethod(name);
            string description = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description;
            bool NotAll = (name != nameof(RunAllTests));
            if (NotAll) sb.AppendLine($"{name}: {description}");
            method.Invoke(null, new object[] { sb });
            if (NotAll)
            {
                sb.AppendLine();
                sb.AppendLine("=============================");
                sb.AppendLine();
            }
        }

        [Description("Wszystke testy")]
        public static void RunAllTests(StringBuilder sb)
        {
            foreach (string name in AllTest) CallByName(name, sb);
        }

        [Description("Posortowane słowa")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy(word => word).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Iloczyn bez zera")]
        public static void Test_AB_02(StringBuilder sb)
        {
            int Product = numbers.Where(value => (value > 0)).Aggregate(1, (product, value) => product * value);
            sb.Append(Product);
        }

        [Description("Tablice potęg")]
        public static void Test_AB_03(StringBuilder sb)
        {
            numbers.OrderBy(value => value).Select(n1 => new { n1, n2=n1*n1, n3=n1*n1*n1 }).Aggregate(sb, (sb_, s) => sb_.AppendFormat($"{s.n1}\t{s.n2}\t{s.n3}").AppendLine());
        }

        [Description("Nazwa i dłuigość")]
        public static void Test_AB_04(StringBuilder sb)
        {
            digits.Select(word => new { word,len=word.Length }).OrderBy(s => s.len).Aggregate(sb, (sb_, s) => sb_.AppendFormat($"{s.len}\t{s.word}").AppendLine());
        }

        [Description("Wyswietlenie 2 ostatnich elementow tablicy")]
        public static void Test_JZ_01(StringBuilder sb)
        {
            var item = digits.Skip(Math.Max(0, digits.Count() - 2));
            foreach (var digit in item)
            {
                sb.AppendLine(digit);
            }
        }

        [Description("Cyfry nieparzyste posortowane malejąco")]
        public static void Test_DS_01(StringBuilder sb)
        {
            var table = numbers.Where(value => value % 2 != 0).OrderByDescending(number => number);
            foreach (var row in table) sb.Append(row).AppendLine();
        }

        [Description("Maximum, Minimum, ...")]
        public static void Test_KG_07(StringBuilder sb)
        {
            sb.Append($"max={numbers.Max()}; min={numbers.Min()}; sum={numbers.Sum()}; avg={numbers.Average()};");
        }

        [Description("Znalezienie słów co mają najwięcej znaków a następnie wyświeltenie pierwszego w kolejności")]
        public static void Test_JZ_02(StringBuilder sb)
        {
            sb.Append(digits.OrderByDescending(word => word.Length).First()); // Max() prościej
        }

        [Description("Suma bez ujemnych")]
        public static void Test_FF_01(StringBuilder sb)
        {
            int Product = numbers.Where(value => (value >= 0)).Aggregate(0, (product, value) => product + value); // Sum() prościej
            sb.Append(Product);
        }

        [Description("Pomin pierwsze cztery słowa")]
        public static void Test_MS_02(StringBuilder sb)
        {
            digits.Skip(4).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Zakes 3 do 6")]
        public static void Test_BS_01(StringBuilder sb)
        {
            numbers.Where(n => n >= 3 && n <= 6).Aggregate(sb, (sb_, s) => sb_.Append(s).Append(' '));
        }

        [Description("Średnia z cyfr parzystych (0+2+4+6+8)/5 = 20/5 = 4")]
        public static void Test_DS_02(StringBuilder sb)
        {
            var average = numbers.Where(value => value % 2 == 0).Average();
            sb.AppendFormat("Wynik = {0}", average);
        }

        [Description("Silnia")]
        public static void Test_KG_08(StringBuilder sb)
        {
            int[] zero = { 0 };
            var result = numbers.Except(zero).OrderBy(numbers => numbers).Aggregate((a, b) => a * b);
            sb.Append(result);
        }

        [Description("Dlugosci slow w tablicy")]
        public static void Test_MS_03(StringBuilder sb)
        {
            var dane = from n in digits
                       orderby n
                       select $"Długość = { n.Length }\tElement = { n }";
            dane.Aggregate(sb, (sb_, line) => sb_.AppendLine(line));
        }

        [Description("Część wspólna (iloczyn) zbioru liczb od 0-9 i drugich potęg liczb 0-9")]
        public static void Test_JZ_03(StringBuilder sb)
        {
            var powers = numbers.Select(number => number * number).Intersect(numbers);
            foreach (var element in powers)
            {
                sb.AppendLine(element.ToString());
            }
        }

        [Description("Połączenie tablic z liczbami i słowami")]
        public static void Test_MS_04(StringBuilder sb)
        {
            string[] connect = { "{" };
            var table = connect.Concat(digits).Concat(Array.ConvertAll(numbers, num => num.ToString())).Concat(connect);
            foreach (var row in table) sb.Append(row).AppendLine();
        }

        [Description("Sortuje słowa po długości a potem ustawia alfabetycznie dla danej długości słowa")]
        public static void Test_JZ_04(StringBuilder sb)
        {
            var result = digits.OrderBy(word => word.Length).ThenBy(word => word);
            foreach (var digit in result)
            {
                sb.AppendLine(digit);
            }
        }

        [Description("Wybrany element")]
        public static void Test_BS_04(StringBuilder sb)
        {
            var result = digits.ElementAt(2);
            sb.Append(result);
        }

        [Description("Posortowane liczby podzielne przez 5")]
        public static void Test_WL_05(StringBuilder sb)
        {
            numbers.Where((n) => (n % 5 == 0)).OrderBy((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
        }

        [Description("Potęgi z tablicy (inna forma)")]
        public static void Test_MS_05(StringBuilder sb)
        {
            (from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n }).Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0}\t{1}\t{2}", key.n, key.n2, key.n3)).Append(Environment.NewLine));
        }

        [Description("Liczby z ustawionym 3 bitem")]
        public static void Test_WL_06(StringBuilder sb)
        {
            (from a in numbers where (a&4)!=0 orderby a select $"<{a}>").Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
        }

        [Description("Sortowanie liczb wiekszych od 2 i mniejszych od 6")]
        public static void Test_WL_08(StringBuilder sb)
        {
            var sort = from num in numbers where 2 < num && num < 6 orderby num select digits[num];
            sort.Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
        }

        [Description("Słowo o największej dlugości")]
        public static void Test_WL_09(StringBuilder sb)
        {
            sb.Append(digits.Max(n => n.Length));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //new char[] { ':' } => ":".ToCharArray()
            //new char[] { '\r','\n','\v','\f' } => "\r\n\v\f".ToCharArray()
            CallByName((CbMethods.SelectedItem.ToString().Split(":".ToCharArray()))[0],sb);
            TbLog.Text = sb.ToString();
        }
    }
}
