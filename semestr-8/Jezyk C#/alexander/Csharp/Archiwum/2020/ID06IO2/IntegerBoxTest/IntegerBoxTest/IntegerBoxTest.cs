using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerBoxTest
{
    public partial class IntegerBoxTest : Form
    {
        private IntegerBox EdCount;
       
        public IntegerBoxTest()
        {
            InitializeComponent();
            EdCount = new IntegerBox();
            EdCount.Parent = this;
        }

    }
}
