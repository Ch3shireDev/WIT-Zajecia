using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IdBuilder
    {
        private List<long> list=new List<long>();
        private string Delimetr=", ";
        private string IfEmpty="null";

        // ... where id in (1, 13, 666)
        // ... where id in (null)
        // ib.Append(1).Append(13).SetDelimetr(";").ToString();
        public IdBuilder Append(long id)
        {
            list.Add(id);
            return this;
        }

        public IdBuilder Clear()
        {
            list.Clear();
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
            if (list.Count <= 0) return IfEmpty;
            StringBuilder sb=new StringBuilder();
            bool first=true;
            foreach(long id in list)
            {
                if(first) first=false; else sb.Append(Delimetr);
                sb.Append(id);
            }
            return sb.ToString();
        }
    }
}
