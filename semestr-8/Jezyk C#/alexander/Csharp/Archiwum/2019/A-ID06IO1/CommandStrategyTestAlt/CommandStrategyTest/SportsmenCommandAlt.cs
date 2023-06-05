using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    public delegate string ExecuteCommand(Sportsman s);
    class SportsmenCommandAlt
    {
        private static Dictionary<string, ExecuteCommand> map = makemap();
        private static Dictionary<string, ExecuteCommand> makemap()
        {
            Dictionary<string, ExecuteCommand> map = new Dictionary<string, ExecuteCommand>();
            map.Add("bieg", Run);
            map.Add("skoki", Jump);
            map.Add("plywanie", Swim);
            return map;
        }
        public static string[] getKeys()
        {
            return map.Keys.ToArray();
        }
        public static ExecuteCommand getCommand(string key) { return map[key]; }

        private static string Run(Sportsman s) { return s.Run(); }
        private static string Jump(Sportsman s) { return s.Jump(); }
        private static string Swim(Sportsman s) { return s.Swim(); }
    }
}
