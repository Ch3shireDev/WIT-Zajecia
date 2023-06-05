using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class LinqForm : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static List<string> all = new List<string>();
        public LinqForm()
        {
            InitializeComponent();
            var methods = typeof(LinqForm).GetMethods()
                .Where(m => m.IsStatic)
                .Where(m => m.ReturnType == typeof(string))
                .Where(m => m.GetParameters().Count() == 0)
                .Select(m => m.Name)
            ;
            foreach (var m in methods) LbMethods.Items.Add(m);
            all.AddRange(methods.Where(m => m != call_all));
            LbMethods.SelectedIndex = 0;
        }
        public static void call(StringBuilder sb, string m)
        {
            if (m != call_all) sb.Append(string.Format("============ {0} ============", m));
            sb
                .Append(Environment.NewLine)
                .Append(typeof(LinqForm).GetMethod(m).Invoke(null, null).ToString().Trim())
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
            ;
        }
        private static string call_all = "Test_All_Methods";
        public static string Test_All_Methods()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var m in all) call(sb, m);
            return sb.ToString();
        }
        public static string TestA()
        {
            StringBuilder sb = new StringBuilder();
            var list = digits.Where((word, index) => word.Length < index);
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
        }
        public static string TestB()
        {
            /*///
            StringBuilder sb = new StringBuilder();
            var list = from item in numbers where item > 0 select item * 10 + 109;
            foreach (var item in list) sb.Append(item).Append(' ');
            return sb.ToString();
            /*/
            return (from item in numbers where item > 0 select item * 10 + 109).Aggregate(new StringBuilder(), (sb, w) => sb.Append(w).Append(' ')).ToString();
            //*///
        }
        public static string TestC()
        {
            /*///
            StringBuilder sb = new StringBuilder();
            var list = from n in numbers orderby n select new { n1 = n, n2 = n * n, n3 = n * n * n };
            foreach (var item in list) sb.Append(item.n1).Append('\t').Append(item.n2).Append('\t').Append(item.n3).Append(Environment.NewLine);
            return sb.ToString();
            /*/
            return 
                (from n in numbers orderby n select new { n1 = n, n2 = n * n, n3 = n * n * n })
                .Aggregate(new StringBuilder(), (sb, w) => sb.Append(string.Format("{0}\t{1}\t{2}\t",w.n1,w.n2,w.n3)))
                .ToString()
            ;
            //*///
        }
        public static string TestD()
        {
            /*///
            StringBuilder sb = new StringBuilder();
            var list = digits.Select((w, i) => string.Format("{0}: {1}", i, w));
            foreach (var item in list) sb.Append(item).Append(Environment.NewLine);
            return sb.ToString();
            /*/
            return digits.Select((w, i) => string.Format("{0}: {1}", i, w)).Aggregate(new StringBuilder(), (sb, w) => sb.Append(w).Append(' ')).ToString();
            //*///
        }
        public static string TestE_Sebastian_Adamczyk()
        {
            /*///
            StringBuilder sb = new StringBuilder();
            var array = numbers.OrderByDescending(n => n);
            foreach (var i in array) sb.Append(i).Append(' ');
            return sb.ToString();
            /*/
            return numbers.OrderByDescending(n => n).Aggregate(new StringBuilder(), (sb, n) => sb.Append(n).Append(' ')).ToString();
            //*///
        }
        public static string TestG_Sebastian_Adamczyk()
        {
            return numbers.OrderBy(n => n).Zip(digits, (f, s) => f + " " + s).Aggregate(new StringBuilder(), (sb, i) => sb.Append(i).Append(Environment.NewLine)).ToString();
        }
        public static string TestE_Bartosz_Mika()
        {
            return digits.OrderBy(d => d.Length).ThenBy(d => d).Aggregate(new StringBuilder(), (sb, d) => sb.Append(d).Append(' ')).ToString();
        }
        public static string TestI_Bartosz_Mika()
        {
            return (digits.Where(d => d.Length > 1 && d[1] == 'i')).Reverse().Aggregate(new StringBuilder(), (sb, d) => sb.Append(d).Append(' ')).ToString();
        }
        public static string TestF()
        {
            return 
                digits
                .GroupBy(d => d.Length)
                .OrderBy(d => d.Key)
                .Select
                (
                    d => string.Format
                    (
                        "{0}: {1}", 
                        d.Key, 
                        d.OrderBy(i => i).Aggregate(new StringBuilder(), (sb, i) => sb.Append(i).Append(' ')).ToString()
                    )
                )
                .Aggregate(new StringBuilder(),(sb,w) => sb.Append(w).Append(Environment.NewLine))
                .ToString()
            ;
        }
        private void BtnCall_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            call(sb,LbMethods.SelectedItem.ToString());
            EdLog.AppendText(sb.ToString());
        }
    }
}
