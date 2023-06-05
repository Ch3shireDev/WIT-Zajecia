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
    public partial class LingMainForm : Form
    {
        private static List<string> allmethods = new List<string>();
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LingMainForm()
        {
            InitializeComponent();
            CbMethod.Items.Clear();
            var methods =
                typeof(LingMainForm).GetMethods()
                .Where((item) => item.IsStatic)
                .Where((item) => item.ReturnType == typeof(void))
                .Where((item) => item.GetParameters().Count() == 1)
                .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                .OrderBy((item) => item.Name)
                .Select((item) => item.Name)
            ;

            //foreach (var item in methods) CbTests.Items.Add(item);
            CbMethod.Items.AddRange(methods.ToArray());
            CbMethod.SelectedIndex = 0;
            allmethods.AddRange(methods.Where((name) => name != nameof(Call_All_Tests)));
        }

        [Description("Wywolanie wszystkich")]
        public static void Call_All_Tests(StringBuilder sb)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string name in allmethods)
            {
                MethodInfo method = typeof(LingMainForm).GetMethod(name);
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
            MethodInfo method = typeof(LingMainForm).GetMethod(name);
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

        [Description("Pierwszy i ostatni element w tablicy, Bartosz Demianiuk")]
        public static void TestBD_5(StringBuilder sb)
        {
            sb.Append("First: ").AppendLine(numbers.First().ToString());
            sb.Append("Last: ").AppendLine(numbers.Last().ToString());
        }

        [Description("Cyfry słownie, Klimaszewski Grzegorz")]
        public static void TestKG_05(StringBuilder sb)
        {
            //int[] numbers = { 0, 2, 3, 4, 5, 6, 7, 8, 9, };
            numbers.Select(digit => digits[digit]).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Pominięcie słów, dopóki warunek jest spełniony, Jakub Głogowski")]
        public static void Test_JG_4(StringBuilder sb)
        {
            string[] words = { "one", "two", "three", "four", "five" };
            words
                .SkipWhile(w => w.Length == 3)
                .Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '))
            ;
        }

        [Description("Parzyste i nieparzyste w tablicy, Klimaszewski Grzegorz")]
        public static void TestKG_03(StringBuilder sb)
        {
            sb.Append("Parzyste:");
            foreach (int number in numbers.Where(number => number % 2 == 0))
            {
                sb.Append(' ').Append(number);
            }
            sb.AppendLine();

            sb.Append("Nieparzyste:");
            foreach (int number in numbers.Where(number => number % 2 != 0))
            {
                sb.Append(' ').Append(number);
            }
            sb.AppendLine();
        }

        [Description("Sortowanie, najpierw według długości, a następnie alfabetycznie, Jakub Głogowski")]
        public static void Test_JG_3(StringBuilder sb)
        {
            /*///
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London", "Athens", "Beijing", "Seoul" };
            var result = capitals
                .OrderBy(c => c.Length)
                .ThenBy(c => c, StringComparer.Ordinal);
            foreach (string capital in result)
                sb.AppendLine(capital);
            /*/
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London", "Athens", "Beijing", "Seoul" };
            capitals
                .OrderBy(c => c.Length)
                .ThenBy(c => c)
                .Aggregate(sb, (psb, str) => psb.Append(str).Append(' '))
            ;
            //*///
        }

        [Description("Odwrócenie kolejności znaków, Jakub Głogowski")]
        public static void Test_JG_2(StringBuilder sb)
        {
            char[] characters = { 'e', 'a', 'a', 'e', 'l', 's' };
            foreach (char character in characters.Reverse())
                sb.Append(character.ToString()).Append(' ');
        }

        [Description("Minimum w tablicy, Klimaszewski Grzegorz")]
        public static void TestKG_01(StringBuilder sb)
        {
            sb.Append($"Min={numbers.Min()}");
        }

        [Description("Sortowanie tablicy, Aleksy Barski")]
        public static void TestAB_01(StringBuilder sb)
        {
            digits.OrderBy(str => str).Aggregate(sb, (psb, str) => psb.Append(str).Append(' '));
        }

        [Description("Filtrowanie tablicy, Aleksy Barski")]
        public static void TestAB_02(StringBuilder sb)
        {
            foreach(string s in digits.Where((str, index) => str.Length > index)) sb.Append(s).Append(' ');
        }
        [Description("Wypisanie elementów wspólnych z tablicy bazowej i tablicy pomocniczej, Klimaszewski Grzegorz")]
        public static void TestKG_06(StringBuilder sb)
        {
            int[] numberspom = { 0, 1, 6, 11 };
            numbers.Intersect(numberspom).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Wyświetlanie czy wartość 5 występuje tablicy, Bartosz Demianiuk")]
        public static void TestBD_7(StringBuilder sb)
        {
            sb.Append("For 5: ").AppendLine(numbers.Contains(5).ToString());
            sb.Append("For 13: ").AppendLine(numbers.Contains(13).ToString());
        }

        [Description("Połączenie dwóch tablic z wyłączeniem duplikatów, Klimaszewski Grzegorz")]
        public static void TestKG_07(StringBuilder sb)
        {
            int[] numberspom = { 33, 10, 11, 12, 1, 4, 7 };
            numbers.Union(numberspom).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }
        [Description("  Parzyste i Nieparzyste , Szymon Szpala")]
        public static void TestSS_05(StringBuilder sb)
        {
            string[] PN = { "Parzyste" , "Nieparzyste" };
            foreach(var group in numbers.GroupBy(n => n % 2))
            {
                group.Aggregate
                (
                    sb
                        .Append(PN[group.Key])
                        .Append(":"), (sb_, word) => sb_.Append(' ').Append(word)
                );
                sb.AppendLine();
            }
        }

        [Description("Grupowanie tablicy, Klimaszewski Grzegorz")]
        public static void TestKG_08(StringBuilder sb)
        {
            foreach (var group in numbers.GroupBy(number => number % 3 == 0))
            {
                sb.Append(group.Key ? "Podzielne 3: " : "Nie podzielne 3: ");
                sb.AppendLine(string.Join(", ", group));
            }
        }

        [Description("Usuwa zduplikowane elementy, Jakub Głogowski")]
        public static void Test_JG_5(StringBuilder sb)
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };
            numbers
                .Distinct().
                Aggregate(sb, (sb_, number) => sb_.Append(number).Append(' '))
            ;
        }

        [Description("Pierwsze 5 wartości z tablicy, Bartosz Demianiuk")]
        public static void TestBD_8(StringBuilder sb)
        {
            sb.Append(numbers.Take(5).Aggregate(sb, (psb, str) => psb.Append(str).Append(' ')));
        }

        [Description("Przekrztalcenie tablicy, Aleksy Barski")]
        public static void TestAB_03(StringBuilder sb)
        {
            var query = from n in numbers select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var item in query) sb.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
        }
		
		[Description("Grupowanie po długości słowa, Mateusz Skrzypik")]
        public static void TestMS_02(StringBuilder sb)
        {
            digits
                .GroupBy(digit => digit.Length)
                .Aggregate(sb, (sbAggregate, currentGroup) => 
                    sbAggregate
                        .Append("Długość: ")
                        .Append(currentGroup.Key)
                        .Append(" - Ilość: ")
                        .Append(currentGroup.Count())
                        .AppendLine());
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            TbLog.Text = CallByName(new StringBuilder(), CbMethod.SelectedItem.ToString());
        }
    }
}
