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
    delegate void TestProc(StringBuilder sb);
    public partial class LingForm : Form
    {
        /*A*/private List<MethodInfo> all=new List<MethodInfo>();
        public LingForm()
        {
            InitializeComponent();
            var methods = typeof(LingForm).GetMethods().
                Where(item => !item.IsStatic).
                Where(item => item.ReturnType == typeof(void)).
                Where(item => item.GetParameters().Count() == 1).
                Where(item => item.GetParameters()[0].ParameterType == typeof(StringBuilder)).
                Select(item => item.Name);
            foreach (var item in methods) BoxTest.Items.Add(item);
            /*B*/foreach (var item in methods) if (item != "TestAllOfThem") all.Add(typeof(LingForm).GetMethod(item));
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
        public void TestNumber(StringBuilder sb)
        {
            string test = "97135";
            var str = (from ch in test where '0'<=ch && ch<='9' select digits[ch - '0'] + " ").Aggregate((current,next) => current+=next);
            sb.Append(str);
        }
        public void TestString(StringBuilder sb)
        {
            string test = "nine seven one three five";
            var dig = digits.ToList();
            /*
            var split = from word in test.Split(" \t".ToArray()) select dig.IndexOf(word);
            var dg = from index in split where index >= 0 select index.ToString();
            var str = dg.Aggregate((current, next) => current += next);
            */
            var str
            =
                (
                 from index in
                     from word in test.Split(" \t".ToArray()) select dig.IndexOf(word)
                 where index > 0
                 select index.ToString()
                ).Aggregate((current, next) => current += next)
            ;
            sb.Append(str);
        }

        /*C*/
        public void TestAllOfThem(StringBuilder sb)
        {
            foreach (var method in all)
            {
                method.Invoke(this, new object[] { sb });
                sb.Append(Environment.NewLine);
            }
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = (string)BoxTest.Items[BoxTest.SelectedIndex];
            MethodInfo method = typeof(LingForm).GetMethod(name);
            method.Invoke(this, new object[] { sb });
            Log.Text = sb.ToString();
        }
        //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
    }
}
