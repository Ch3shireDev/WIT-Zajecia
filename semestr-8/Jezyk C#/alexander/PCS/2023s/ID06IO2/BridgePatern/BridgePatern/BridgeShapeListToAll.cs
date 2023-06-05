using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class BridgeShapeListToAll : BridgeShapeList
    {
        private BridgeShapeList[] bridges;
        public BridgeShapeListToAll(params BridgeShapeList[] list)
        {
            this.bridges = list;
        }
        public override void Proceed(List<Shape> shapes)
        {
            foreach (BridgeShapeList bridge in bridges) bridge.Proceed(shapes);
        }
    }
}
