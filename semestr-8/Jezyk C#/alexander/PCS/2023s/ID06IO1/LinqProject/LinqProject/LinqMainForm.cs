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

        [Description("Intersect - wybiera elementy które znajdują się w obu zbiorach, Oskar Jabłoński")]
        public static void Test_OJ_04(StringBuilder sb)
        {
            int[] numbers2 = { 1, 2, 3, 7, 9 };
            int[] numbers3 = { 0, 2, 3, 6, 8 };
            sb.AppendLine(numbers2.Intersect(numbers3).Aggregate(" ", (c, n) => c + n.ToString()));
        }

        [Description("SelectMany, Patryk Mazur")]
        public static void Test_PM_05(StringBuilder sb)
        {
            digits
                .SelectMany(f => numbers, (dig, num) => new { digit = dig, number = num })
                .Aggregate(sb.AppendLine("Select many: "), (sb_, num) => sb_.AppendLine($" {num.digit} {num.number}"))
            ;
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

        [Description("Sortowanie alfabetyczne, Aleksy Barski")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits
                .OrderBy(dig => dig)
                .Aggregate(sb.Append("digits:"), (sb_, dig) => sb_.Append(' ').Append(dig))
            ;
        }

        [Description("Odfiltrowane slowa, Aleksy Barski")]
        public static void Test_AB_02(StringBuilder sb)
        {
            digits
                .Where((dig,index) => dig.Length>index)
                .Aggregate(sb.Append("Odfiltrowane:"), (sb_, dig) => sb_.Append(' ').Append(dig))
            ;
        }

        [Description("Postać SQL, Aleksy Barski")]
        public static void Test_AB_03(StringBuilder sb)
        {
            var querty = from n in numbers.OrderBy(dig=>dig) select new { n, n2 = n * n, n3 = n * n * n };
            querty.Aggregate(sb.AppendLine("tablica:"), (sb_, item) => sb_.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).AppendLine());
        }

        [Description("Sumowanie liczb, Tymon Skalij")]
        public static void Test_TS_01(StringBuilder sb)
        {
            sb.Append("Suma liczb: ").Append(numbers.Sum());
        }

        [Description("GroupBy, Jan Ciszewski")]
        public static void Test_JC_01(StringBuilder sb)
        {
            string[] asText = { "podzielne przez 2", "niepodzielne przez 2" };
            numbers
                .OrderBy(d => d)
                .GroupBy(n => n % 2)
                .Select(g => asText[g.Key] + ": " + g.Aggregate("", (s, v) => s += v.ToString() + ' '))
                .Aggregate(sb, (sb_, s) => sb.Append(s).AppendLine())
            ;
        }

        [Description("Contains - czy w zbiorze danych znajduje się dany element, Oskar Jabłoński")]
        public static void Test_OJ_01(StringBuilder sb)
        {
            sb.Append("ten").Append(digits.Contains("ten") ? " =" : " nie").AppendLine(" znajduje się w zbiorze");
            sb.Append("seven").Append(digits.Contains("seven") ? "" : " nie").AppendLine(" znajduje się w zbiorze");
        }

        [Description("Element na indexie 2, Patryk Mazur")]
        public static void Test_PM_01(StringBuilder sb)
        {
            sb.AppendLine($"Element na indexie 2: {digits.ElementAt(2)}");
        }

        [Description("Weź pierwsze 5, Tymon Skalij")]
        public static void Test_TS_02(StringBuilder sb)
        {
            numbers.Take(5).Aggregate(sb.Append("Weź pierwsze 5:"), (sb_, dig) => sb_.Append(' ').Append(dig));
        }

        [Description("Wybieranie z listy elementów typu string, Barbara Rybak")]
        public static void Test_BR_01(StringBuilder sb)
        {
            object[] mixList = { "zero", 0, "one", 1, "two", 2, "three", 3, "four", 4, "five", 5, "six", 6, "seven", 7, "eight", 8, "nine", 9 };
            var result = mixList.OfType<string>();
            result.Aggregate
            (
                sb.Append("Elementy typy string: ").AppendLine(),
                (sb_, item) => sb_.Append(item).AppendLine()
            );
        }

        [Description("Single, Patryk Mazur")]
        public static void Test_PM_02(StringBuilder sb)
        {
            string[] digits2 = { "one digit" };
            try
            {
                sb.AppendLine($"Jedyny element to: {digits2.Single()}");
                sb.AppendLine($"Jedyny element to: {digits.Single()}");
            }
            catch (Exception e)
            {
                sb.Append(e.Message);
            }
        }

        [Description("Czy jakikolwiek spełnia warunek, Tymon Skalij")]
        public static void Test_TS_03(StringBuilder sb)
        {
            sb.Append("Czy jakikolwiek zaczyna się na f: ").Append(digits.Any(n => n.StartsWith("f"))).AppendLine();
            sb.Append("Czy jakikolwiek zaczyna się na m: ").Append(digits.Any(n => n.StartsWith("m"))).AppendLine();
        }

        [Description("First - wyświetlanie pierwszego elementu ze zbioru, Oskar Jabłoński")]
        public static void Test_OJ_02(StringBuilder sb)
        {
            sb.AppendLine(digits.First().ToString());
            sb.AppendLine(numbers.OrderBy(n => n).First(n => n % 4 == 0).ToString());
            sb.AppendLine(digits.First(d => d == "two"));
        }

        [Description("GroupBy, Jan Ciszewski")]
        public static void Test_JC_02(StringBuilder sb)
        {
            /*///
            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 4 };
            lista.Concat(numbers).OrderBy(d => d)
            .GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Select(g => "duplikaty: " + g.Aggregate("", (s, v) => s + v.ToString() + ' '))
            .Aggregate(sb, (sb_, s) => sb.Append(s).AppendLine());
            /*/
            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 4 };
            lista.Concat(numbers).OrderBy(d => d)
            .GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Aggregate(sb, (sb_, g) => sb.Append(g.Key + " => " + g.Count()).AppendLine());
            //*///
        }


        [Description("Wszystkie słowa napisane od tyłu, Karol Kapecki")]
         public static void Test_KK_01(StringBuilder sb)
        {
            digits.Aggregate(sb.AppendLine("tablica:"), (sb_, word) => sb_.Append(word).Append('\t').Append(word.ToArray().Reverse().ToArray()).AppendLine());
        }

        [Description("Wszystkie słowa, ale pierwsze 3 pominięte, Karol Kapecki")]
        public static void Test_KK_02(StringBuilder sb)
        {
            digits.Skip(4).Aggregate(sb.AppendLine("wybrane:"), (sb_, word) => sb_.Append(word).AppendLine());
        }

        [Description("Wypisz pierwszy element 5 razy, Tymon Skalij")]
        public static void Test_TS_04(StringBuilder sb)
        {
            //var query = Enumerable.Repeat("13", 5);
            //query.Aggregate(sb.Append("5x pierwszy element:"), (sb_, num) => sb_.Append(' ').Append(num));
            sb.Append(Enumerable.Repeat('*', 7).ToArray()).AppendLine();
        }

        [Description("Unia dwóch kolekcji, Tymon Skalij")]
        public static void Test_TS_05(StringBuilder sb)
        {
            int[] lista = { 1, 11, 5, 10, 0, 6, 7 };
            lista
                .Union(numbers)
                .Aggregate
                (
                    sb.Append("Unia dwóch kolekcji:"), 
                    (sb_, num) => sb_.Append(' ').Append(num)
                )
            ;
        }

        [Description("SequenceEqual, Patryk Mazur")]
        public static void Test_PM_03(StringBuilder sb)
        {
            sb.AppendLine($"Czy kolekcj digits równa się kolekcji digits: {digits.SequenceEqual(digits)}");
            sb.AppendLine($"Czy kolekcj digits równa się posortowanej kolekcji digits: {digits.SequenceEqual(digits.OrderBy(d => d))}");
        }

        [Description("GroupBy, Jan Ciszewski")]
        public static void Test_JC_03(StringBuilder sb)
        {
            numbers
                .Where(n => n <= 7)
                .Select(n => n*10)
                .Zip(numbers, (a, b) => a + b).OrderBy(d => d)
                .GroupBy(n => n)
                .Aggregate(sb, (sb_, g) => sb.Append("wynik: " + g.Aggregate("", (s, v) => s + v.ToString())).AppendLine())
            ;
        }

        [Description("Zwracanie wspólnych elementów zbiorów, Barbara Rybak")]
        public static void Test_BR_02(StringBuilder sb)
        {
            string[] pojazdy = { "samochód", "osioł", "rower", "koń" };
            string[] zwierzeta = { "koń", "krowa", "osioł" };
            pojazdy
                .Join(zwierzeta, zwierze => zwierze, pojazd => pojazd, (zwierze, pojazd) => zwierze)
                .Aggregate
                (
                    sb.Append("Pojazdy będące zwierzętami: ").AppendLine(),
                    (sb_, item) => sb_.Append(item).AppendLine()
                )
            ;
        }

        [Description("GroupBy, Jan Ciszewski")]
        public static void Test_JC_04(StringBuilder sb)
        {
            sb.Append(digits.All(d => d.Length >= 3));
        }

        [Description("Zwracanie elementów zbioru 1, kttóre nie występują w zbiorze 2, Barbara Rybak")]
        public static void Test_BR_03(StringBuilder sb)
        {
            string[] pojazdy = { "samochód", "osioł", "rower", "koń" };
            string[] zwierzeta = { "koń", "krowa", "osioł" };

            pojazdy
                .Except(zwierzeta)
                .Aggregate
                (
                    sb.Append("Pojazdy będące zwierzętami: ").AppendLine(),
                    (sb_, item) => sb_.Append(item).AppendLine()
                )
            ;
        }

        [Description("Pomija, aż dojdzie do słowa o długości innej niż 4, Karol Kapecki")]
        public static void Test_KK_03(StringBuilder sb)
        {
            digits.SkipWhile(w => w.Length == 3).Aggregate(sb.AppendLine("wybrane:"), (sb_, word) => sb_.Append(word).AppendLine());
        }

        [Description("Sortowanie listy w pierwszej kolejności po długości, w drugiej alfabetycznie, Barbara Rybak")]
        public static void Test_BR_04(StringBuilder sb)
        {
            digits
                .OrderBy(w => w.Length)
                .ThenBy(w => w)
                .Aggregate
                (
                    sb.Append("Sortowanie po długości, potem po alfabecie: ").AppendLine(),
                    (sb_, item) => sb_.Append(item).AppendLine()
                )
            ;
        }

        [Description("Where, Patryk Mazur")]
        public static void Test_PM_04(StringBuilder sb)
        {
            numbers
                .Where((n, i) => n % 3 == 0 && i >= 5)
                .Aggregate(sb.AppendLine("Liczby podzielna przez 3 z indexem >= 5: "), (sb_, num) => sb_.Append(' ').Append(num))
            ;
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TbLog.Text = CallByName(new StringBuilder(), CbMethods.SelectedItem.ToString());
        }
    }
}
