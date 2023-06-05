using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmCount
{
    delegate void TextDelegate(string text);
    public partial class HarmCount : Form
    {
        public HarmCount()
        {
            InitializeComponent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            Counter.RunWorkerAsync(EdCount.Text);
            EdCount.Focus();
            EdCount.SelectAll();
        }

        private void SetResultTextSync(string text)
        {
            Invoke(new TextDelegate(SetResultText), new Object[] { text });
        }

        private void SetResultText(string text)
        {
            LbResult.Text = LbResult.Text + Environment.NewLine + text;
        }

        private void Counter_DoWork(object sender, DoWorkEventArgs e)
        {
            string text,result;
            text = e.Argument as string;
            uint Cnt = 0;
            if (UInt32.TryParse(EdCount.Text, out Cnt))
            {
                double sum = 0;
                for (uint i = 1; i <= Cnt; ++i) sum += 1.0 / i;
                result = sum.ToString();
            }
            else result = "?";
            SetResultTextSync(text + ": " + result);
        }
    }
}
