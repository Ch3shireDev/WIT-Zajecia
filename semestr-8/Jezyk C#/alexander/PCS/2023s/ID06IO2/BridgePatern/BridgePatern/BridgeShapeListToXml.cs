using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePatern
{
    public class BridgeShapeListToXml : BridgeShapeList
    {
        private TextBox field;
        private StringBuilder sb;
        public BridgeShapeListToXml(TextBox field)
        {
            this.field = field;
        }
        public override void InitialiseProcess()
        {
            sb
            =
                new StringBuilder()
                .AppendLine("<data>")
                .AppendLine("\t<shapes>")
            ;
        }

        public override void Proceed(Shape shape)
        {
            sb.Append("\t\t").AppendLine(shape.ToXml());
        }

        public override void FinaliseProcess()
        {
            field.Text
            =
                sb
                .AppendLine("\t</shapes>")
                .AppendLine("</data>")
                .ToString()
            ;
        }

    }
}
