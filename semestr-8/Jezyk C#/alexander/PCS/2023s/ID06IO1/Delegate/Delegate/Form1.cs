using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    delegate double Recalc(double value);
    delegate void Append(string str);
    public partial class Form1 : Form
    {
        event Append append;
        public Form1()
        {
            InitializeComponent();
            append += App1;
            append += App2;
            append += App3;
            append("test");
            TbLog.TextChanged += TbLog_TextChanged;
        }

        private void TbLog_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void App1(string str)
        {
            Show($"<{str}>");
        }
        private void App2(string str)
        {
            Show($"'{str}'");
        }
        private void App3(string str)
        {
            Show($"\"{str}\"");
        }

        private void Show(string text)
        {
            TbLog.AppendText(text + Environment.NewLine);
        }
        private void Show(double value, Recalc recalc)
        {
            Show($"{value} => {recalc(value)}");
        }

        private double Mul2(double value)
        {
            return 2 * value;
        }
        private static double Div2(double value)
        {
            return value/2;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Show(16, Math.Sqrt);
            Show(-13, Math.Abs);
            Show(7, Mul2);
            Show(7, Div2);
        }
    }
}
