using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class BridgeShapeList
    {
        protected virtual void InitialiseProcess() {}
        protected virtual void Proceed(Shape shape) { }
        protected virtual void FinaliseProcess() { }

        public virtual void Proceed(List<Shape> shapes)
        {
            InitialiseProcess();
            foreach (Shape shape in shapes) Proceed(shape);
            FinaliseProcess();
        }
    }
}
