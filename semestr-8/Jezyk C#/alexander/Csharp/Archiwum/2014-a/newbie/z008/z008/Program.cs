using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z008
{
    class Node
    {
        public double Value;
        public Node next,prev;
        public Node(double Value, Node prev, Node next) { this.Value = Value; this.prev = prev; this.next = next; }
    }
    class List : ICloneable, IEnumerable
    {
        Node head = null, tail = null;
        uint count = 0;
        public void push_front(double value)
        {
            Node tmp = new Node(value, null, head);
            if (tail == null) tail = tmp;
            else head.prev = tmp;
            head = tmp;
            ++count;
        }

        public void push_back(double value)
        {
            Node tmp = new Node(value, tail, null);
            if (head == null) head = tmp;
            else tail.next = tmp;
            tail = tmp;
            ++count;
        }

        public double pop_front()
        {
            if (head == null) throw new System.InvalidOperationException("Top element not exists");
            double Value = head.Value;
            head = head.next;
            if (head == null) tail = null;
            else head.prev = null;
            --count;
            return Value;
        }

        public double pop_back()
        {
            if (tail == null) throw new System.InvalidOperationException("Back element not exists");
            double Value = tail.Value;
            tail = tail.prev;
            if (tail == null) head = null;
            else tail.next = null;
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

        public double back()
        {
            if (tail == null) throw new System.InvalidOperationException("Back element not exists");
            return tail.Value;
        }

        public override string ToString()
        {
            string str = "";
            for (Node i = head; i != null; i = i.next) str += " " + i.Value;
            return str.Substring(1);
        }

        public object Clone()
        {
            List Lst = new List();
            for (Node i = head; i != null; i = i.next) Lst.push_back(i.Value);
            return Lst;
        }

        public IEnumerator GetEnumerator()
        {
            for (Node i = head; i != null; i = i.next) yield return i.Value;
        }

        public List reverse()
        {
            List Lst = new List();
            for (Node i = head; i != null; i = i.next) Lst.push_front(i.Value);
            return Lst;
        }

        public uint Count
        {
            get { return count; }
        }

        public double[] toArray()
        {
            double[] Tb = new double[count];
            uint pos = 0;
            for (Node i = head; i != null; i = i.next) Tb[pos++] = i.Value;
            return Tb;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List L = new List();
            L.push_front(6);
            L.push_front(4);
            L.push_front(2);
            L.push_front(0);
            double[] Arr = L.toArray();
            Console.WriteLine("Rozmiar: {0}", L.Count);
            foreach (double v in Arr) Console.Write(" {0}", v);
            Console.WriteLine();
            foreach (double v in L) Console.Write(" {0}", v);
            Console.WriteLine();
            Console.WriteLine("<{0}>", L);
            Console.WriteLine("<{0}>", L.reverse());
            Console.WriteLine("<{0}>", L.Clone());
            Console.ReadKey();
        }
    }
}
