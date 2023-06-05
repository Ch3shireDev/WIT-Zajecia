using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ManualDrawing
{
    class RectangleShape:Shape
    {
        private static readonly Brush bg = Brushes.AntiqueWhite;
        private int ax,ay,bx,by;
        public RectangleShape(string parameters)
        {
            ParseParameters
            (
                parameters, 
                (SI)(v => ax=v),
                (SI)(v => ay=v),
                (SI)(v => bx=v),
                (SI)(v => by=v)
            );
            /*
            ParseParameters
            (
                parameters, 
                new SI[] 
                {
                    new SI(v => ax=v),
                    new SI(v => ay=v),
                    new SI(v => bx=v),
                    new SI(v => by=v),
                }
            );

            int[] param = ParseParameters(parameters, 4);
            int i = 0;
            ax = param[i++];
            ay = param[i++];
            bx = param[i++];
            by = param[i++];
            */
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(bg, ax, ay, bx - ax, by - ay);
        }
    }
}
