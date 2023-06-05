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

namespace Linq
{
    public partial class LinqMainForm : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static List<string> allmethods = new List<string>();
        public LinqMainForm()
        {
            InitializeComponent();
            CbMethods.Items.Clear();
            var methods =
                typeof(LinqMainForm)
                    .GetMethods()
                    .Where((item) => item.IsStatic)
                    .Where((item) => item.ReturnType == typeof(void))
                    .Where((item) => item.GetParameters().Count() == 1)
                    .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                    .OrderBy((item) => item.Name)
                    .Select((item) => item.Name)
            ;

            //foreach (var item in methods) CbTests.Items.Add(item);
            CbMethods.Items.AddRange(methods.ToArray());
            CbMethods.SelectedIndex = 0;
            allmethods.AddRange(methods.Where((name) => name != nameof(Call_All_Tests)));
        }

        private static string CallByName(StringBuilder sb, string name)
        {
            MethodInfo method = typeof(LinqMainForm).GetMethod(name);
            var desc = method.GetCustomAttributes().Where(attr => attr is DescriptionAttribute);
            string description = (desc.Any() ? (desc.First() as DescriptionAttribute).Description : " ! no descrition ! ");

            if (name != nameof(Call_All_Tests))
            {
                sb.Append($"============ {name} ============").Append(Environment.NewLine);
                sb.Append($"# {description}").Append(Environment.NewLine);
            }
            sb.Append(method.Invoke(null, new object[] { sb })).Append(Environment.NewLine).Append(Environment.NewLine);
            return sb.ToString();
        }

        [Description("Wykonaj wszystko, Aleksy Barski")]
        public static void Call_All_Tests(StringBuilder sb)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string name in allmethods)
            {
                MethodInfo method = typeof(LinqMainForm).GetMethod(name);
                var desc = method.GetCustomAttributes().Where(attr => attr is DescriptionAttribute);
                string description = (desc.Any() ? (desc.First() as DescriptionAttribute).Description : " ! no descrition ! ");
                string student = description.Split(",".ToArray(), StringSplitOptions.None).Last().Trim();
                int count;
                if (map.TryGetValue(student, out count)) ++count;
                else count = 1;
                map[student] = count;
            }
            sb.AppendLine("-------------------------------");
            foreach (string student in map.Keys.OrderBy(s => s))
            {
                sb.Append(map[student].ToString().PadLeft(3)).Append('\t').Append(student).Append(Environment.NewLine);
            }
            sb.AppendLine("-------------------------------");
            sb.Append(Environment.NewLine);
            foreach (string name in allmethods) CallByName(sb, name);
            sb.Append(Environment.NewLine);
        }

        [Description("Sortowanie tablicy, Aleksy Barski")]
        public static void TestAB_01(StringBuilder sb)
        {
            digits.OrderBy(str => str).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("Sortowanie tablicy, Aleksy Barski")]
        public static void TestAB_04(StringBuilder sb)
        {
            numbers
                .Select(x => 7*x*x + 5*x + 3)
                .Select(x => new { src=x, dst=x.ToString().ToArray() })
                .Select(x => new { x.src, dst = x.dst.Select(d => digits[d - '0'])})
                .Select(x => new { x.src, dst = String.Join(" ", x.dst) })
                .Aggregate(sb, (sb_, x) => sb_.Append(x.src).Append('\t').AppendLine(x.dst))
           ;
        }

        [Description("Filtrowanie tablicy, Aleksy Barski")]
        public static void TestAB_02(StringBuilder sb)
        {
            //foreach (string s in digits.Where((str, index) => str.Length > index)) sb.Append(s).Append(' ');
            digits.Where((str, index) => str.Length > index).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
            sb.AppendLine();
            digits.OrderBy(str=>str).Where((str, index) => str.Length > index).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("Przekrztalcenie tablicy, Aleksy Barski")]
        public static void TestAB_03(StringBuilder sb)
        {
            var query = from n in numbers.OrderBy(dig=>dig) select new { n, n2 = n * n, n3 = n * n * n };
            //foreach (var item in query) sb.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);
            //query.Aggregate(sb, (sb_, item) => sb_.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine));
            (from n in numbers.OrderBy(dig => dig) select new { n, n2 = n * n, n3 = n * n * n })
                .Aggregate
                (
                    sb, 
                    (sb_, item) => sb_.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine)
                )
            ;
        }

        [Description("Zliczanie, Igor Rasiński")]
        public static void TestIR_01(StringBuilder sb)
        {
            var digitsC = digits.Count();
            var numbersC = numbers.Count();
            sb.Append("Digits count: ").Append(digitsC).Append(Environment.NewLine).Append("Numbers count: ").Append(numbersC).Append(Environment.NewLine);
        }

        [Description("Ordering Reverse, Hubert Pesiek")]
        public static void TestHP_01(StringBuilder sb)
        {
            digits.Reverse().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("Pierwszy element, Dawid Borowski")]
        public static void TestDB_01(StringBuilder sb)
        {
            digits.First().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(""));
        }

        [Description("Czy którekolwiek, Wojciech Adamowski")]
        public static void TestWA_01(StringBuilder sb)
        {
            sb.Append(digits.Any(n => n.StartsWith("n")));
        }

        [Description("Operacja union (Kamil Ulinowicz)")]
        public static void TestKU_01(StringBuilder sb)
        {
            string[] add = { "ten", "eleven", "twelwe" };
            digits
                .Union(add)
                .Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '))
            ;
        }

        [Description("Scalenie dwóch tablic w jedną - suma liczby i liczby znaków w tekście, Kamil Cegliński")]
        public static void TestKC_01(StringBuilder sb)
        {
            digits.Zip(numbers, (a, b) => ("len(\"" + a + "\") + " + b + " = " + (a.Count() + b)))
            .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine));
        }

        [Description("Pierwsza liczba parzysta większa od 6, Mateusz Skrzypik")]

        public static void TestMS_04(StringBuilder sb)
        {
            sb.Append(numbers.Where(num => num % 2 == 0).First(x => x > 6));
        }

        [Description("Czy tablica zwiera wybrane cyfry?, Igor Rasiński")]
        public static void TestIR_02(StringBuilder sb)
        {
            sb
                .Append("Czy lista numbers zawiera 4?: ")
                .Append(numbers.Contains(5))
                .Append(Environment.NewLine)
                .Append("Czy lista numbers zawiera -1?: ")
                .Append(numbers.Contains(-1))
            ;
        }

        [Description("Order by descending, Dawid Borowski")]
        public static void TestDB_02(StringBuilder sb)
        {
            numbers.OrderByDescending((key) => key).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' ')).AppendLine();
        }

        [Description("Posortowane znaki w liczbach, Mateusz Skrzypik")]
        public static void TestMS_05(StringBuilder sb)
        {
            digits
            .Select(str => str.ToCharArray().OrderBy(c => c).ToArray())
            .Select(cArray => new string(cArray))
            .Aggregate(sb, (sbAggregate, current) => sbAggregate.Append(current).Append(' ').AppendLine());
        }

        [Description("Sortowanie tablicy dwukrotnie - dlugosc i potem alfabetycznie, Igor Rasiński")]
        public static void TestIR_03(StringBuilder sb)
        {
            var query = digits.OrderBy(c => c.Length).ThenBy(c => c);
            query.Aggregate(sb, (sb_, item) => sb_.Append(item).Append(Environment.NewLine));
        }

        [Description("Wszystkie unikalne, posortowane znaki we wszystkich 'digits', Mateusz Skrzypik")]
        public static void TestMS_06(StringBuilder sb)
        {
            digits
            .Select(str => str.ToCharArray())
            .SelectMany(x => x)
            .Distinct()
            .OrderBy(x => x)
            .Aggregate(sb, (sbAggregate, current) => sbAggregate.Append(current).Append(' '));
        }

        [Description("Obliczenie kwadratu dla pierwszych sześciu liczb z tablicy, Kamil Cegliński")]
        public static void TestKC_02(StringBuilder sb)
        {
            numbers
                .OrderBy(x=>x)
                .TakeWhile(n => n <= 6)
                .Aggregate(sb, (sb_, n) => sb_.Append(n).Append("^2=").Append(n * n).Append(Environment.NewLine))
            ;
        }

        [Description("Sprawdzenie czy wszystkie liczby z tablicy są parzyste, Kamil Cegliński")]
        public static void TestKC_03(StringBuilder sb)
        {
            sb.Append(numbers.All(x => x < 10) ? "all" : "not all").AppendLine();
            sb.Append(numbers.All(x => x < 9) ? "all" : "not all");
        }

        [Description("Set Distinct, Hubert Pesiek")]
        public static void TestHP_02(StringBuilder sb)
        {
            numbers.Select(x => x + 5).Union(numbers).Distinct().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("Część wspólna list przekształconych przez 2 różne funkcje, Mateusz Skrzypik")]
        public static void TestMS_08(StringBuilder sb)
        {
            numbers
                .Select(x => x + 3)
                .Intersect(numbers.Select(x => x - 2))
                .OrderBy(x => x)
                .Aggregate(sb, (sbAggregate, current) => sbAggregate.Append(current).Append(' '))
           ;
        }

        [Description("ToDictionary + GroupBy grupowanie liczb po ich ilości znaków oraz wypisanie ich, Mateusz Skrzypik")]
        public static void TestMS_10(StringBuilder sb)
        {
            digits
                .GroupBy(x => x.Length)
                .ToDictionary(x => x.Key, x => x.ToList())
                .Select(x => $"Długość: {x.Key}\tLiczby: {string.Join(" ", x.Value)}")
                .Aggregate(sb, (sbAggregate, current) => sbAggregate.Append(current).AppendLine());
            ;
        }

        [Description("Wartości na poszczególnych indeksach, Kamil Ulinowicz")]
        public static void TestKU_06(StringBuilder sb)
        {
            var table = numbers.Select((w, i) => new
            {
                Index = i,
                Value = w
            });
            foreach (var row in table) sb.AppendFormat($"Na indeksie {row.Index} znajduje się: {row.Value}").AppendLine();
        }

        [Description("Usuwanie wartości powtarzających się w drugiej tablicy, Hubert Pesiek")]
        public static void TestHP_04(StringBuilder sb)
        {
            int[] numbers2 = { 1, 2, 3, 4 };
            numbers.Except(numbers2).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Lenght Elements, Hubert Pesiek")]
        public static void TestHP_03(StringBuilder sb)
        {
            var data = from n in digits
                       orderby n
                       select $"Długość = { n.Length }\tElement = { n }";
            data.Aggregate(sb, (sb_, line) => sb_.AppendLine(line));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TbLog.Text = CallByName(new StringBuilder(), CbMethods.SelectedItem.ToString());
        }
    }
}
