using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraTest
{
    public partial class DijkstraTestForm : Form
    {
        public DijkstraTestForm()
        {
            InitializeComponent();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK) EdData.Text = System.IO.File.ReadAllText(DlgOpen.FileName);
            EdData.Focus();
        }

        private void AppendPath(Path path)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Edge edge in path.Neighbors)
            {
                sb.Append(edge.Distanation.Name).Append(": ").Append(edge.Distance).Append(Environment.NewLine);
            }
            EdResult.AppendText(sb.ToString() + Environment.NewLine);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            EdResult.Clear();
            Graph g = new Graph();
            g.LoadGraph(EdData.Text);
            Path best = new Path();
            foreach(var item in g.Map)
            {
                g.Dijkstra(item.Value);
                foreach (var res in g.Map)
                {
                    Node node = res.Value;
                    if (best.Distance < node.Distance)
                    {
                        double distance = node.Distance;
                        best.Distance = distance;
                        best.Neighbors.Clear();
                        while (node != null)
                        {
                            best.AddEdge(node, distance - node.Distance);
                            node = node.From;
                        }
                    }
                }
            }
            AppendPath(best);
        }
    }
}
