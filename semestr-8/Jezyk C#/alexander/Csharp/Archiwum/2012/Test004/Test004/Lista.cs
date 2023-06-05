using System;
using System.Collections.Generic;
using System.Text;

namespace Test004
{
    class List
    {
        private Node Head;
        private Node Tail;
        private uint Count;

        public List()
        {
            Head = Tail = null;
            Count = 0;
        }

        public void Add(double Value)
        {
            new Node(this,Value);
            ++Count;
        }

        public void Drop()
        {
            if(Head != null)
            {
                Head = Head.next;
                if (Head == null) Tail = null;
                else Head.prev = null;
                //(Head == null ? Tail : Head.prev ) = null;
                --Count;
            }
        }

        public Node head { get { return Head; } set { Head = value; } }
        public Node tail { get { return Tail; } set { Tail = value; } }
        public uint count { get { return Count; } }
    }

    class Node
    {
        private Node Next;
        private Node Prev;
        private double Value;

        public Node(List L, double V)
        {
            Value = V;
            Next = null;
            Prev = L.tail;
            if (Prev != null) Prev.Next = this;
            else L.head = this;
            L.tail = this;
            //L.tail = (Prev != null ? Prev.Next : L.head) = this;
        }

        public double value { get { return Value; } }
        public Node next { get { return Next; } set { Next = value; } }
        public Node prev { get { return Prev; } set { Prev = value; } }
    }
}
