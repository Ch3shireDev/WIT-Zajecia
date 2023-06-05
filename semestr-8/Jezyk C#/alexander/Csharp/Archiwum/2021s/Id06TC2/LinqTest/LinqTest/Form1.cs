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
        private static int[] myNumbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static char[] letters2 = "abcde".ToCharArray();
        private static char[] digits2 = "12345".ToCharArray();
        public Form1()
        {
            InitializeComponent();
            CbTests.Items.Clear();
            var methods =
                typeof(Form1).GetMethods()
                .Where((item) => item.IsStatic)
                .Where((item) => item.ReturnType == typeof(void))
                .Where((item) => item.GetParameters().Count() == 1)
                .Where((item) => item.GetParameters().First().ParameterType == typeof(StringBuilder))
                .OrderBy((item) => item.Name)
                .Select((item) => item.Name)
            ;

            //foreach (var item in methods) CbTests.Items.Add(item);
            CbTests.Items.AddRange(methods.ToArray());
            CbTests.SelectedIndex = 0;
            allmethods.AddRange(methods.Where((name) => name != nameof(Call_All_Tests)));
        }

        [Description("Sortowanie tablicy")]
        public static void Test_01(StringBuilder sb)
        {
            digits.OrderBy((key) => key).Aggregate(sb, (psb, digit) => psb.Append(digit).Append(' '));
            //foreach (string s in digits.OrderBy((key) => key).ToArray()) sb.Append(s).Append(' ');
            sb.AppendLine();
        }

        [Description("Dlugość slowa <= wartość")]
        public static void Test_02(StringBuilder sb)
        {
            foreach (string s in digits.Where((text, index) => text.Length <= index)) sb.Append(s).Append(' ');
            sb.AppendLine();
        }

        [Description("tablica n n^2 n^3")]
        public static void Test_03(StringBuilder sb)
        {
            var conversion = from n in numbers select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var s in conversion) sb.AppendFormat($"n1={s.n}, n2={s.n2}, n3={s.n3},").AppendLine();
        }

        [Description("nieparzyste słownie")]
        public static void Test_04(StringBuilder sb)
        {
            var list = from n in numbers where (n & 1) != 0 orderby n select digits[n];
            foreach (var s in list) sb.Append(s).Append(' ');
            sb.AppendLine();
        }

        [Description("sortowanie po dlugosci wyrazow")]
        public static void Test_05(StringBuilder sb) // CG
        {
            var list = from n in digits orderby n.Length select n;
            foreach (var s in list) sb.Append(s).Append(' ');
            sb.AppendLine();
        }

        [Description("wypisanie wyrazow o dlugosci 4 i większej")]
        public static void Test_06(StringBuilder sb) // CG
        {
            var list = from n in digits where n.Length >= 4 orderby n.Length select n;
            foreach (var s in list) sb.Append(s).Append(' ');
            sb.AppendLine();
        }

        [Description("Cartesian product")]
        public static void Test_07(StringBuilder sb) // CG
        {
            // Cartesian product
            var coords = from l in letters2 from d in digits2 select $"{l}{d}";
            foreach (var coord in coords)
            {
                sb.Append($"{coord} ");
                if (coord.EndsWith("5"))
                {
                    sb.AppendLine();
                }
            }
        }

        [Description("odwrocenie kolejnosci")]
        public static void Test_08(StringBuilder sb) //CG
        {
            var reversed = (from val in numbers select val).Reverse();
            sb.AppendLine(string.Join(", ", reversed));
        }

        [Description("Eliminuje duplikaty w tablicy")]
        public static void Test_09(StringBuilder sb) // RB
        {
            var result = (from n in myNumbers.Distinct()
                          orderby n
                          select n);
            foreach (int number in result)
            {
                sb.Append(number).Append(' ');
            }
            sb.AppendLine();
        }

        [Description("Wypisuje elementy, ktore znajduja tylko w tablicy numbers")]
        public static void Test_10(StringBuilder sb) // RB
        {
            var result = (from n in numbers.Except(myNumbers)
                          orderby n
                          select n);
            foreach (int number in result)
            {
                sb.Append(number).Append(' ');
            }
            sb.AppendLine();
        }

        [Description("Zbior wspolny")]
        public static void Test_11(StringBuilder sb) // RB
        {
            var result = (from n in numbers.Intersect(myNumbers)
                          orderby n
                          select n);
            foreach (int number in result)
            {
                sb.Append(number).Append(' ');
            }
            sb.AppendLine();
        }

        [Description("odwracanie kolejności liter w słowach")]
        public static void Test_12(StringBuilder sb)
        {
            var resultstring = digits.Select(c => new string(c.Reverse().ToArray())).ToArray();
            sb.AppendLine(string.Join(" ", resultstring));

            //foreach (var s in resultstring) sb.Append(s).Append(' ');
            //sb.AppendLine();
        }
        
		[Description("Minimum w tablicy, Klimaszewski Grzegorz")]
        public static void TestKG_01(StringBuilder sb)
        {
            sb.Append($"Min={numbers.Min()}");
        }

        [Description("Wywolanie wszystkich")]
        public static void Call_All_Tests(StringBuilder sb)
        {
            foreach (string name in allmethods) CallByName(sb,name);
        }

        private static string CallByName(StringBuilder sb,string name)
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

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            TxtLog.Text = CallByName(new StringBuilder(),CbTests.SelectedItem.ToString());
        }
    }
}
