using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IdListBuilder
    {
        private HashSet<long> lst = new HashSet<long>();
        public HashSet<long> List { get { return lst; } }
        public string DefaultValue { get; set; }
        public IdListBuilder(string DefaultValue="null")
        {
            this.DefaultValue = DefaultValue;
        }
        public void Append(long id)
        {
            lst.Add(id);
        }
        public void Clear()
        {
            lst.Clear();
        }
        public override string ToString()
        {
            if (lst.Count <= 0) return DefaultValue;
            StringBuilder sb=new StringBuilder();
            /*///
            bool first = true;
            foreach(long id in lst)
            {
                if (first) first = false;
                else sb.Append(',');
                sb.Append(id);
            }
            return sb.ToString();
            /*/
            foreach(long id in lst)
            {
                sb.Append(id).Append(',');
            }
            string ret = sb.ToString();
            return ret.Substring(0, ret.Length-1);
            //*///
        }
    }
}
