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
    public partial class LinqMainForm : Form
    {
        private static List<string> allmethods = new List<string>();
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqMainForm()
        {
            InitializeComponent();
            CbMethods.Items.Clear();
            var methods
            =
                typeof(LinqMainForm)
                .GetMethods()
                .Where(method => method.IsStatic)
                .Where(method => method.ReturnType == typeof(void))
                .Where(method => method.GetParameters().Count() == 1)
                .Where(method => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Select(method => method.Name)
                .OrderBy(method => method)
            ;
            CbMethods.Items.AddRange(methods.ToArray());
            CbMethods.SelectedIndex = 0;
            allmethods.AddRange(methods.Where(method => method != nameof(CallAllMethods)).ToArray());
        }

        [Description("Wywolanie wszystkich, Barski Aleksy")]
        public static void CallAllMethods(StringBuilder sb)
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
            if (name != nameof(CallAllMethods))
            {
                sb.Append($"============ {name} ============").Append(Environment.NewLine);
                sb.Append($"# {description}").Append(Environment.NewLine);
            }
            sb.Append(method.Invoke(null, new object[] { sb })).Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        [Description("Posortowana tablica, Barski Aleksy")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits
                .OrderBy(str => str)
                .Aggregate
                (
                    sb, 
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Filtrowanie tablicy, Barski Aleksy")]
        public static void Test_AB_02(StringBuilder sb)
        {
            digits
                .Where((str, index) => str.Length > index)
                .OrderBy(str => str)
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
            sb.AppendLine();
            digits
                .OrderBy(str => str)
                .Where((str, index) => str.Length > index)
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Przekrztalcenie tablicy, Barski Aleksy")]
        public static void TestAB_03(StringBuilder sb)
        {
            //var query = from n in numbers.OrderBy(num => num) select new { n, n2 = n * n, n3 = n * n * n };
            //foreach (var item in query) sb.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);

            (from n in numbers.OrderBy(num => num) select new { n, n2 = n * n, n3 = n * n * n })
                .Aggregate
                (
                    sb,
                    (sb_, item) => 
                        sb_.Append(item.n).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine)
                )
            ;
        }

        [Description("Słownie, Barski Aleksy")]
        public static void TestAB_04(StringBuilder sb)
        {
            numbers
                .Select(x => 7 * x * x + 5 * x + 3)
                .Select(x => new { key = x, value = x.ToString().ToArray() })
                .Select(rec => new { key = rec.key, value = rec.value.Select(d => digits[d - '0']) })
                .Select(rec => new { key = rec.key, value = String.Join(" ", rec.value) })
                .Aggregate
                (
                    sb,
                    (sb_, rec) =>sb_.Append(rec.key).Append('\t').Append(rec.value).AppendLine()
                )
            ;
        }

        [Description("Pomijanie pierwszego elementu (Skip), Czerniewicz Robert")]
        public static void Test_RC_01(StringBuilder sb)
        {
            digits
                .Skip(1)
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Odwrócenie tablicy lambda, Jakubiak Paweł")]
        public static void TestPJ_01(StringBuilder sb)
        {

            digits
                .Reverse()
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Wyszukiwanie przynajmniej jednego elementu, Brzeziński Michał")]
        public static void Test_MB_01(StringBuilder sb)
        {
            sb.Append($"Is there at least one even number? {numbers.Any(number => number % 2 == 0)}");
        }

        [Description("Średnia, Mutniański Robert")]
        public static void TestRM_01(StringBuilder sb)
        {
            sb.AppendLine(numbers.Average().ToString());
        }

        [Description("Metoda Take lambda, Jakubiak Paweł")]
        public static void TestPJ_03(StringBuilder sb)
        {
            numbers
                .Take(2)
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Pomijanie liczb aż do czwartej, Daniel Jurczak")]
        public static void Test_DJ_01(StringBuilder sb)
        {
            digits
            .SkipWhile(str => !str.Equals("four"))
            .Aggregate
            (
                sb,
                (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Powielenie wybranego elemntu tablicy, Kłos Damian")]
        public static void TestDK_01(StringBuilder sb)
        {
            Enumerable
                .Repeat(digits[2], 5)
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Laczenie dwoch tablic, Madej Kacper")]
        public static void TestKM_01(StringBuilder sb)
        {
            numbers
                .OrderBy(str => str)
                .Zip(digits, (n, d) => (new StringBuilder().Append(n).Append("->").Append(d)))
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("ToDictionary, Mutniański Robert")]
        public static void TestRM_02(StringBuilder sb)
        {
            digits
                .Zip(numbers.OrderBy(n => n), (key, value) => new { key, value })
                .ToDictionary(zip => zip.key, zip => zip.value)
                .Aggregate(sb, (sb_, item) => sb_.AppendLine($"{item.Key}\t{item.Value}"))
            ;
        }

        [Description("Sprawdzenie czy wszystkie elementy zawierają znak 'e', Czerniewicz Robert")]
        public static void Test_RC_02(StringBuilder sb)
        {
            sb.Append
            (
                digits.All(elem => elem.Contains("e")) ? "TAK" : "NIE"
            );
        }

        [Description("Metoda TakeWhile lambda, Jakubiak Paweł")]
        public static void TestPJ_04(StringBuilder sb)
        {
            numbers
                .TakeWhile(n => n < 7)
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Wygenerowanie liczb z zakresu, Daniel Jurczak")]
        public static void Test_DJ_02(StringBuilder sb)
        {
            Enumerable
                .Range(0, 5)
                .Aggregate
                (
                    sb,
                    (sb_, val) => sb_.Append(val).Append(' ')
                )
            ;
        }

        [Description("Zliczenie ile jest elementów wiekszych od 5 a ile nie, Czerniewicz Robert")]
        public static void Test_RC_03(StringBuilder sb)
        {
            var result =
            from n in numbers
            group n by (n > 5) into groups
            select groups;
            foreach (var group in result)
            {
                var word = group.Key ? "Wiekszych" : "Mniejszych/równych";
                sb.Append(word)
                .Append(" od 5: ")
                .Append(group.Count())
                .Append(Environment.NewLine);
            }
        }

        [Description("Usuwanie duplikatów, Bernard Czostek")]
        public static void TestBC_01(StringBuilder sb)
        {
            Enumerable
                .Range(0, digits.Length)
                .Concat(numbers)
                .Distinct()
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Ostatni element o dlugosci 5 znakow lub 'Brak 5-znakowca' (LastOrDefault), Czerniewicz Robert")]
        public static void Test_RC_04(StringBuilder sb)
        {
            var result = digits.LastOrDefault(elem => elem.Length == 5);
            sb.Append(result != null ? result : "Brak 5-znakowca");
        }

        [Description("Sortowanie po długości stringów a potem po drugiej literze, Mutniański Robert")]
        public static void TestRM_03(StringBuilder sb)
        {
            digits.OrderBy(digit => digit.Length).ThenBy(digit => digit[1])
            .Aggregate(sb, (sb_, item) => sb_.AppendLine(item));
        }

        [Description("Wygenerowanie słownika z warunkiem, Daniel Jurczak")]
        public static void Test_DJ_04(StringBuilder sb)
        {
            string[] Groups = { "Even", "Odd" };
            Enumerable.Range(0, digits.Length)
            .ToDictionary(number => digits[number], number => Groups[number % Groups.Length])
            .Aggregate
            (
                sb,
                (sb_, val) => sb_.Append($"{val.Key} - {val.Value}").Append(' ')
            )
            ;
        }

        [Description("Single")]
        public static void Test_KN_01(StringBuilder sb)
        {
            try
            {
                sb.Append("Tablica zawiera jeden element: " + digits.Single());
            }
            catch (Exception e)
            {
                sb.Append("Tablica pusta lub zawiera więcej niż 1 element");
            }
        }

        [Description("Metoda SequenceEqual, Jakubiak Paweł")]
        public static void TestPJ_06(StringBuilder sb)
        {
            sb.Append(digits.SequenceEqual(digits.Skip(2)));
        }

        [Description("Wyswietl 11-ty element lub 'Za mały zbiór' (ElementAtOrDefault), Czerniewicz Robert")]
        public static void Test_RC_05(StringBuilder sb)
        {
            var result = digits.ElementAtOrDefault(10);
            sb.Append(result != null ? result : "Za mały zbiór");
        }

        [Description("Union, Gruszkowski Bartosz")]
        public static void TestBG_05(StringBuilder sb)
        {
            numbers
                .Skip(3)
                .Union(numbers.Reverse().Skip(3))
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Intersect, Gruszkowski Bartosz")]
        public static void TestBG_06(StringBuilder sb)
        {
            numbers
                .Skip(3)
                .Intersect(numbers.Skip(3))
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(' '))
            ;
        }

        [Description("Wybranie liczb całkowitych z tablicy obiektów, Mutniański Robert")]
        public static void TestRM_04(StringBuilder sb)
        {
            digits
                .Cast<object>()
                .Concat(numbers.Cast<object>())
                .OfType<int>()
                .Cast<int>()
                .Aggregate(sb, (sb_, item) => sb_.AppendLine($"{item}\t{item.GetType()}"))
            ;
        }

        [Description("Select Many, Gruszkowski Bartosz")]
        public static void TestBG_04(StringBuilder sb)
        {
            digits
                .SelectMany(d => numbers, (d, n) => new { digits = d, numbers = n })
                .Aggregate(sb, (sb_, str) => sb_.Append(str).Append(Environment.NewLine))
            ;
        }

        [Description("Wartość domyślna jeżeli tablica jest pusta, Madej Kacper")]
        public static void TestKM_02(StringBuilder sb)
        {
            digits
                .Where((d) => d.Length > 10)
                .DefaultIfEmpty("Brak liczby wiekszej od 10")
                .Aggregate
                (
                    sb,
                    (sb_, str) => sb_.Append(str).Append(' ')
                )
            ;
        }

        [Description("Wyswietl o takiej samej długosci (ToLookup), Czerniewicz Robert")]
        public static void Test_RC_06(StringBuilder sb)
        {
            digits.ToLookup(w => w.Length)
                .OrderBy(group => group.Key)
                .Select(group => new { Key = group.Key, Value=String.Join(", ",group) })
                .Aggregate
                (
                    sb, 
                    (sb_, group) =>
                        sb_
                        .Append("O dlugosci ")
                        .Append(group.Key)
                        .Append(": ")
                        .Append(group.Value)
                        .Append(Environment.NewLine)
                )
            ;
        }

        [Description("First Conditional, Gruszkowski Bartosz")]
        public static void TestBG_07(StringBuilder sb)
        {
            try { sb.Append(digits.First(d => d.Length == 4)); }
            catch (ArgumentNullException e)
            {
                sb.Append("No elements matching condition");
            }
        }

        [Description("Except - wyświetla tylko te elementy pierwszej tablicy, które nie występują w drugiej, Kłodos Jacek")]
        public static void TestJK_01(StringBuilder sb)
        {
            var result = digits.Except(numbers.Select(n => digits[n]));
            sb.AppendLine(string.Join(Environment.NewLine, result));
        }

        [Description("Pierwsza wartość tablicy lub wartość domyślna, Madej Kacper")]
        public static void TestKM_03(StringBuilder sb)
        {
            String digit = digits.FirstOrDefault((d) => d.Length % 2 == 0 || d.Length > 3);
            sb.Append(digit == null?"Nie znaleziono szukanej wartości":digit);
        }

        [Description("concat, Dorota Boinska")]
        public static void Test_DB_01(StringBuilder sb)
        {
            numbers.Select(num => num.ToString()).Concat(digits).Aggregate(sb, (sb_, str) => sb_.Append(str).Append(","));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TbLog.Text = CallByName(new StringBuilder(), CbMethods.SelectedItem.ToString());
        }
    }
}
