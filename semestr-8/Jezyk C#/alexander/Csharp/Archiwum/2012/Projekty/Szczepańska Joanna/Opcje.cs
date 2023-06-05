using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Opcje : Form
    {
        Form frmMain;
        public int xy, k;

        //*KONSTRUKTOR-------------------------------------------------------------------------/
        public Opcje(Form form)
        {
            frmMain = form;
            InitializeComponent();
            grafika();
            uzupelnijDane();
        }
        //*------------------------------------------------------------------------------------/



        public void grafika()
        {
            this.BackgroundImage = Image.FromFile("pattern.png");
        }

        public void uzupelnijDane()
        {
            comboBox1.Items.Add("8x8");
            comboBox1.Items.Add("9x9");
            comboBox1.Items.Add("10x10");
            xy = System.Convert.ToInt32(comboBox1.Text[0].ToString());
            k = System.Convert.ToInt32(comboBox2.Text[0].ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.Visible = true;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("8x8"))
            {
                comboBox2.Text = "5 kolorów";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("5 kolorów");
                comboBox2.Items.Add("6 kolorów");
                comboBox2.Items.Add("7 kolorów");
            }
            if (comboBox1.SelectedItem.Equals("9x9"))
            {
                comboBox2.Text = "6 kolorów";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("6 kolorów");
                comboBox2.Items.Add("7 kolorów");
                comboBox2.Items.Add("8 kolorów");
            }
            if (comboBox1.SelectedItem.Equals("10x10"))
            {
                comboBox2.Text = "7 kolorów";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("7 kolorów");
                comboBox2.Items.Add("8 kolorów");
                comboBox2.Items.Add("9 kolorów");
            }
            xy = System.Convert.ToInt32(comboBox1.Text[0].ToString());
            k = System.Convert.ToInt32(comboBox2.Text[0].ToString());

            if (xy == 1)
            {
                xy = 10;
            }
            
        }

        private void Opcje_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {          
            k = System.Convert.ToInt32(comboBox2.Text[0].ToString());
        }
    }
}
