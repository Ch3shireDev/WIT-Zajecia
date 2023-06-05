using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public class BridgeShapeListToXml: BridgeShapeList
    {
        private TextBox field;
        private StringBuilder sb;
        public BridgeShapeListToXml(TextBox field)
        {
            this.field = field;
        }

        protected override void InitialiseProcess()
        {
            sb
            =
                new StringBuilder()
                .AppendLine("<root>")
                .AppendLine("\t<shapes>")
            ;
        }

        protected override void Proceed(ShapeBase shape)
        {
            sb.Append("\t\t").AppendLine(shape.ToXml());
        }

        protected override void FinaliseProcess()
        {
            field.Text=sb
                .AppendLine("\t</shapes>")
                .AppendLine("</root>")
                .ToString()
            ;
        }
    }
}
