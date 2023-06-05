using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    public abstract class BridgeShapeList
    {
        public virtual void InitialiseProcess() {}
        public virtual void Proceed(Shape shape) {}
        public virtual void FinaliseProcess() {}

        public virtual void Proceed(List<Shape> shapes)
        {
            InitialiseProcess();
            foreach(Shape shape in shapes) Proceed(shape);
            FinaliseProcess();
        }
    }
}
