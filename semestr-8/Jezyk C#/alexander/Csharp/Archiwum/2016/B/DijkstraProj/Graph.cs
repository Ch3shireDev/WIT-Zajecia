using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraProj
{
    public class Graph
    {
        public Dictionary<string, Node> map;
        public Graph()
        {
            map = new Dictionary<string, Node>();
        }
        public Node find(string name)
        {
            Node node;
            if (map.TryGetValue(name, out node)) return node;
            return new Node(name);
        }
        public void AddEdge(Node a, Node b,double cost)
        {
            a.Add(b, cost);
            b.Add(a, cost);
        }
        public void AddEdge(string a, string b, double cost)
        {
            AddEdge(find(a), find(b), cost);
        }
    }

    public class Node
    {
        public string name;
        public double cost;
        public List<Edge> edges;
        public Node(string name)
        {
            this.name = name;
            cost = 0;
            edges = new List<Edge>();
        }
        public void Add(Node node, double cost)
        {
            edges.Add(new Edge(node, cost));
        }
        public List<Edge> getEdges() { return edges; }
    }

    public class Edge
    {
        public Node node;
        public double cost;
        public Edge(Node node, double cost)
        {
            this.node = node;
            this.cost = cost;
        }
    }
}
