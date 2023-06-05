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
    public partial class LingTest : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5,4,1,3,9,8,6,7,2,0 };
        public static string TestA()
        {
            var shortDigits = digits.Where((digit,index) => digit.Length < index);
            StringBuilder sb = new StringBuilder();
            foreach (var item in shortDigits) sb.Append(item).Append(" ");
            return sb.ToString();
        }
        public static string TestB()
        {
            var numsConversion = from n in numbers select 100 + 2 * n;
            StringBuilder sb = new StringBuilder();
            foreach (var item in numsConversion) sb.Append(item).Append(" ");
            return sb.ToString();
        }
        public static string TestC()
        {
            var numsConversion = from n in numbers select new { n, n2 = n * n, n3 = n * n * n };
            StringBuilder sb = new StringBuilder();
            foreach (var item in numsConversion) sb.Append(item.n).Append("/").Append(item.n2).Append("/").Append(item.n3).Append(" ");
            return sb.ToString();
        }
        public static string TestD()
        {
            var lowNums = from n in numbers where (n&1)> 0 orderby n select digits[n];
            StringBuilder sb = new StringBuilder();
            foreach (var item in lowNums) sb.Append(item).Append(" ");
            return sb.ToString();
        }
        public static string TestUnion()
        {
            string[] add = { "ten", "eleven", "twellve" };
            var all = digits.Union(add);
            StringBuilder sb = new StringBuilder();
            foreach (var item in all) sb.Append(item).Append(" ");
            return sb.ToString();
        }
        public LingTest()
        {
            InitializeComponent();
            var lst
            =
               from proc in typeof(LingTest).GetMethods()
               where
                  proc.IsStatic &&
                  proc.ReturnType == typeof(string) &&
                  proc.GetParameters().Count() == 0
               select proc.Name
            ;
            foreach (var item in lst) TestList.Items.Add(item);
            TestList.SelectedIndex = 0;
        }
        private void BtnRun_Click(object sender, EventArgs e)
        {
            string name = (string)TestList.SelectedItem;
            MethodInfo method = typeof(LingTest).GetMethod(name);
            Log.AppendText(((string)method.Invoke(null, null)) + Environment.NewLine);
        }
    }
}
