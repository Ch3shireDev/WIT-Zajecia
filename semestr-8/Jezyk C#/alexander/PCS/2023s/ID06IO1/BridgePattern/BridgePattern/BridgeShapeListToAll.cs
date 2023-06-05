using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class BridgeShapeListToAll : BridgeShapeList
    {
        private BridgeShapeList[] bridges;
        public BridgeShapeListToAll(params BridgeShapeList[] bridges)
        {
            this.bridges = bridges;
        }
        public override void Proceed(List<Shape> shapes)
        {
            foreach (BridgeShapeList bridge in bridges) bridge.Proceed(shapes);
        }
    }
}
