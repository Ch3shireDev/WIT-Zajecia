using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lines = File.ReadAllLines(@"P:\Barski\Csharp\DijkstaraDataA.txt");
            var Tables = Lines.Select((value) => value.Split(new char[] { '\t' }) );
            var Records = Tables.Select((tb) => new { A = tb[0], B = tb[1], Len = double.Parse(tb[2]) });
            var CityA = Records.Select((rec) => rec.A).Distinct();
            var CityB = Records.Select((rec) => rec.B).Distinct();
            var City = CityA.Concat(CityB).Distinct();

            foreach (var i in Records)
            {
                Console.WriteLine("{0} {1} {2}", i.A, i.B, i.Len);
            }
            Console.ReadLine();
        }
    }
    public class Graph
    {
        public Dictionary<string,Node> Nodes = new Dictionary<string, Node>();
        public Node GetNode(string name)
        {
            if (Nodes.ContainsKey(name)) return Nodes[name];
            Node result = new Node(name);
            Nodes.Add(name,result);
            return result;
        }
        public void AddEdge(string A,string B,double destination)
        {
            Node a = GetNode(A);
            Node b = GetNode(B);
            a.AddEdge(b, destination);
            b.AddEdge(a, destination);
        }
        public KeyValuePair<double, Node[]> DijkstraAll()
        {

        }
        public KeyValuePair<double, Node[]> Dijkstra(Node EndPoint)
        {
            var maxValue = Nodes.Max(rec => rec.Value.Distance);
            var retRecord = Nodes.Where((rec) => (rec.Value.Distance >= maxValue)).Single().Value;
            List<Node> lst = new List<Node>();
            while (retRecord != null)
            {
                lst.Add(retRecord);
                retRecord = retRecord.Previouse;
            }
            return new KeyValuePair<double,Node[]>(maxValue, lst.ToArray());
        }
    }
    public class Node
    {
        private string _name;
        private List<Edge> _neighbor = new List<Edge>();
        public string Name { get { return _name; } }
        public double Distance { get; set; }
        public Node Previouse { get; set; }
        public List<Edge> Neighbor { get { return _neighbor; } }
        public Node(string name)
        {
            _name = name;
            Distance = 0;
            Previouse = null;
        }
        public void AddEdge(Node node, double destination)
        {
            Neighbor.Add(new Edge(node, destination));
        }
    }

    public class Edge
    {
        private Node _destination;
        private double _length;
        public Node Destination { get { return _destination; } }
        public double Length { get { return _length; } }
        public Edge(Node destination, double length)
        {
            _destination = destination;
            _length = length;
        }
    }
}
