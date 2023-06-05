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
            //var tb = from ch in test where '0' <= ch && ch <= '9' select ch - '0';
            //var indexes = from index in tb select digits[index];
            //var result = indexes.Aggregate((current, next) => current + " " + next);
            var result
            =
                test.
                Where(ch => '0' <= ch && ch <= '9').
                Select(ch => digits[ch - '0']).
                Aggregate((current, next) => current + " " + next)
            ;
            sb.Append(result);
        }
        public void TestWords(StringBuilder sb)
        {
            string test = "nine one seven   cow three five";
            var map 
            =
                digits.
                Select((word,index) => new { key=word, value=index }).
                ToDictionary(item => item.key,item => item.value.ToString())
            ;
            var result 
            =
                test.
                Split(" \t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries).
                Where(word => map.Keys.Contains(word)).
                Select(word => map[word]).
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
