using System;

namespace Test011
{
    class Program
    {
        static void Main(string[] args)
        {
            uint count = uint.Parse(Console.ReadLine());
            uint[] tb = new uint[count];
            uint maxval = 2;
            for (uint i = 0; i < count; ++i)
            {
                uint val = uint.Parse(Console.ReadLine());
                tb[i] = val;
                if (maxval < val) maxval = val;
            }
            bool[] sito = new bool[maxval + 1];
            sito[0] = sito[1] = true;
            uint last=(uint)Math.Sqrt(maxval);
            for (uint i = 2; i <= last; ++i)
            {
                if(!sito[i])
                {
                    for (uint k = i+i; k <= maxval; k+=i)
                    {
                        sito[k] = true;
                    }
                }
            }
            for(uint i = 0; i < count; ++i)
            {
                Console.WriteLine(sito[tb[i]]?"NIE":"TAK");
            }
        }
    }
}
