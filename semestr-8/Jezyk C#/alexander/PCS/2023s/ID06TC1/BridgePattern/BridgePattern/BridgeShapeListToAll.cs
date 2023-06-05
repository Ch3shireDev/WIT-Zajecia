using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class BridgeShapeListToAll : BridgeShapeList
    {
        private BridgeShapeList[] list;
        public BridgeShapeListToAll(params BridgeShapeList[] list)
        {
            this.list = list;
        }
        public override void Proceed(List<ShapeBase> shapes)
        {
            foreach (BridgeShapeList bridge in list) bridge.Proceed(shapes);
        }
    }
}
