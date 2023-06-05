using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedMonitor
{
    class LedMonitorFont
    {
        private Dictionary<char, LedMonitorChar> map=new Dictionary<char, LedMonitorChar>();
        private static readonly LedMonitorChar space = LedMonitorChar.Space();
        public LedMonitorFont()
        {
            map.Add('0', LedMonitorChar.digit0());
            map.Add('1', LedMonitorChar.digit1());
            map.Add('2', LedMonitorChar.digit2());
            map.Add('3', LedMonitorChar.digit3());
            map.Add('4', LedMonitorChar.digit4());
            map.Add('5', LedMonitorChar.digit5());
            map.Add('6', LedMonitorChar.digit6());
            map.Add('7', LedMonitorChar.digit7());
            map.Add('8', LedMonitorChar.digit8());
            map.Add('9', LedMonitorChar.digit9());
        }
        public bool[,] getData(char ch)
        {
            LedMonitorChar mc;
            if (map.TryGetValue(ch, out mc)) return mc.getData();
            return space.getData();
        }

    }
}
