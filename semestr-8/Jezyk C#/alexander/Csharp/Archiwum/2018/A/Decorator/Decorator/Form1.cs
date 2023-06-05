using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        private List<CheckBox> decor=new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
            foreach(string key in CarList.names()) BoxModel.Items.Add(key);
            BoxModel.SelectedIndex = 0;
            int index = 0;
            foreach (string key in DecoratedCarList.names())
            {
                CheckBox checkbox = new CheckBox();
                decor.Add(checkbox);
                checkbox.AutoSize = true;
                checkbox.Location = new Point(374, 39 + 24 * index);
                checkbox.Size = new Size(80, 17);
                checkbox.TabIndex = ++index;
                checkbox.Text = key;
                checkbox.UseVisualStyleBackColor = true;
                Controls.Add(checkbox);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string key = BoxModel.SelectedItem as string;
            Car car = CarList.make(key);
            foreach (CheckBox box in decor)
            { 
                if(box.Checked)
                {
                    car = DecoratedCarList.make(box.Text, car);
                }
            }
            Info.AppendText(car.info() + ": " + car.price() + Environment.NewLine);
        }
    }
}
