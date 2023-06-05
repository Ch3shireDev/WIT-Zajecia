using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class SportsmenCommandComplex:SportsmenCommand
    {
        public string name { get; private set; }

        public SportsmenCommandComplex(string name) { this.name = name; }

        public override string ToString()
        {
            return name;
        }
        public abstract string execute(Sportsmen sportsmen);
    }
}
