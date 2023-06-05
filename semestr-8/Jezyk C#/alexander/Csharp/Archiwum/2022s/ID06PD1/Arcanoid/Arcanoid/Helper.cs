using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
    public abstract class Helper
    {
        public static float minmax(float min,float value,float max)
        {
            return Math.Min(Math.Max(min, value), max);
        }
    }
}
