using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_1
{
    public class StringOperation
    {
        public static void Test()
        {
            Console.WriteLine("ala ma kota \x30\x39");
            Console.WriteLine("ala " + "ma" + " kota");
            Console.WriteLine(string.Format("liczba={1:D5}; komunikat=\"{0}\"; \\ wartość={2:F3}", "ala ma kota", 13, 6.66));
            Console.WriteLine("       na podstawach\rWitamy");
            Console.WriteLine("xy\bz\b");
        }
    }
    public class MethodAccess
    {
        private int x;
        private static int y;
        public int px;
        public static int py;
        public static void Test_S()
        {
            Console.WriteLine("Test_S() start");
            //x = 13; // ze statycznej metody dostęp tylko do statycznych elementów
            y = 7;
            //Test_O(); // ze statycznej metody dostęp tylko do statycznych elementów
            Console.WriteLine("Test_S() stop");
        }
        public void Test_O()
        {
            Console.WriteLine("Test_O() start");
            x = 13;
            y = 7;
            Test_S();
            Console.WriteLine("Test_O() stop");
        }
    }

    public class ContainerList
    {
        public static void PrintFor(List<int> list)
        {
            for (int i = 0; i < list.Count; ++i) Console.Write(list[i] + " ");
            Console.WriteLine();
        }
        public static void PrintForeach(List<int> list)
        {
            foreach (int v in list) Console.Write(v + " ");
            Console.WriteLine();
        }
        public static void Test()
        {
            List<int> list = new List<int>() { 1,9,2,8,3,7,4,6,5 };
            PrintFor(list);
            PrintForeach(list);
            list.Add(0);
            PrintForeach(list);
            list.Insert(5, 0);
            PrintForeach(list);
            list.Remove(0);
            PrintForeach(list);
            list.RemoveAt(9);
            PrintForeach(list);
            PrintForeach(list.OrderBy((v) => v).ToList());
        }
    }

    public class ContainerSet
    {
        public static void PrintFor(HashSet<int> set)
        {
            //for (int i = 0; i < set.Count; ++i) Console.Write(set[i] + " "); // elementy nie są poindeksowane
            //Console.WriteLine();
        }
        public static void PrintForeach(HashSet<int> set)
        {
            foreach (int v in set) Console.Write(v + " ");
            Console.WriteLine();
        }
        public static void Test()
        {
            HashSet<int> set = new HashSet<int>() { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            PrintForeach(set);
            set.Add(0);
            PrintForeach(set);
            //set.Insert(5, 0); // nie ma wstawiania w środek
            set.Remove(0);
            PrintForeach(set);
            //set.RemoveAt(9); // elementy nie są poindeksowane
            ContainerList.PrintForeach(set.OrderBy((v) => v).ToList());
        }
    }

    public class ContainerDictionary
    {
        public static void PrintFor(Dictionary<string,int> map)
        {
            //for (int i = 0; i < map.Count; ++i) Console.Write(map[i] + " "); // elementy nie są poindeksowane
            //Console.WriteLine();
        }
        public static void PrintForeach(Dictionary<string, int> map)
        {
            //foreach (KeyValuePair<string, int> v in map) Console.Write(v + " ");
            foreach (var v in map) Console.Write(string.Format("map[{0}]={1} ",v.Key,v.Value));
            Console.WriteLine();
        }

        public static string mapkey(string key) { return key; }
        public static void Test()
        {
            Dictionary<string, int> map = new Dictionary<string, int>() 
            {
                {"Kowalski",35},
                {"Sikorski",19},
                {"Adamski",49},
            };
            PrintForeach(map);
            //map.Add("Sikorski",29); //nie wolno dodać istniejącego
            map.Add("Wikorski", 39);
            PrintForeach(map);
            map.Remove("Sikorski");
            PrintForeach(map);
            map.Add("Sikorski", 99);
            PrintForeach(map);
            Console.WriteLine("age of Wikorski = " + map["Wikorski"]);
            foreach (string v in map.Keys) Console.Write(v + " ");
            Console.WriteLine();
            //foreach (string v in map.Keys.OrderBy((k)=>k)) Console.Write(v + " ");
            foreach (string v in map.Keys.OrderBy(mapkey)) Console.Write(v + " ");
            Console.WriteLine();
        }
    }

    class Program
    {
        public static void Delimeter()
        {
            Console.WriteLine("======================");
        }
        static void Main(string[] args)
        {
            StringOperation.Test();
            Delimeter();
            MethodAccess.Test_S();
            Delimeter();
            //MethodAccess.px = 0; // iestatyczna zmenna wymaga konkretnego obiektu
            MethodAccess.py = 0;
            //MethodAccess.Test_O(); // niestatyczna metoda wymaga konkretnego obiektu
            new MethodAccess().Test_O();
            Delimeter();
            new MethodAccess().px = 0;
            //new MethodAccess().py = 0; // z zewnątrz do zmiennej/metody statycznej odwaołyjemy się przez nazwę klasy
            //MethodAccess ma = new MethodAccess(); ma.py = 0; //jak wyżej
            ContainerList.Test();
            Delimeter();
            ContainerSet.Test();
            Delimeter();
            ContainerDictionary.Test();
            Delimeter();
        }
    }
}
