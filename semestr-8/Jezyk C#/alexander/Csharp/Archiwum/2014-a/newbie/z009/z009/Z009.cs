using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z009
{
    class Node
    {
        public string Value;
        public Node Lf, Rt;

        public Node(string Value)
        {
            this.Value = Value;
            Lf = Rt = null;
        }
    }

    class Tree
    {
        Node Root = null;

        public bool add(string Value)
        {
            Node parent = null, tmp = Root;
            int cmp = 0;
            while(tmp != null)
            {
                parent = tmp;
                cmp = String.Compare(Value, tmp.Value);
                if (cmp > 0) tmp = tmp.Rt;
                else if (cmp < 0) tmp = tmp.Lf;
                else return false;
            }
            if (parent == null) Root = new Node(Value);
            else if (cmp > 0) parent.Rt = new Node(Value);
            else if (cmp < 0) parent.Lf = new Node(Value);
            return true;
        }

        static private string rep(string str)
        {
            string ret = "";
            int len = str.Length;
            for (int i = 1; i < len; ++i)
            {
                ret += (str[i-1]==str[i]) ? "  " : " │";
            }
            if (len > 0) ret += " " + str[len - 1];
            return ret;
        }

        static private string InOrder(Node node, string prefix = "")
        {
            string str="";
            if (node.Lf != null) str += InOrder(node.Lf, prefix + "┌");
            str += rep(prefix) + "─█" + node.Value + Environment.NewLine;
            if (node.Rt != null) str += InOrder(node.Rt, prefix + "└");
            return str;
        }

        public override string ToString()
        {
            string str = "";
            if (Root != null) str = InOrder(Root);
            return str;
        }

        public static Tree operator+(Tree T,string line)
        {
            T.add(line);
            return T;
        }
    }

    class Z009
    {
        static void Main(string[] args)
        {
            Tree T = new Tree();
            string line;
            Console.Write("Podaj korzeń: ");
            while(((line=Console.ReadLine())!=null)&&(line!=""))
            {
                T+=line;
                Console.Write("{0}"+Environment.NewLine+"Podaj kolejny element: ", T);
            }
        }
    }
}
