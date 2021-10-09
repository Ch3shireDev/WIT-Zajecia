using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;
using MyAANamespace;

namespace TZ03_IS2_ConsoleApplication_0002
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
            MyA[] myT1 = new MyA[MyUtility.myFate.Next(10,21)];
            for (int i = 0; i < myT1.Length; ++i)
            {
                myT1[i] = new MyA(MyUtility.myFate.Next(0, 100),
                                  MyUtility.myFate.Next(0, 100));
            }
            MyA[] myT2 = new MyA[myT1.Length];
            for (int i = 0; i < myT2.Length; ++i)
            {
                myT2[i] = myT1[i].Copy();
            }
            for (int i = 1; i < myT2.Length; i+=2)
            {
                myT2[i].ax = i;
            }
            for (int i = 0; i < myT2.Length; ++i)
            {
                Console.WriteLine("{0,2}: org: {1,14}, copy: {2,14}",i,myT1[i],myT2[i]);
            }
        }
        private void Main02()
        {
            MyAA myAA01 = new MyAA(new MyA(1, 2), new MyA(3, 4));
            Console.WriteLine("myAA01 : {0}",myAA01);
        }

        private void Main03()
        {
            MyAA[] myT1 = new MyAA[MyUtility.myFate.Next(10, 21)];
            for (int i = 0; i < myT1.Length; ++i)
            {
                myT1[i] = new MyAA(new MyA(MyUtility.myFate.Next(0, 100),
                                           MyUtility.myFate.Next(0, 100)),
                                   new MyA(MyUtility.myFate.Next(0, 100),
                                           MyUtility.myFate.Next(0, 100)));
            }
            MyAA[] myT2 = new MyAA[myT1.Length];
            for (int i = 0; i < myT2.Length; ++i)
            {
                myT2[i] = myT1[i].Copy();
            }
            for (int i = 1; i < myT2.Length; i += 2)
            {
                myT2[i].ax.ax = i;
            }
            for (int i = 0; i < myT2.Length; ++i)
            {
                Console.WriteLine("{0,2}: org: {1,32}, || copy: {2,32}", i, myT1[i], myT2[i]);
            }
        }


    }
}
