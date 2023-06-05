using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualDrawing
{
    public partial class ManualDrawingForm : Form
    {
        private Shape shape;
        public ManualDrawingForm()
        {
            InitializeComponent();
            AbjustControl();
        }

        private void DrawAll()
        {
            float minX = 0;
            bool first = true;
            foreach(Shape shape in LbShapes.Items)
            {
                if(first)
                {
                    minX = shape.MinX();
                    first = false;
                }
                else
                {
                    minX = Math.Min(minX,shape.MinX());
                }
            }

            minX = LbShapes.Items.Cast<Shape>().Select(s => s.MinX()).Min();
        }
        private void AbjustControl()
        {
            int ListSize = LbShapes.Items.Count;
            int SelectedIndex = LbShapes.SelectedIndex;

            bool isListNotEmpty = (ListSize>0);
            bool isNotFirst = (SelectedIndex > 0);
            bool isNotLast = (SelectedIndex < ListSize - 1);
            bool isGoodParameters = (shape != null);

            BtnAdd.Enabled = isGoodParameters;
            BtnRemove.Enabled = isListNotEmpty;
            BtnUp.Enabled = isNotFirst && isListNotEmpty;
            BtnDn.Enabled = isNotLast && isListNotEmpty;
        }
        private void CbShapes_ParametersChanged(object sender, EventArgs e)
        {
            try
            {
                shape = new ShapeCircle(TbParamiters.Text.Trim());
            }
            catch(Exception) { shape = null; }
            AbjustControl();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AbjustControl();
        }
        private void BtnUp_Click(object sender, EventArgs e)
        {

            AbjustControl();
        }
        private void BtnDn_Click(object sender, EventArgs e)
        {
            AbjustControl();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int currentIndex=LbShapes.SelectedIndex;

            LbShapes.SelectedIndex = Math.Min(currentIndex, LbShapes.Items.Count - 1);
            LbShapes.SelectedIndex = currentIndex - (currentIndex >= LbShapes.Items.Count ? 1 : 0);
            AbjustControl();
        }
        private void LbShapes_SelectedValueChanged(object sender, EventArgs e)
        {
            AbjustControl();
        }
    }
}
