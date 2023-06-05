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
    public partial class MainForm : Form
    {
        Opcje frmopcje;
        private int xy, k;

        public MainForm()
        {
            InitializeComponent();
            grafika();
            xy = 9;
            k = 6;
        }

        public void grafika()
        {
            this.BackgroundImage = Image.FromFile("pattern.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xy == 0)
            {
                xy = frmopcje.xy;
                k = frmopcje.k;
            }

            Form1 frmForm1 = new Form1(this, xy, k);
            frmForm1.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pomoc frmPomoc = new Pomoc(this);
            frmPomoc.Show();
            this.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xy = 0;
            frmopcje = new Opcje(this);  //przekazuje swojego forma do opcji
            frmopcje.Show();
                       
            this.Visible = false;   //ukrywa sie
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HighScore frmHighScore = new HighScore(this);
            frmHighScore.Show();

            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

         

    }
}
