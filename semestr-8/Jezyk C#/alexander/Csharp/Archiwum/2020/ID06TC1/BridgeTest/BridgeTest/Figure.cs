using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    public interface Figure
    {
        void Draw(Graphics gr);
        string getKind();
        string getParameters();
    }
}
