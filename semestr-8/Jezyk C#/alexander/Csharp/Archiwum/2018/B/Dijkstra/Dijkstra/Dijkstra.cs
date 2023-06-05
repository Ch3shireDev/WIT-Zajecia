using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstra
{
    public class Edge
    {
        public Node node { get; }
        public double distance { get; }
        public Edge(Node node, double distance)
        {
            this.node = node;
            this.distance = distance;
        }
    }
    public class Node
    {
        public string name { get; }
        public double distance { get; set; }
        public Node from { get; set; }
        public List<Edge> neighbors { get; }
        public Node(string name)
        {
            this.name = name;
            distance = -1;
            from = null;
            neighbors = new List<Edge>();
        }
        public void addNeighbor(Node neighbor,double distance)
        {
            neighbors.Add(new Edge(neighbor, distance));
        }
        public bool bestDistance(Node source,double value)
        {
            bool ok = ((distance < 0) || (distance > value));
            if (ok)
            {
                from = source;
                distance = value;
            }
            return ok;
        }
    };
    public class Dijkstra
    {
        public Dictionary<string, Node> nodes { get; set; }
        public Dijkstra(string[] rows)
        {
            nodes = new Dictionary<string, Node>();
            AddEdges(rows);
        }
        private Node nodeBystring(string name)
        {
            try
            { 
                return nodes[name];
            }
            catch(Exception)
            {
                Node node = new Node(name);
                nodes.Add(name, node);
                return node;
            }
        }
        private void reset(Node node)
        {
            foreach (var item in nodes)
            {
                item.Value.distance = -1;
                item.Value.from = null;
            }
            node.distance = 0;
        }
        private void AddEdge(string A,string B,double distance)
        {
            Node na = nodeBystring(A), nb = nodeBystring(B);
            na.addNeighbor(nb, distance);
            nb.addNeighbor(na, distance);
        }
        private bool AddEdge(string row)
        {
            string[] parts = row.Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            double distance = 0;
            //parts[2] = parts[2].Replace(',', '.');
            if ((parts.Length != 3) || (!double.TryParse(parts[2], out distance)))
            {
                return false;
            }
            AddEdge(parts[0], parts[1], distance);
            return true;
        }
        private bool AddEdges(string[] rows)
        {
            foreach (string row in rows) if (!AddEdge(row)) return false;
            return true;
        }
        public void Calculate(Node start)
        {
            HashSet<Node> queue = new HashSet<Node>();
            queue.Add(start);
            reset(start);
            while(queue.Count>0)
            {
                double md = queue.Min(n => n.distance);
                Node curr = queue.First(n => (n.distance==md));
                queue.Remove(curr);
                foreach(Edge edge in curr.neighbors)
                {
                    double distance = curr.distance + edge.distance;
                    if(edge.node.bestDistance(curr,distance))
                    {
                        queue.Remove(edge.node);
                        queue.Add(edge.node);
                    }
                }
            }
        }
    }
}
