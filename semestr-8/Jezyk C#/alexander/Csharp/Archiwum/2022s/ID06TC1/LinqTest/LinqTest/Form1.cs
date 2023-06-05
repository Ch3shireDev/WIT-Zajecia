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
    public partial class Form1 : Form
    {
        private static string[] AllTest;
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        public Form1()
        {
            InitializeComponent();
            var methods
            =
                typeof(Form1)
                .GetMethods()
                .Where(method => method.IsStatic)
                .Where(method => method.ReturnType == typeof(void))
                .Where(method => method.GetParameters().Count() == 1)
                .Where(method => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Where(method => method.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                .OrderBy(method => method.Name)
            ;
            AllTest = methods.Where(method => method.Name != nameof(RunAllTests)).Select(method => method.Name).ToArray();
            CbMethods.Items.AddRange(methods.Select(method => $"{method.Name}: {(method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description}").ToArray());
            CbMethods.SelectedIndex = 0;
            StringBuilder sb = new StringBuilder();
            methods.Where(method => method.Name != nameof(RunAllTests)).Aggregate(sb, (sb_, method) => sb_.AppendLine($"{method.Name}: {(method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description }"));
            TbLog.Text = sb.ToString();
        }

        public static void CallByName(string name,StringBuilder sb)
        {
            MethodInfo method = typeof(Form1).GetMethod(name);
            string description = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description;
            if (name != nameof(RunAllTests)) sb.AppendLine($"{name}: {description}");
            method.Invoke(null, new object[] { sb });
            if (name != nameof(RunAllTests))
            {
                sb.AppendLine();
                sb.AppendLine("------------------------");
                sb.AppendLine();
            }
        }

        [Description("Wszystkie testy")]
        public static void RunAllTests(StringBuilder sb)
        {
            foreach (string name in AllTest) CallByName(name, sb);
        }

        [Description("Posortowane słowa")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy(word => word).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Cyfry słownie")]
        public static void Test_AB_02(StringBuilder sb)
        {
            numbers.Select(digit => digits[digit]).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Tablica potęg")]
        public static void Test_AB_03(StringBuilder sb)
        {
            numbers.OrderBy(digit => digit).Select(n1 => new {n1, n2=n1*n1, n3=n1*n1*n1}).Aggregate(sb, (sb_, s) => sb_.AppendFormat("{0}\t{1}\t{2}",s.n1,s.n2,s.n3).AppendLine());
        }

        [Description("Iloczyn")]
        public static void Test_AB_04(StringBuilder sb)
        {
            sb.Append(numbers.Aggregate(1, (pr, num) => pr * num));
        }

        [Description("Nazwa oraz długość")]
        public static void Test_AB_05(StringBuilder sb)
        {
            var list = from n in digits orderby digits select $"{n}\t{n.Length}";
            list.Aggregate(sb, (sb_, word) => sb_.AppendLine(word));
        }

        [Description("Minimum i Maximum")]
        public static void Test_JG_01(StringBuilder sb)
        {
            sb.Append($"Min={numbers.Min()}; Max={numbers.Max()};");
        }

        [Description("Sprawdź czy dana tablica ma wartości powtarzające się w drugiej tablicy.Wypisuje tylko te wartości")]
        public static void Test_MO_06(StringBuilder sb)
        {
            int[] numbers2 = { 0, 1, 6 };
            numbers.Intersect(numbers2).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Parzyste i nieparzyste")]
        public static void Test_KB_10(StringBuilder sb)
        {
            var result = numbers.GroupBy(numbers => (numbers % 2 == 0));
            sb.AppendLine();
            foreach (IGrouping<bool, int> group in result)
            {
                sb.Append(group.Key ? "Parzyste:" : "Nieparzyste:");
                foreach (int number in group) sb.Append(' ').Append(number);
                sb.AppendLine();
            }
        }

        [Description("Policz od do")]
        public static void Test_MM_01(StringBuilder sb)
        {

            Enumerable.Range(0, 10).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' ')); ;
        }

        [Description("Łączy dwie tablice w jedną bez duplikatów")]
        public static void Test_MO_07(StringBuilder sb)
        {
            int[] numbers2 = { 10, 11, 12, 1, 4 };
            numbers.Union(numbers2).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Usuwa wartości ,które powtarzają się w drugiej tablicy MM 01")]
        public static void Test_MMi_01(StringBuilder sb)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            numbers.Except(numbers1).Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Wartości w odwrotnej kolejności")]
        public static void Test_BJ_09(StringBuilder sb)
        {
            numbers.Reverse().Aggregate(sb, (sb_, word) => sb_.Append(word).Append(' '));
        }

        [Description("Wybiera elementy ,które występują w numbers i numbers1 MM 01")]
        public static void Test_MM_02(StringBuilder sb)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            numbers.Intersect(numbers1).Aggregate(sb, (sb_, dig) => sb_.Append(dig).Append(' '));
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string[] pair = CbMethods.SelectedItem.ToString().Split(":".ToCharArray());
            string name = pair[0];
            CallByName(name,sb);
            TbLog.Text = sb.ToString();
        }
    }
}
