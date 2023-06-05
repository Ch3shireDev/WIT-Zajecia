using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class DijkstraTest : Form
    {
        private Dijkstra dj = null;
        public DijkstraTest()
        {
            InitializeComponent();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if(DlgOpen.ShowDialog()==DialogResult.OK)
            {
                EdSource.Lines = System.IO.File.ReadAllLines(DlgOpen.FileName);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            double dist = 0;
            dj = new Dijkstra(EdSource.Lines);
            foreach (var i in dj.nodes)
            {
                dj.Calculate(i.Value);
                foreach (var k in dj.nodes)
                {
                    Node node = k.Value;
                    if (dist < node.distance)
                    {
                        dist = node.distance;
                        lst.Clear();
                        lst.Add(node.name);
                        while (node.from != null)
                        {
                            node = node.from;
                            lst.Add(node.name);
                        }
                    }
                }
            }
            EdResult.Clear();
            EdResult.AppendText(dist.ToString() + Environment.NewLine);
            foreach (string item in lst)
            {
                EdResult.AppendText(item+Environment.NewLine);
            }
        }
    }
}
