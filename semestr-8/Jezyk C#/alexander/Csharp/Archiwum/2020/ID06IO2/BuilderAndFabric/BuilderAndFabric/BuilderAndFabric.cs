using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderAndFabric
{
    public partial class BuilderAndFabric : Form
    {
        public BuilderAndFabric()
        {
            InitializeComponent();
            foreach(string kind in AnimalFabric.keys()) CbNames.Items.Add(kind);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            /*///
            StringBuilder sb=new StringBuilder();
            sb.Append("Ala ma kota ");
            sb.Append(100);
            sb.Append(':');
            sb.Append(3.5);
            EdLog.AppendText(sb.ToString()+Environment.NewLine);
            /*/
            EdLog.AppendText
            (
                new StringBuilder()
                .Append("Ala ma kota ")
                .Append(100)
                .Append(':')
                .Append(3.5)
                .ToString()
                +Environment.NewLine
            );
            //*///

            IdBuilder ib = new IdBuilder(", ","NULL");
            ib.Append(10);
            ib.Append(100);
            ib.Append(10);
            ib.Append(1);
            ib.SetDelimeter(", ");
            ib.SetIfEmpty("NULL");
            EdLog.AppendText(ib.ToString() + Environment.NewLine);

            EdLog.AppendText
            (
                new IdBuilder()
                .Append(10)
                .Append(100)
                .Append(10)
                .Append(1)
                .SetDelimeter(", ")
                .SetIfEmpty("NULL")
                .ToString()
                + Environment.NewLine
            );

            Animal animal = AnimalFabric.make(CbNames.SelectedText);
        }
    }
}
