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
    public partial class BuilderAndFabricForm : Form
    {
        public BuilderAndFabricForm()
        {
            InitializeComponent();
            foreach (string kind in AnimalFabric.keys()) CbNames.Items.Add(kind);
            CbNames.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ala ma kota ");
            sb.Append(100);
            sb.Append(' ');
            sb.Append(3.5);
            EdLog.AppendText(sb + Environment.NewLine);

            EdLog.AppendText
            (
                new StringBuilder()
                .Append("Ala ma kota ")
                .Append(100)
                .Append(' ')
                .Append(3.5)
                + Environment.NewLine
            );

            IdBuilder ib = new IdBuilder("/", "nic");
            ib.SetDelimeter(", ");
            ib.SetIfEmpty("NULL");
            ib.Append(10);
            ib.Append(100);
            ib.Append(10);
            ib.Append(1);
            EdLog.AppendText(ib + Environment.NewLine);

            EdLog.AppendText
            (
                new IdBuilder()
                .SetDelimeter(", ")
                .SetIfEmpty("NULL")
                .Append(10)
                .Append(100)
                .Append(10)
                .Append(1)
                + Environment.NewLine
            );
            EdLog.AppendText(AnimalFabric.make(CbNames.SelectedItem.ToString()) + Environment.NewLine);
        }
    }
}
