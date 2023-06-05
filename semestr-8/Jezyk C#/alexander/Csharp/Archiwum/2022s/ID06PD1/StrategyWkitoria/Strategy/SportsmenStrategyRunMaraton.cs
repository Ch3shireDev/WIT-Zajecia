﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyRunMaraton : SportsmenStrategyRun
    {
        public string ExecRun()
        {
            return "Maratoning";
        }
        public override string ToString()
        {
            return "Maraton";
        }
    }
}
