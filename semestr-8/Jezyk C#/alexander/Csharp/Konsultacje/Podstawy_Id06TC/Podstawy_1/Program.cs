using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy1
{
    public class StringOperation
    {
        public static void test()
        {
            Console.Out.WriteLine(string.Format("message=\"{1}\" \\ \x30\x39 xy\bz liczba={0}", 13, "ala " + "ma kota"));
        }
    }
    public class MethodAccess
    {
        private int x;
        private static int y=3;
        public static void test()
        {
            y = 7; // ok;
            //x = 3; // nie mogę - metoda statyczna
            //test_obj(); // nie mogę - metoda statyczna
            Console.Out.WriteLine(string.Format("test"));
        }

        //private
        public int X
        {
            get { return x; }
            set { x=value; }
        }

        public void test_obj()
        {
            y = 7; // ok;
            x = 3; // ok;
            X = 13; // ok niezależnie od public/private int X 
            test(); // ok;
            Console.Out.WriteLine(string.Format("test_obj"));
        }
    }

    public class Containders
    {
        private static void ListShow(List<int> list)
        {
            foreach(int v in list) Console.Out.Write(string.Format("{0} ", v));
            Console.Out.WriteLine();
        }
        public static void ListTest()
        {
            int       x        = 7;
            List<int> liststat = new List<int>() { 9, 5, 3, 0, 1, 9, };
            List<int> listnull = null;
            List<int> list     = new List<int>();
            //listnull.Add(x); // wywali
            list.Add(x);
            list.Add(5);
            list.Add(1);
            Console.Out.WriteLine(string.Format("list[1]={0}",list[1]));
            for(int i=0;i<list.Count;++i) Console.Out.Write(string.Format("{0} ",list[i]));
            list.AddRange(list);
            ListShow(list);
            list.RemoveAt(1);
            list.Remove(1);
            ListShow(list);
        }
        private static void DictionaryShow(Dictionary<string, int> si)
        {
            foreach(var v in si) Console.Out.WriteLine(string.Format("si[\"{1}\"] = {0}", v.Value, v.Key));
        }
        public static void DictionaryTest()
        {
            Dictionary<string, int> si = new Dictionary<string, int>()
            {
                {"Kowalski Jan", 666},
                {"Xiński", 1313},
                {"Sikorski", 1999999},
            };
            //si.Add("Kowalski Jan", 666);
            string key = "Xiński";
            Console.Out.WriteLine(string.Format("{0} ideks: {1}", key, si[key]));
            //key = "abc";
            //Console.Out.WriteLine(string.Format("{0} indeks: {1}", key, si[key]));
            var keys=si.Keys;
            var sortedkeys = keys.OrderBy((name) => name);
            string[] keysArray = sortedkeys.ToArray();
            List<string> keysList = sortedkeys.ToList();
            DictionaryShow(si);
            foreach(string v in keysList) Console.Out.Write(string.Format("\"{0}\" ", v));
            Console.Out.WriteLine();
            foreach (string v in keysArray) Console.Out.Write(string.Format("\"{0}\" ", v));
            Console.Out.WriteLine();
        }
        private static void SetShow(HashSet<char> sc)
        {
            foreach (var v in sc) Console.Out.Write(string.Format("{0} ", v));
            Console.Out.WriteLine();
        }
        public static void SetTest()
        {
            HashSet<char> sc = new HashSet<char>() { 'a','b','a','c','a', };
            SetShow(sc);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringOperation.test();
            Console.Out.WriteLine("======================");
            MethodAccess.test();
            MethodAccess ma = new MethodAccess();
            ma.test_obj();
            new MethodAccess().test_obj();
            Console.Out.WriteLine("ma.X = {0}", ma.X);
            ma.X = 7;
            Console.Out.WriteLine("ma.X = {0}", ma.X);
            Containders.ListTest();
            Containders.SetTest();
            Containders.DictionaryTest();
            Console.In.ReadLine();
        }
    }
}
