using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalBasic
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> counter = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            counter.Clear();
            foreach (string name in TbData.Text.Trim().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                // if (!counter.ContainsKey(name)) counter[name] = 0;
                //counter[name] = counter[name] + 1;
                string key = name.Trim();
                int value=0;
                if (!counter.TryGetValue(key, out value)) value = 0;
                counter[key] = value + 1;
            }
            TbResult.Clear();
            foreach (var item in counter)
            {
                TbResult.AppendText($"{item.Value,5}: {item.Key}"+Environment.NewLine);
            }
        }
    }
}
