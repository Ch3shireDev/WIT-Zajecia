using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // ... where id in (5, 13, 99);
    // ... where id in (null);
    // idb;
    // idb.Append(5).Append(13);
    class IdBuilder
    {
        private List<long> array=new List<long>();
        private string IfEmpty="null";
        private string Delimeter=", ";
        public IdBuilder SetIfEmpty(string IfEmpty)
        {
            this.IfEmpty=IfEmpty;
            return this;
        }
        public IdBuilder SetDelimeter(string Delimeter)
        {
            this.Delimeter=Delimeter;
            return this;
        }
        public IdBuilder Append(long id)
        {
            array.Add(id);
            return this;
        }
        public override string ToString()
        {
            if (array.Count <= 0) return IfEmpty;
            StringBuilder sb=new StringBuilder();
            bool first=true;
            foreach(long id in array)
            {
                if(first) first=false; else sb.Append(Delimeter);
                sb.Append(id);
            }
            return sb.ToString();
        }
    }
}
