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
    public partial class LinqForm : Form
    {
        private List<MethodInfo> all = new List<MethodInfo>();
        public LinqForm()
        {
            InitializeComponent();
            var methods = typeof(LinqForm).GetMethods().
                Where(item => !item.IsStatic).
                Where(item => item.ReturnType == typeof(void)).
                Where(item => item.GetParameters().Count() == 1).
                Where(item => item.GetParameters()[0].ParameterType == typeof(StringBuilder)).
                Select(item => item.Name);
            foreach (var item in methods) BoxTest.Items.Add(item);
            foreach (var item in methods) if (item != "TestAllOfThem") all.Add(typeof(LinqForm).GetMethod(item));
            BoxTest.SelectedIndex = 0;
        }
        private string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public void TestA(StringBuilder sb)
        {
            var shortDigits = digits.Where((digit, index) => digit.Length<index);
            foreach (var item in shortDigits) sb.Append(item).Append(" ");
        }
        public void TestB(StringBuilder sb)
        {
            var numConv = from n in numbers select 100 + 2 * n;
            foreach (var item in numConv) sb.Append(item).Append(" ");
        }
        public void TestC(StringBuilder sb)
        {
            var numConv = from n in numbers select new { n,value = 100 + 2 * n };
            foreach (var item in numConv) sb.Append(item.n).Append(":").Append(item.value).Append(" ");
        }
        public void TestD(StringBuilder sb)
        {
            var lowNum = from n in numbers where n <= 6 && n%2 > 0  select digits[n];
            foreach (var item in lowNum) sb.Append(item).Append(" ");
        }
        public void TestDigits(StringBuilder sb)
        {
            string test = "91735";
            var words = from ch in test where '0' <= ch && ch <= '9' select digits[ch - '0'];
            var result = words.Aggregate((current, next) => current + " " + next).Trim();
            sb.Append(result);
        }
        public void TestWords(StringBuilder sb)
        {
            string test = "nine one seven three five";
            /*
            var list = test.Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var indexes = list.Select(word => Array.IndexOf(digits,word));
            var filtered = indexes.Where(index => index >= 0);
            var strings = filtered.Select(index => index.ToString());
            var result = strings.Aggregate((current, next) => current + next);
            */
            var result 
            =
                test.Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries).
                Select(word => Array.IndexOf(digits, word)).
                Where(index => index >= 0).
                Select(index => index.ToString()).
                Aggregate((current, next) => current + next)
            ;
            sb.Append(result);
        }
        public void TestAllOfThem(StringBuilder sb)
        {
            Log.Clear();
            foreach (var method in all)
            {
                method.Invoke(this, new object[] { sb });
                sb.Append(Environment.NewLine);
            }
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //string name = (string)BoxTest.Items[BoxTest.SelectedIndex];
            string name = BoxTest.SelectedItem.ToString();
            MethodInfo method = typeof(LinqForm).GetMethod(name);
            method.Invoke(this, new object[] { sb });
            Log.AppendText(sb.ToString() + Environment.NewLine);
        }
        //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
    }
}
