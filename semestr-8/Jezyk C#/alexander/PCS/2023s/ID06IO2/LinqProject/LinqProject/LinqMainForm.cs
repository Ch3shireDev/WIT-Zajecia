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

namespace LinqProject
{
    public partial class LinqMainForm : Form
    {
        private static List<string> allmethods = new List<string>();
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqMainForm()
        {
            InitializeComponent();
            CbMethods.Items.Clear();
            var methods =
                typeof(LinqMainForm).GetMethods()
                .Where((item) => item.IsPublic)
                .Where((item) => item.IsStatic)
                .Where((item) => item.ReturnType == typeof(void))
                .Where((item) => item.GetParameters().Count() == 1)
                .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                .OrderBy((item) => item.Name)
                .Select((item) => item.Name)
            ;
            CbMethods.Items.AddRange(methods.ToArray());
            CbMethods.SelectedIndex = 0;
            allmethods.AddRange(methods.Where((name) => name != nameof(Call_All_Tests)));

        }

        [Description("Wywolanie wszystkich")]
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
            sb.Append(method.Invoke(null, new object[] { sb })).Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        [Description("Sortowanie tablicy, Aleksy Barski")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy(d => d).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' '));
        }

        [Description("Filtrowanie tablicy, Aleksy Barski")]
        public static void Test_AB_02(StringBuilder sb)
        {
            digits.OrderBy(d => d).Where((d,i) => d.Length>i).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' '));
        }

        [Description("Przeksztalcenie tablicy, Aleksy Barski")]
        public static void Test_AB_03(StringBuilder sb)
        {
            numbers.Select(d => digits[d]).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' '));
        }

        [Description("Forma SQL, Aleksy Barski")]
        public static void Test_AB_04(StringBuilder sb)
        {
            var query = from n in numbers select new { n, n2 = n * n, n3 = n * n * n };
            foreach(var item in query)
            {
                sb.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append('\t').AppendLine();
            }
        }

        [Description("Group by, Marcin Ryba")]
        public static void Test_MR_01(StringBuilder sb)
        {
            string[] Text = { "Divisible by 2", "Not Divisible by 2" };
            var result
            =
                numbers
                .GroupBy(n => n % 2)
                .Select(g => Text[g.Key]+": "+g.Aggregate("", (s, v) => s += v.ToString() + ' '))
                .Aggregate(sb,(sb_,s) => sb.Append(s).AppendLine())
            ;
        }

        [Description("Z dwóch tablic tworzy tablicę dwukolumnową, Roman Popadiuk")]
        public static void Test_RP_01(StringBuilder sb)
        {
            numbers
                .OrderBy(d=>d)
                .Zip(digits, (a, b) => new { a, b })
                .Aggregate(sb, (sb_, s) => sb.Append(s.a).Append(" => ").Append(s.b).AppendLine());
        }

        [Description("Pierwszy i ostatni element, Mateusz Kinast")]
        public static void Test_MK_01(StringBuilder sb)
        {
            sb.Append("Pierwszy: ").AppendLine(numbers.First().ToString());
            sb.Append("Ostatni: ").AppendLine(numbers.Last().ToString());
        }

        [Description("Sumowanie Tablicy, Natalia Wiśniewska")]
        public static void Test_NW_01(StringBuilder sb)
        {
            numbers.Aggregate(sb, (sb_, d) => sb_.Append(d).Append(" + "));
            sb.Append(" = ").Append(numbers.Sum()).AppendLine();
        }

        [Description("Czy tablica zawiera daną liczbe, Jakub Lodoń")]
        public static void Test_JL_04(StringBuilder sb)
        {
            sb.Append($"Czy tablica zawiera 3={numbers.Contains(3)}");
        }

        [Description("Czy liczby w tablicy są podzielne przez 2 SQL, Jakub Lodoń")]
        public static void Test_JL_05(StringBuilder sb)
        {
            foreach (var num in from num in numbers where (num % 2) == 0 select num)
            {
                sb.Append(num).Append(' ');
            }
        }

        [Description("Tylko duplikaty dwóch tablic, Natalia Wiśniewska")]
        public static void Test_NW_03(StringBuilder sb)
        {
            numbers.Aggregate(sb, (sb_, d) => sb_.Append(d).Append(" ")).AppendLine();
            numbers.Select(d => d * d).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(" ")).AppendLine().Append("Result:");
            numbers.Select(d => d * d).Intersect(numbers).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' '));
        }

        /*
        [Description("Join, Daniil Hedroits")]
        public static void Test_DH_01(StringBuilder sb)
        {
            string[] numb = { "zero", "nine", "ten" };
            digits.Join(numb, dig => dig, num => num, (dig, num) => dig).Aggregate(sb, (sb_, number) => sb_.Append(number).Append(' '));
        }
        */

        [Description("Usuwanie duplikatów, Jakub Lodoń")]
        public static void Test_JL_02(StringBuilder sb)
        {
            numbers.Concat(numbers).OrderBy(d => d).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' ')).AppendLine();
            numbers.Distinct().OrderBy(d => d).Aggregate(sb, (sb_, number) => sb_.Append(number).Append(' '));
        }

        [Description("Pomiń pierwsze 4 elementy, Jakub Lodoń")]
        public static void Test_JL_03(StringBuilder sb)
        {
            digits.Skip(4).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Dzieli tablicę na podgrupy, Roman Popadiuk")]
        public static void Test_RP_03(StringBuilder sb)
        {
            /*///
            var result = digits.ToLookup(d => d.Length).OrderBy(d => d.Key);
            foreach(var r in result)
            {
                sb.Append($"Elements with a length of {r.Key}:");
                r.Aggregate(sb, (sb_, d) => sb_.Append(' ').Append(d));
                sb.AppendLine();
            }
            /*/
            digits
                .ToLookup(d => d.Length)
                .OrderBy(d => d.Key)
                .Select(d => d.Aggregate($"Elements with a length of {d.Key}:", (s, v) => s + ' ' + v))
                .Aggregate(sb, (sb_, row) => sb_.Append(row).AppendLine());
            //*///
        }

        [Description("Range, Marcin Ryba")]
        public static void Test_MR_04(StringBuilder sb)
        {
            //Enumerable.Range(0, 5).ToList().ForEach(number => sb.Append(number).Append(" "));
            Enumerable.Range(0, 5).Aggregate(sb, (sb_, word) => sb_.Append(' ').Append(word));
        }

        [Description("SQL - select Many - kolumny wartości, Natalia Wiśniewska")]
        public static void Test_NW_04(StringBuilder sb)
        {
            var query = from d in digits
                        from n in numbers
                        select new { Digit = d, Number = n };
            foreach (var item in query)
            {
                sb.Append(item.Digit).Append('\t').Append(item.Number).AppendLine();
            }
        }

        [Description("GroupBy, Filip Zajac")]
        public static void Test_FZ_04(StringBuilder sb)
        {
            string[] AsText = { "Even", "Odd" };
            var result = from n in numbers group n by n % 2 into groups select groups;
            foreach (var group in result)
            {
                sb.Append(AsText[group.Key]).Append(":");
                group.Aggregate(sb, (sb_, word) => sb_.Append(' ').Append(word));
                sb.AppendLine();
            }
        }

        [Description("Pierwsze 3 wartości, Mateusz Kinast")]
        public static void Test_MK_02(StringBuilder sb)
        {
            numbers.Take(3).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("ThenBy, Filip Zajac")]
        public static void Test_FZ_02(StringBuilder sb)
        {
            digits.OrderBy(d => d.Length).ThenBy(d => d).Aggregate(sb, (sb_, digit) => sb_.Append(digit).Append(' '));
        }

        [Description("Połączenie Dwóch Tablic, Natalia Wiśniewska")]
        public static void Test_NW_02(StringBuilder sb)
        {
            numbers.Select((v) => v.ToString()).Concat(digits).Aggregate(sb, (sb_, d) => sb_.Append(d).Append(' '));
        }

        [Description("Reverse, Filip Zajac")]
        public static void Test_FZ_01(StringBuilder sb)
        {
            numbers.Reverse().Aggregate(sb, (sb_, number) => sb_.Append(number).Append(' '));
        }

        [Description("Robi Dictionary prazystych i nieparzystych liczb, Roman Popadiuk")]
        public static void Test_RP_02(StringBuilder sb)
        {
            /*///
            string[] AsText = { "Divided by 3", "Mod 3 is 1", "Mod 3 is 2" };
            numbers.ToDictionary(k => k, v => AsText[v % AsText.Length]).Aggregate(sb, (sb_, d) => sb_.Append(d).AppendLine());
            /*/
            string[] AsText = { "Even", "Odd"};
            numbers.ToDictionary(k => k, v => AsText[v % 2]).Aggregate(sb, (sb_, d) => sb_.Append(d).AppendLine());
            //*///
            //numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even").Aggregate(sb, (sb_, d) => sb_.Append(d).AppendLine());
        }

        [Description("Any, Filip Zajac")]
        public static void Test_FZ_03(StringBuilder sb)
        {
            sb.Append(digits.Any(d => d.StartsWith("f"))).AppendLine();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            CallByName(sb, CbMethods.SelectedItem.ToString());
            TbLog.Text = sb.ToString();
        }
    }
}
