using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    class KoniecGry:Form
    {
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private int p = 0;

        string[] imie ;
        string[] wyniki;
        int pts;

        public KoniecGry(Form frm, int pts)
        {
            InitializeComponent();
            this.pts = pts;
            readHigsc dane = new readHigsc();
            imie = new string[10];
            wyniki = new string[10];

            imie = dane.gsImie;
            wyniki = dane.gsWyniki;

            topten();
            grafika();
            
        }

        public void grafika()
        {
            this.BackgroundImage = Image.FromFile("pattern.png");
        }


#region TOP TEN
        private void topten()
        {
            int flag = 1;
            for (; p < wyniki.Length && flag == 1; p++)
            {
                if (pts >= Convert.ToInt32(wyniki[p]) )
                {
                    label1.Text = "Gratulacje! Masz: " + pts + " punktow! Zdobyles " + (p+1) + " miejsce";
                    
                    tworz();
                    flag = 0;
                }
                else if(pts < Convert.ToInt32(wyniki[p]))
                {
                    label1.Text = "Przykro mi masz tylko " + pts + " punktow."+"\n" + "Nie zmiesciles sie w rankingu";
                    this.button1.Location = new System.Drawing.Point(197, 66);
                }
            }
            label1.BackColor = Color.Transparent;

        }
#endregion TOP TEN

        private void sort()
        {
            --p;
            int pom;
            string pomtekst;
            string pomtekst2;
            pomtekst2 = textBox1.Text;
            for (; p < wyniki.Length; p++)
            {
                pom = Convert.ToInt32(wyniki[p]);
                pomtekst = imie[p];
                wyniki[p] = pts.ToString();
                imie[p] = pomtekst2;
                pts = pom;
                pomtekst2 = pomtekst;
            }
        }


        private void tworz()
        {
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imie:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Johnny";

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 66);
        }




        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // KoniecGry
            // 
            this.ClientSize = new System.Drawing.Size(308, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "KoniecGry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sort();
            try
            {
                StreamWriter writer = new StreamWriter("highscore.txt");
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine(imie[i] + " " + wyniki[i]);
                }
                writer.Close();
            }
            catch (IOException) { }

            this.Close();

        }


    }
}
