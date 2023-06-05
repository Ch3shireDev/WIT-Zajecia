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
    public partial class Form1 : Form
    {
        private static List<string> allmethods = new List<string>();
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public Form1()
        {
            InitializeComponent();
            var methods =
                typeof(Form1).GetMethods()
                .Where((item) => item.IsStatic)
                .Where((item) => item.ReturnType == typeof(void))
                .Where((item) => item.GetParameters().Count() == 1)
                .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Where((item) => item.GetCustomAttributes().Where(attr => attr is DescriptionAttribute).Any())
                .OrderBy((item) => item.Name)
                .Select
                (
                    (item) => new
                    {
                        name = item.Name,
                        desc = (item.GetCustomAttributes().Where(attr => attr is DescriptionAttribute).FirstOrDefault() as DescriptionAttribute).Description
                    } 
                )
            ;

            //foreach (var item in methods) CbTests.Items.Add(item);
            CbMethods.Items.AddRange(methods.Select((item) => item.name).ToArray());
            CbMethods.SelectedIndex = 0;
            allmethods.AddRange(methods.Where((item) => item.name != nameof(Call_All_Tests)).Select((item) => item.name));
        }

        private static string CallByName(StringBuilder sb, string name)
        {
            MethodInfo method = typeof(Form1).GetMethod(name);
            var desc = method.GetCustomAttributes().Where(attr => attr is DescriptionAttribute);
            string description = (desc.Any() ? (desc.First() as DescriptionAttribute).Description : " ! no descrition ! ");

            if (name != nameof(Call_All_Tests))
            {
                sb.Append($"============ {name} ============").Append(Environment.NewLine);
                sb.Append($"# {description}").Append(Environment.NewLine);
            }
            sb.Append(method.Invoke(null, new object[] { sb })).Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        [Description("Wywolanie wszystkich")]
        public static void Call_All_Tests(StringBuilder sb)
        {
            allmethods
                .GroupBy((name) => name.Substring(5, 5))
                .Select((group) => string.Format("{0}: {1,2}", group.Key, group.Count()))
                .OrderBy((row) => row)
                .Aggregate(sb, (_sb, row) => sb.AppendLine(row))
                .AppendLine("=========")
                .AppendLine()
                .AppendLine()
            ;
            foreach (string name in allmethods) CallByName(sb, name);
        }

        [Description("Wyszukiwanie")]
        public static void Test_00000_01(StringBuilder sb)
        {
            digits.
                Where((text, index) => text.Length < index).
                Aggregate(sb, (_sb, text) => sb.Append(text).Append(' '))
            ;
            sb.AppendLine();
        }

        [Description("Tabelka z listy")]
        public static void Test_00000_02(StringBuilder sb)
        {
            var tb = 
                from n in numbers
                orderby n
                select new { text=digits[n],n, n2 = n * n, n3 = n * n * n }
            ;
            tb.Aggregate(sb, (_sb, item) => sb.AppendFormat("{0}\t{1}\t{2}\t{3}",item.text,item.n,item.n2,item.n3).AppendLine());
        }

        [Description("Powtórzenie całej tablicy")]
        public static void Test_00000_03(StringBuilder sb)
        {
            digits.Join(Enumerable.Range(0, 3), ((num) => 0), ((rng) => 0), (num,rng) => num).Aggregate(sb, (_sb, num) => _sb.Append($"{num} "));
            sb.AppendLine();
            Enumerable.Range(0, 3).Join(digits, ((num) => 0), ((rng) => 0), (num, rng) => rng).Aggregate(sb, (_sb, num) => _sb.Append($"{num} "));
            sb.AppendLine();
        }

        [Description("Suma w numbres pomnożona przez 2")]
        public static void Test_18054_01(StringBuilder sb)
        {
            sb.AppendLine(numbers.Sum(x => 2 * x).ToString());
        }

        [Description("Pierwsze słowo o długości mniejszej niż 5")]
        public static void Test_18069_01(StringBuilder sb)
        {
            sb.Append("found: \"").Append(digits.FirstOrDefault(digit => digit.Length < 5)).AppendLine("\"");
            sb.Append("found: \"").Append(digits.FirstOrDefault(digit => digit.Length < 3)).AppendLine("\"");
        }

        [Description("Liczby nieparzyste w numbers")]
        public static void Test_18054_02(StringBuilder sb)
        {
            //var query = from n in numbers orderby n where n % 2 != 0 select new { n };
            (
                from n in numbers
                orderby n
                where n % 2 != 0
                select n
            ).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
            (
                from n in numbers
                orderby n
                where n % 2 != 0
                select new { value=n, text=digits[n] }
            ).Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0} -> {1}; ",key.value,key.text)));
            sb.AppendLine();
        }

        [Description("Wyswietlenie dwóch ostatnich elementow")]
        public static void Test_18069_02(StringBuilder sb)
        {
            foreach (var item in digits.Skip(Math.Max(0, digits.Count() - 2))) sb.Append(item).Append(' ');
            sb.AppendLine();
        }

        [Description("Powtórzenie wartości")]
        public static void Test_18054_03(StringBuilder sb)
        {
            Enumerable.Repeat("one", 2).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Cyfry od tyłu")]
        public static void Test_18069_03(StringBuilder sb)
        {
            digits.Select(x => new string(x.Reverse().ToArray())).Reverse().Aggregate(sb, (_sb, key) => _sb.Append($"{key} "));
            sb.AppendLine();
        }

        [Description("Pozycje ktróre nie występują w numbers")]
        public static void Test_18054_04(StringBuilder sb)
        {
            int[] numbers1 = { 5, 2, 3, 4, 7, 9, 6, 1, 8, 10, 13, 12, 11 };
            numbers1.Except(numbers).Aggregate(sb, (_sb, key) => _sb.Append($"{key} "));
            sb.AppendLine();
            numbers1.Intersect(numbers).Aggregate(sb, (_sb, key) => _sb.Append($"{key} "));
            sb.AppendLine();
        }

        [Description("Zaczynające się na literę f")]
        public static void Test_18069_04(StringBuilder sb)
        {
            var x = new { sb, first = true };
            digits.Where((name, index) => name.StartsWith("f")).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' ')).AppendLine();
        }

        [Description("Tabliczka mnożenia")]
        public static void Test_18054_05(StringBuilder sb)
        {
            var noZero = Enumerable.Range(1, 9);
            var multi = noZero.Join(noZero, x => true, y => true, (x, y) => new { x, y }).GroupBy((cell) => cell.y);
            foreach (var row in multi)
            {
                foreach (var col in row) sb.AppendFormat("{0,10}", col.y*col.x);
                sb.AppendLine();
            }
        }

        [Description("Tabliczka mnożenia 2")]
        public static void Test_00000_05(StringBuilder sb)
        {
            var noZero = Enumerable.Range(1, 9);
            /*
            var multi
            =
                noZero.Join(noZero, x => true, y => true, (x, y) => new { x, y })
                .GroupBy((cell) => cell.y)
                .Select((ceil) => ceil.Aggregate("", (s, v) => s + string.Format("{0,10}", v.y * v.x ) ) )
                .Aggregate(sb,(_sb,line) => sb.AppendLine(line))
            ;
            */
            var multi
            =
                noZero.Join(noZero, x => true, y => true, (x, y) => new { x, y })
                .GroupBy((cell) => cell.y)
                .Select((ceil) => ceil.Aggregate(sb, (_sb, v) => sb.AppendFormat((v.y * v.x > 1) ? "{0,10}\t" : new string(' ', 10) + '\t', v.y * v.x)))
                .Aggregate(sb, (_sb, line) => sb.AppendLine())
            ;
        }

        [Description("Wyrazy kończące się na literę o ")]
        public static void Test_18069_05(StringBuilder sb)
        {
            digits.Where((text, index) => text.EndsWith("o")).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' ')).AppendLine();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TxtLog.Text = CallByName(new StringBuilder(), CbMethods.SelectedItem.ToString());
        }
    }
}
