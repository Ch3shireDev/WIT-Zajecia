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

namespace LingTest
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
                typeof(LinqMainForm)
                .GetMethods()
                .Where((item) => item.IsStatic)
                .Where((item) => item.ReturnType == typeof(void))
                .Where((item) => item.GetParameters().Count() == 1)
                .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Select((item) => item.Name)
                .OrderBy((item) => item)
            ;

            //foreach (var item in methods) CbTests.Items.Add(item);
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
            sb.Append(method.Invoke(null, new object[] { sb })).Append(Environment.NewLine).Append(Environment.NewLine);
            return sb.ToString();
        }

        [Description("Sortowanie tablicy, Barski Aleksy")]
        public static void Test_BA_01(StringBuilder sb)
        {
            digits
                .OrderBy(str => str)
                .Where((str, idx) => (idx & 1) == 0)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Filtrowanie, Barski Aleksy")]
        public static void Test_BA_02(StringBuilder sb)
        {
            //foreach (string s in digits.Where((str, index) => str.Length > index)) sb.Append(s).Append(' ');
            digits
                .OrderBy(str => str)
                .Where((str, index) => str.Length > index)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
            sb.AppendLine();
            digits
                .Where((str, index) => str.Length > index)
                .OrderBy(str => str)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }
        
        [Description("Przekrztalcenie tablicy, Barski Aleksy")]
        public static void Test_BA_03(StringBuilder sb)
        {
            (from n in numbers.OrderBy(num => num) select new { n, n2 = n * n, n3 = n * n * n })
                .Aggregate
                (
                    sb, 
                    (sb_, item) => sb_.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine)
                )
            ;
        }

        [Description("Max, Obłoza Dominik")]
        public static void Test_OB_01(StringBuilder sb)
        {
            sb.Append("Last Value: ").Append(numbers.Last());
        }

        [Description("ZIP, Kopyto Sebastian")]
        public static void Test_KS_01(StringBuilder sb)
        {
            digits
            .Zip(numbers.OrderBy(str => str), (digit, number) => $"Tab[{number}]='{digit}';")
            .Aggregate(sb, (sb_, str) => sb_.AppendLine(str));
        }

        [Description("Użycie operatora Union, Atrasik Dominik")]
        public static void Test_DA_01(StringBuilder sb)
        {
            digits
                .Union(numbers.Select(number => number.ToString()))
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(" "))
            ;
        }

        [Description("Does any of the names start with the letter, Krzysztofowicz Jan ")]
        public static void Test_KJ_03(StringBuilder sb)
        {
            sb
                .Append(digits.Any(d => d.StartsWith("Z")))
                .AppendLine()
                .Append(digits.Any(d => d.StartsWith("z")))
            ;
        }

        [Description("Skip, Urbanowski Mieszko")]
        public static void Test_UM_01(StringBuilder sb)
        {
            digits.Skip(6).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine));
        }

        [Description("TakeWhile, Drozdowicz Maciej")]
        public static void Test_DM_03(StringBuilder sb)
        {
            numbers
                .TakeWhile(num => num < 9)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Range - Odliczanie od 0 do 4, Krolikowski Wojciech")]
        public static void Test_KW_01(StringBuilder sb)
        {
            Enumerable.Range(0, 5)
                .Aggregate(sb, (sb_, n) => sb_.Append(n).Append(Environment.NewLine))
            ;
        }

        [Description("OrderByDescending, Urbanowski Mieszko")]
        public static void Test_UM_02(StringBuilder sb)
        {
            numbers
                .OrderByDescending(num => num)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine))
            ;
        }

        [Description("Distinct, Szymborski Marcin")]
        public static void Test_SZM_Distinct(StringBuilder sb)
        {
            numbers.Select(n => n / 2).Distinct().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '));
        }

        [Description("Intersect, Szymborski Marcin")]
        public static void Test_SZM_Intersect(StringBuilder sb)
        {
            numbers.Intersect(numbers.Select(n => n + 2)).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' ')); ;
        }

        [Description("Concat, Damian Lewandowski")]
        public static void Test_DL_01(StringBuilder sb)
        {
            numbers
                .Concat(numbers.Select(num => num * 2))
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Except, Obłoza Dominik")]
        public static void Test_OB_02(StringBuilder sb)
        {
            numbers
                .Except(numbers.Select(num => num * 2))
                .Aggregate(sb, (sb_, num) => sb_.Append(num).Append(' '))
            ;
        }

        [Description("Wybranie każdej wartosci z tabeli i miks ich, Krolikowski Wojciech")]
        public static void Test_KW_02(StringBuilder sb)
        {
            numbers
                .SelectMany(n => digits, (n, d) => new { Number = n, Digit = d })
                .Aggregate(sb, (sb_, item) => sb_.Append(item.Number).Append('\t').Append(item.Digit).Append(Environment.NewLine))
            ;
        }

        [Description("Użycie operatora OfType, Atrasik Dominik")]
        public static void Test_DA_02(StringBuilder sb)
        {
            var mixed=digits
                .Select(digits => (object)digits)
                .Concat(numbers.Select(number => (object)number))
            ;
            mixed.OfType<string>().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(" "));
            sb.AppendLine();
            mixed.OfType<int>().Aggregate(sb, (sb_, str) => sb_.Append(str).Append(" "));
        }

        [Description("Odwrócenie tablicy, Krolikowski Wojciech")]
        public static void Test_KW_03(StringBuilder sb)
        {
            digits
                .Reverse()
                .Aggregate(sb, (sb_, item) => sb_.Append(item).Append(Environment.NewLine))
            ;
        }

        [Description("DefaultIfEmpty - zwróć 999 dla pustej tablicy, Obłoza Dominik")]
        public static void Test_OB_03(StringBuilder sb)
        {
            numbers
                .Where((item, index) => index == -1)
                .DefaultIfEmpty(999)
                .Aggregate(sb, (sb_, num) => sb_.Append(num).Append(' '))
            ;
        }

        [Description("SkipWhile, Urbanowski Mieszko")]
        public static void Test_UM_03(StringBuilder sb)
        {
            digits
                .SkipWhile(str => str != "seven")
                .SkipWhile(str => str.Length == 5)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine))
            ;
        }

        [Description("Sequence equal - numbers nie posortowane vs posortowane, Walkowiak Jeremiasz")]
        public static void Test_WJ_02(StringBuilder sb)
        {
            sb.Append(numbers.SequenceEqual(numbers.OrderBy(n => n)));
        }

        [Description("Takes numbers one by one, and stops when condition is no longer met:,Krzysztofowicz Jan ")]
        public static void Test_KJ_04(StringBuilder sb)
        {
            numbers
                .TakeWhile(n => n < 7)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine))
            ;
        }

        [Description("OrderBy + thenBy sortowanie po dlugosci oraz następnie po 1 i 2 literze, Drozdowicz Maciej")]
        public static void Test_DM_06(StringBuilder sb)
        {
            digits
                .OrderBy(d => d.Length)
                .ThenBy(d => d[0])
                .ThenBy(d => d[1])
                .Aggregate(sb, (sb_, str) => sb_.AppendLine(str))
            ;
        }

        [Description("Sprawdzanie czy liczba parzysta, Serwanski Tomasz")]
        public static void Test_ST_02(StringBuilder sb)
        {
            string[] odd = { "parzysta", "nieparzysta" };
            numbers
                .OrderBy(num => num)
                .ToDictionary(k => k, v => odd[v % 2])
                .Aggregate
                (
                    sb, 
                    (sb_, pair) => sb_.AppendLine($"{pair.Key} jest {pair.Value}")
                )
            ;
        }

        [Description("Repeat, Damian Lewandowski")]
        public static void Test_DL_02(StringBuilder sb)
        {
            digits
                .Select((v, i) => Enumerable.Repeat(v,i+1))
                .Select(v => String.Join(" ",v))
                .Aggregate(sb, (sb_, str) => sb_.AppendLine(str))
            ;
        }

        

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TbLog.Text = CallByName(new StringBuilder(), CbMethods.SelectedItem.ToString());
        }
    }
}
