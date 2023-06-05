using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeTest
{
    public partial class BridgeTestForm : Form
    {
        BridgeImage bi;
        BridgeList bl;
        List<Figure> lst=new List<Figure>();
        public BridgeTestForm()
        {
            InitializeComponent();
            ImageBox.Image = new Bitmap(1000, 1000);
            bi = new BridgeImage(ImageBox);
            bl = new BridgeList(LbFigures);
            foreach (string fig in Figure.keys()) CbFigure.Items.Add(fig);
            CbFigure.SelectedIndex = 0;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string kind = CbFigure.SelectedItem.ToString();
            string param = EdParameters.Text;
            Figure fig = Figure.make(kind, param);
            lst.Add(fig);
            bl.Draw(lst);
            bi.Draw(lst);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Figure fig = LbFigures.SelectedItem as Figure;
            lst.Remove(fig);
            bl.Draw(lst);
            bi.Draw(lst);
        }
    }
}
