using System;
using System.Collections.Generic;

namespace GraphTest
{
    public class Graph
    {
        public Dictionary<string, Node> nodes { get; } 
        public Graph()
        {
            nodes = new Dictionary<string, Node>();
        }
        public Node getNode(string name)
        {
            if (nodes.ContainsKey(name)) return nodes[name];
            Node node = new Node(name);
            nodes.Add(name, node);
            return node;
        }
        public void addEdge(string A,string B,double distance)
        {
            Node nodeA = getNode(A);
            Node nodeB = getNode(B);
            nodeA.addEdge(nodeB, distance);
            nodeB.addEdge(nodeA, distance);
        }
        public static Graph Parse(string source)
        {
            Graph g = new Graph();
            string[] rows = source.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach(string row in rows)
            {
                string[] par = row.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                g.addEdge(par[0], par[1], double.Parse(par[2]));
            }
            return g;
        }
    }
    public class Node
    {
        public Node(string name)
        {
            edges = new List<Edge>();
            this.name = name;
        }
        public void addEdge(Node to, double distance)
        {
            edges.Add(new Edge(to, distance));
        }
        public string name { get; }
        public List<Edge> edges { get; }
    }
    public class Edge
    {
        public Node to { get; }
        public double distance { get; }
        public Edge(Node to, double distance)
        {
            this.to = to;
            this.distance = distance;
        }
    }
}