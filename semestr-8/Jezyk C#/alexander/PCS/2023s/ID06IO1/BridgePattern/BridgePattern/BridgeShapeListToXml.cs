using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    class BridgeShapeListToXml : BridgeShapeList
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
                .AppendLine("\t<spapes>")
            ;
        }

        protected override void Proceed(Shape shape)
        {
            sb.Append("\t\t").AppendLine(shape.ToXml());
        }

        protected override void FinaliseProcess()
        {
            field.Text
            =
                sb
                .AppendLine("\t</spapes>")
                .AppendLine("</root>")
                .ToString()
            ;
        }
    }
}
