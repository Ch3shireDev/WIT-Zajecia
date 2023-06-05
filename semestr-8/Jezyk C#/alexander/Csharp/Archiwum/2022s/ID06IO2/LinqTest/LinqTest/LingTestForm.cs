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
    public partial class LingTestForm : Form
    {
        private static string[] AllTest;
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LingTestForm()
        {
            InitializeComponent();
            var methods =
                typeof(LingTestForm).GetMethods()
                .Where
                (
                    method =>
                    method.IsStatic &&
                    method.ReturnType == typeof(void) &&
                    method.GetParameters().Count() == 1 &&
                    method.GetParameters().First().ParameterType == typeof(StringBuilder) &&
                    method.GetCustomAttributes(typeof(DescriptionAttribute)).Any()
                )
                .Select(method => method.Name)
                .OrderBy(name => name)
            ;
            AllTest = methods.Where(name => name != nameof(Run_All_Tests)).ToArray();
            CbMethods.Items.AddRange(methods.ToArray());
            CbMethods.SelectedIndex = 0;
            StringBuilder sb = new StringBuilder();
            methods.Aggregate(sb, (sb_, name) => sb_.AppendLine(name));
            TbLog.Text = sb.ToString();
        }

        public static void CallByName(string name,StringBuilder sb)
        {
            MethodInfo method = typeof(LingTestForm).GetMethod(name);
            string description = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description;
            if (name != nameof(Run_All_Tests))
            {
                sb.AppendLine(name);
                sb.AppendLine(description);
            }
            method.Invoke(null, new object[] { sb });
            sb.AppendLine("-----------------------------------");
            sb.AppendLine();
        }

        [Description("!!! Wszystkie Testy")]
        public static void Run_All_Tests(StringBuilder sb)
        {
            foreach (string name in AllTest) CallByName(name, sb);
        }

        [Description("Sortuje słowa alfabetycznie AB 01")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy((dig) => dig).Aggregate(sb, (sb_, dig) => sb_.Append(dig).Append(' '));
        }

        struct Person { public string Surname; public int Age; }
        public static void Test_AB_02(StringBuilder sb)
        {
            Person[] tb = new Person[] { new Person { Surname = "Kowalski", Age = 30 }, new Person { Surname = "Nowak", Age = 25 } };

            tb.OrderBy((person) => person.Surname).Aggregate(sb, (_sb, person) => _sb.Append(person.Surname).Append('\t').Append(person.Age).AppendLine());
            sb.AppendLine();
            tb.OrderBy((person) => person.Age).Aggregate(sb, (_sb, person) => _sb.Append(person.Age).Append('\t').Append(person.Surname).AppendLine());
        }

        public static void Test_AB_03(StringBuilder sb)
        {
            numbers.Select(num => digits[num]).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        public static void Test_AB_04(StringBuilder sb)
        {
            digits.Where((num,index) => num.Length < index).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        public static void Test_AB_05(StringBuilder sb)
        {
            var Table = from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var row in Table) sb.AppendFormat("{0}\t{1}\t{2}", row.n, row.n2, row.n3).AppendLine();
        }

        [Description("Wyświetla słowa których numer jest największy i najmniejszy MW 01")]
        public static void Test_MW_01(StringBuilder sb)
        {
            var x = numbers.Select(num => digits[num]);
            sb.AppendFormat("Max Value: {0}, Min Value: {1}", x.Max(), x.Min());
        }

        [Description("Pierwszy element o długości 4 KM 01")]
        public static void Test_KM_01(StringBuilder sb)
        {
            var result = digits.First(c => c.Length == 4);
            sb.Append(result);
        }

        private static int[] numbers2 = { 1, 3, 0, 3, 6, 0 };
        [Description("Wybiera elementy występujące w numbers i numbers2 TB 01")]
        public static void Test_TB_01(StringBuilder sb)
        {
            numbers.Intersect(numbers2).Aggregate(sb, (sb_, dig) => sb_.Append(dig).Append(' '));
        }

        [Description("Usuwa wartości powtarzających się w drugiej tablicy JK 01")]
        public static void Test_JK_01(StringBuilder sb)
        {
            int[] numbers2 = { 1, 2, 3, 4 };
            numbers.Except(numbers2).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Wybiera parzyste liczby z nazwą mającą parzystą liczbą znaków TB 02")]
        public static void Test_TB_02(StringBuilder sb)
        {
            numbers.Where((x) => x % 2 == 0).Where((x) => digits[x].Length % 2 == 0).Aggregate(sb, (sb_, dig) => sb_.Append(dig).Append(' '));
        }

        [Description("Wyświetla parę dla elementu listy z następnym elementem MWy 01")]
        public static void Test_MWy_01(StringBuilder sb)
        {
            List<int> numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            numbers.Where((e, i) => i < numbers.Count - 1).Select((e, i) => new { A = e, B = numbers[i + 1] }).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            CallByName(CbMethods.SelectedItem.ToString(),sb);
            TbLog.Text = sb.ToString();
        }
    }
}
