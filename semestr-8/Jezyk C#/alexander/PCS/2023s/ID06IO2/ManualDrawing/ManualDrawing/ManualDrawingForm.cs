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
        Shape shape = null;
        public ManualDrawingForm()
        {
            InitializeComponent();
            //CbShapes.Items.AddRange();
            //CbShapes.SelectedIndex=0;
            AdjustButons();
        }

        private void AdjustButons()
        {
            int ListSize = LbShapes.Items.Count;
            int SelectedIndex = LbShapes.SelectedIndex;

            bool SomeSelected = (0 <= SelectedIndex) && (SelectedIndex < ListSize);
            bool isNotFirst = (SomeSelected) && (SelectedIndex > 0);
            bool isNotLast = (SomeSelected) && (SelectedIndex + 1 < ListSize);
            bool isShapeParametersGood = (shape != null);

            BtnUp.Enabled = isNotFirst;
            BtnDn.Enabled = isNotLast;
            BtnRemove.Enabled = SomeSelected;
            BtnAdd.Enabled = isShapeParametersGood;
        }

        void Drawall()
        {
            float MinX = 0;
            bool first=true;
            foreach (Shape shape in LbShapes.Items)
            {
                if (first)
                {
                    MinX = shape.minX();
                    first = false;
                }
                else
                {
                    MinX = Math.Min(MinX,shape.minX());
                }
            }
            float minX = LbShapes.Items.Cast<Shape>().Select(s => s.minX()).Min();

            Bitmap bmp = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bmp);
            foreach (Shape shape in LbShapes.Items)
            {
                shape.Draw(g, new PointF(0, 0), 2);
            }
            PbImage.Image = bmp;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LbShapes.Items.Add(shape);
            Drawall();
            LbShapes.SelectedIndex = LbShapes.Items.Count - 1;
            TbParameters.SelectAll();
            TbParameters.Focus();
            AdjustButons();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = LbShapes.SelectedIndex;
            LbShapes.Items.RemoveAt(index);
            Drawall();
            AdjustButons();
            LbShapes.SelectedIndex = index - (index >= LbShapes.Items.Count ? 1 : 0);
            LbShapes.Focus();
            AdjustButons();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            int index = LbShapes.SelectedIndex, newindex = index - 1;

            Drawall();
            LbShapes.SelectedIndex = newindex;
            LbShapes.Focus();
            AdjustButons();
        }

        private void BtnDn_Click(object sender, EventArgs e)
        {
            int index = LbShapes.SelectedIndex, newindex = index + 1;

            Drawall();
            LbShapes.SelectedIndex = newindex;
            LbShapes.Focus();
            AdjustButons();
        }

        private void LbShapes_SelectedValueChanged(object sender, EventArgs e)
        {

            AdjustButons();
        }

        private void LblShapes_Enter(object sender, EventArgs e)
        {
            Text = Text + ".";
        }

        private void CbShapes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                shape = new Circle("100 100 90");
            }
            catch (Exception)
            {
                shape = null;
            }
            AdjustButons();
        }
    }
}
