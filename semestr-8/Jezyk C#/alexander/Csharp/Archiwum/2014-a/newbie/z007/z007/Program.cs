using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z007
{
    class Node
    {
        public double Value;
        public Node next;
        public Node(double Value, Node next) { this.Value = Value; this.next = next; }
    }
    class List
    {
        Node head=null;
        uint count=0;
        public void push_front(double value)
        {
            head = new Node(value, head);
            ++count;
        }

        public double pop_front()
        {
            if(head==null) throw new System.InvalidOperationException("Top element not exists");
            double Value = head.Value;
            head = head.next;
            --count;
            return Value;
        }

        public bool empty()
        {
            return (head == null);
        }

        public double front()
        {
            if (head == null) throw new System.InvalidOperationException("Top element not exists");
            return head.Value;
        }

        public override string ToString()
        {
            string str="";
            for (Node i = head; i != null; i = i.next) str+=" "+i.Value;
            return str.Substring(1);
        }

        public uint Count
        {
            get { return count; }
        }
        
        public double[] toArray()
        {
            double[] Tb = new double[count];
            uint pos = 0;
            for (Node i = head; i != null; i = i.next) Tb[pos++]=i.Value;
            return Tb;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List L=new List();
            L.push_front(6);
            L.push_front(4);
            L.push_front(2);
            L.push_front(0);
            double[] Arr = L.toArray();
            Console.WriteLine("Rozmiar: {0}",L.Count);
            foreach (double v in Arr) Console.Write(" {0}", v);
            Console.WriteLine();
            Console.WriteLine("<{0}>", L);
            Console.ReadKey();
        }
    }
}
