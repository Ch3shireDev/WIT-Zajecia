using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorTest
{
    public partial class DecoratorTest : Form
    {
        private List<CheckBox> CheckBoxes = new List<CheckBox>();
        public DecoratorTest()
        {
            InitializeComponent();
            foreach(string kind in CarList.list()) ModelBox.Items.Add(kind);
            ModelBox.SelectedIndex = 0;
            int index = 0;
            foreach (string kind in CarDecoratorList.list())
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Location = new System.Drawing.Point(3, 3 + index * 24);
                cb.Size = new System.Drawing.Size(80, 17);
                cb.TabIndex = index++;
                cb.Text = kind;
                cb.UseVisualStyleBackColor = true;
                Panel.Controls.Add(cb);
                CheckBoxes.Add(cb);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarList.make((string)ModelBox.SelectedItem);
            foreach(CheckBox cb in CheckBoxes)
            {
                if (cb.Checked) car = CarDecoratorList.make(cb.Text, car);
            }
            InfoBox.AppendText(car.info() + ": " + car.price() + Environment.NewLine);
        }
    }
}
