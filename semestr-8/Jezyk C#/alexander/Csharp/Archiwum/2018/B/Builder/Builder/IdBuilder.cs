using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IdBuilder
    {
        private HashSet<long> list = new HashSet<long>();
        public string Delimeter { get; set; }
        public string EmptyValue { get; set; }
        public IdBuilder(string Delimeter=", ",string EmptyValue="null")
        {
            this.Delimeter = Delimeter;
            this.EmptyValue = EmptyValue;
        }
        public void Clear() { list.Clear(); }
        public void Add(long id) { list.Add(id); }
        public override string ToString()
        {
            if (list.Count <= 0) return "null";
            StringBuilder sb = new StringBuilder();
            /*
            bool first = true;
            foreach(long id in list)
            {
                if (first) first = false;
                else sb.Append(",");
                sb.Append(id);
            }
            return sb.ToString();
            */
            /*
            long first = list.First();
            foreach (long id in list)
            {
                if (id!=first) sb.Append(",");
                sb.Append(id);
            }
            return sb.ToString();
            */
            /*
            foreach (long id in list)
            {
                sb.Append(",").Append(id);
            }
            return sb.ToString().Substring(1);
            */
            return string.Join(",",list).ToString();
        }
    }
}
