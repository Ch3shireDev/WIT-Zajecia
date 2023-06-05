using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Test018
{
    public partial class Form2 : Form
    {
        public delegate void RefreshEvent(object s);
        private RefreshEvent Inv;
        private Object Obj;
        //private string fakeProp { get { return ""; } set { Inv(Obj); } }
        public Form2(Object obj,RefreshEvent inv)
        {
            InitializeComponent();
            Inv += inv;
            Obj = obj;
            PropertyInfo[] prop = obj.GetType().GetProperties();
            for (int i = 0, y = 0; i < prop.Length; ++i)
            {
                if ((prop[i].CanRead)&&(prop[i].CanWrite))
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Location = new Point(4, 4+y);
                    label.Text = prop[i].Name;
                    Controls.Add(label);
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(4, 20 + y);
                    textBox.Size = new Size(200, 20);
                    textBox.DataBindings.Add("Text", obj, prop[i].Name, false, DataSourceUpdateMode.OnPropertyChanged);
                    textBox.TextChanged += textBox_TextChanged;
                    //DataBindings.Add("fakeProp", obj, prop[i].Name, false, DataSourceUpdateMode.OnPropertyChanged);
                    Controls.Add(textBox);
                    y += 50;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Inv(Obj);
        }
    }
}
