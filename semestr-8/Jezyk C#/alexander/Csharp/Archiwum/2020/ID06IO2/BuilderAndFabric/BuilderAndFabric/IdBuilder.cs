using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFabric
{
    class IdBuilder
    {
        private HashSet<long> hs = new HashSet<long>();
        private string Delimeter, IfEmpty;
        public IdBuilder(string Delimeter=", ",string IfEmpty="NULL") { SetDelimeter(Delimeter).SetIfEmpty(IfEmpty); }
        public IdBuilder SetDelimeter(string Delimeter) { this.Delimeter = Delimeter; return this; }
        public IdBuilder SetIfEmpty(string IfEmpty) { this.IfEmpty = IfEmpty; return this; }
        public IdBuilder Clear() { hs.Clear(); return this; }
        public IdBuilder Append(long id) { hs.Add(id); return this; }
        public override string ToString()
        {
            if (hs.Count == 0) return IfEmpty;
            List<long> sl = hs.ToList();
            sl.Sort();
            StringBuilder sb = new StringBuilder();
            /*///
            sb.Append(sl[0]);
            for (int i = 1; i < sl.Count; ++i) sb.Append(Delimeter).Append(sl[i]);
            /*/
            bool first = true;
            foreach(long id in sl)
            {
                if (first) first = false; else sb.Append(Delimeter);
                sb.Append(id);
            }
            //*///
            return sb.ToString();
        }
    }
}
