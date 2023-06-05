using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rows = File.ReadAllLines(@"P:\Barski\Csharp\DijkstaraDataA.txt");
            var Splits = Rows.Select((row) => row.Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries));
            var Records = Splits.Select((tb) => new { nameA=tb[0], nameB=tb[1], distance=double.Parse(tb[2]) });
            Graph graph = new Graph();
            foreach (var edge in Records) graph.AddEdge(edge.nameA, edge.nameB, edge.distance);
            var result = graph.DijkstraAll();
            bool first = true;
            foreach (var item in result)
            {
                if (first)
                {
                    Console.WriteLine("{0}:", item.Key);
                    first = false;
                }
                foreach (var node in item.Value)
                {
                    Console.Write("{0} ", node.Name);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    public class Graph
    {
        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        public Node FindNode(string name)
        {
            if (nodes.ContainsKey(name)) return nodes[name];
            Node node = new Node(name);
            nodes.Add(name, node);
            return node;
        }
        public void AddEdge(string nameA, string nameB, double distance)
        {
            Node nodeA = FindNode(nameA);
            Node nodeB = FindNode(nameB);
            nodeA.AddEdge(nodeB, distance);
            nodeB.AddEdge(nodeA, distance);
        }

        private IEnumerable<KeyValuePair<double, List<Node>>> FindMax(IEnumerable<KeyValuePair<double, List<Node>>> list)
        {
            var MaxDistance = list.Select((item) => item.Key).Max();
            return list.Where((item) => (item.Key >= MaxDistance));
        }

        public IEnumerable<KeyValuePair<double, List<Node>>> Dijkstra(Node EndPoint)
        {
            List<Node> queue = new List<Node>();
            foreach (var items in nodes) items.Value.Reset();
            EndPoint.Distance = 0;
            queue.Add(EndPoint);
            while (queue.Count > 0)
            {
                Node destination = queue.First();
                queue.Remove(destination);
                double distance = destination.Distance;
                foreach (var edge in destination.Neighbor)
                {
                    Node source = edge.Destination;
                    double newdistance = distance + edge.Distance;
                    if ((source.Distance == Node.INF) || (source.Distance > newdistance))
                    {
                        source.Distance = newdistance;
                        source.Previouse = destination;
                        if (!queue.Contains(source)) queue.Add(source);
                    }
                }
            }
            List<KeyValuePair<double, List<Node>>> result = new List<KeyValuePair<double, List<Node>>>();
            foreach (var node in nodes)
            {
                List<Node> path = new List<Node>();
                Node step = node.Value;
                double distance = step.Distance;
                while (step != null)
                {
                    path.Add(step);
                    step = step.Previouse;
                }
                result.Add(new KeyValuePair<double, List<Node>>(distance, path));
            }
            return FindMax(result);
        }
        public IEnumerable<KeyValuePair<double, List<Node>>> DijkstraAll()
        {
            IEnumerable<KeyValuePair<double, List<Node>>> result = null;
            foreach (var node in nodes)
            {
                var add = Dijkstra(node.Value);
                if (result == null) result = add;
                result = FindMax(result.Concat(add));
            }
            return result;
        }
    }
    public class Node
    {
        private string name;
        private double distance;
        private Node previouse;
        private List<Edge> neighbor = new List<Edge>();
        public static readonly double INF = -1;
        public Node(string name)
        {
            this.name = name;
            Reset();
        }
        public void Reset()
        {
            distance = INF;
            previouse = null;
        }
        public void AddEdge(Node destination, double distance)
        {
            neighbor.Add(new Edge(destination, distance));
        }
        public string Name { get { return name; } }
        public double Distance { get { return distance; } set { distance = value; } }
        public Node Previouse { get { return previouse; } set { previouse = value; } }
        public List<Edge> Neighbor { get { return neighbor; } }
    }
    public class Edge
    {
        private Node destination;
        private double distance;
        public Edge(Node destination, double distance)
        {
            this.destination = destination;
            this.distance = distance;
        }
        public Node Destination { get { return destination; } }
        public double Distance { get { return distance; } }
    }
}
