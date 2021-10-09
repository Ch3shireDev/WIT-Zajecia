using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;
using MyAANamespace;

namespace TZ03_IS1_ConsoleApplication_0002
{
    class MyApplication
    {
        public void MyStart()
        {
            Main03();
            MyUtility.MyPause("Na Wybory ! ! !");
        }
        private void Main01()
        {
            MyA[] myTOrg = new MyA[MyUtility.myFate.Next(10, 21)];
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                myTOrg[i] = new MyA(MyUtility.myFate.Next(0, 100),
                                    MyUtility.myFate.Next(0, 100));
            }
            MyA[] myTCop = new MyA[myTOrg.Length];
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                myTCop[i] = myTOrg[i].Copy();
            }

            for (int i = 1; i < myTOrg.Length; i+=2)
            {
                myTCop[i].ax = i; 
            }
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                Console.WriteLine("{0,2}: org: {1,15}||copy: {2,15}",i,myTOrg[i],myTCop[i]);
            }
        }
        private void Main02()
        {
            MyAA myAA01 = new MyAA(new MyA(1,2), new MyA(3,4));
            Console.WriteLine("myAA01: {0}", myAA01);
        }

        private void Main03()
        {
            MyAA[] myTOrg = new MyAA[MyUtility.myFate.Next(10, 21)];
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                myTOrg[i] = new MyAA(new MyA(MyUtility.myFate.Next(0, 100),
                                             MyUtility.myFate.Next(0, 100)),
                                     new MyA(MyUtility.myFate.Next(0, 100),
                                             MyUtility.myFate.Next(0, 100)));
            }
            MyAA[] myTCop = new MyAA[myTOrg.Length];
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                myTCop[i] = myTOrg[i].Copy();
            }

            for (int i = 1; i < myTOrg.Length; i += 2)
            {
                myTCop[i].ax.ax = i;
            }
            for (int i = 0; i < myTOrg.Length; ++i)
            {
                Console.WriteLine("{0,2}: org: {1,35}||copy: {2,35}", i, myTOrg[i], myTCop[i]);
            }
        }

    }
}
//tworzymy tablicę obiektów MyA o rozmiarze wylosowanym z zakresu [10, 20]
//obiekty w tablicy mają mieć pola o wartościach wylosowanych z zakresu [0, 99]
//tworzymy kopię tablicy
//zmieniamy tylko w kopii, w komórkach o indeksach nieparzystych pole ax na numer indeksu
//wyświetlamy obie tablice wraz z numerem indeksu
//20, 15, 10 ,9, 8, 8, 7, 6, 6, 6, 5, 5, 5, 5