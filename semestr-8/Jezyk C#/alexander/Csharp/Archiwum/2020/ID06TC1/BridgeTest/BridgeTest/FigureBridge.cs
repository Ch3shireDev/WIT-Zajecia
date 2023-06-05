using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    public abstract class FigureBridge
    {
        protected abstract void initialize();
        protected abstract void finalize();
        protected abstract void proceed(Figure fig);
        public void proceed(List<Figure> list)
        {
            initialize();
            foreach (Figure fig in list) proceed(fig);
            finalize();
        }
    }
}
