using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraTest
{
    class Edge
    {
        public Node Distanation { get; }
        public double Distance { get; }
        public Edge(Node Distanation, double Distance) { this.Distanation = Distanation; this.Distance = Distance; }
    }
    class Path
    {
        public List<Edge> Neighbors { get; }
        public double Distance { get; set; }
        public Path() { Neighbors = new List<Edge>(); Distance = -1; }
        public void AddEdge(Node Distanation, double Distance) { Neighbors.Add(new Edge(Distanation, Distance)); }
    }
    class Node : Path
    {
        public string Name { get; }
        public Node From { get; protected set; }
        public Node(string Name) { this.Name = Name; }
        public void Reset(double Distance, Node From = null) { this.Distance = Distance; this.From = From; }
        public bool SetBest(double Distance, Node From)
        {
            bool result = ((this.Distance < 0) || (Distance < this.Distance));
            if (result) Reset(Distance, From);
            return result;
        }
    }
    class Graph
    {
        public Dictionary<string, Node> Map=new Dictionary<string, Node>();
        public Node GetNode(string Name)
        {
            try { return Map[Name]; }
            catch(Exception)
            {
                Node node = new Node(Name);
                Map.Add(Name, node);
                return node;
            }
        }
        public void AddEdge(Node from, Node to, double distance)
        {
            from.AddEdge(to, distance);
            to.AddEdge(from, distance);
        }
        public void AddEdge(string from, string to, double distance)
        {
            AddEdge(GetNode(from), GetNode(to), distance);
        }
        public void AddEdge(string row)
        {
            String[] data = row.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            double distance;
            if ((data.Length == 3) && (double.TryParse(data[2], out distance))) AddEdge(data[0], data[1], distance);
        }
        public void LoadGraph(string data)
        {
            Map.Clear();
            foreach (string row in data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)) AddEdge(row);
        }
        public void Dijkstra(Node start)
        {
            List<Node> queue = new List<Node>();
            foreach (var item in Map) item.Value.Reset(-1);
            start.Reset(0);
            queue.Add(start);
            while (queue.Count > 0)
            {
                Node curr = queue.OrderBy(node => node.Distance).First();
                queue.Remove(curr);
                double distance = curr.Distance;
                foreach (Edge edge in curr.Neighbors)
                {
                    Node next = edge.Distanation;
                    if (next.SetBest(distance + edge.Distance, curr))
                    {
                        queue.Remove(next);
                        queue.Add(next);
                    }
                }
            }
        }
    }
}
