using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class IdBuilder
    {
        // ... where id in (1, 13, 666)
        // ... where id in (null)
        // ib.Clear().Append(1).Append(13).Append(666).SetDelimetr(",").ToString();
        private string IfEmpty="null";
        private string Delimetr=", ";
        private HashSet<long> set=new HashSet<long>();
        public IdBuilder Append(long id)
        {
            set.Add(id);
            return this;
        }
        public IdBuilder Clear()
        {
            set.Clear();
            return this;
        }
        public IdBuilder SetDelimetr(string Delimetr)
        {
            this.Delimetr=Delimetr;
            return this;
        }
        public IdBuilder SetIfEmpty(string IfEmpty)
        {
            this.IfEmpty=IfEmpty;
            return this;
        }
        public override string ToString()
        {
            if(set.Count<=0) return IfEmpty;
            StringBuilder sb=new StringBuilder();
            bool first=true;
            foreach(long id in set)
            {
                if(first) first=false; else sb.Append(Delimetr);
                sb.Append(id);
            }
            return sb.ToString();
        }
    }
}
