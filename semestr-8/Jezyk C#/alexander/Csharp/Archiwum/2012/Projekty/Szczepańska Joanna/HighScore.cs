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
    public partial class HighScore : Form
    {
        Form frmMain;

        string[] imie;
        string[] wyniki;

        public HighScore(Form form)
        {
            frmMain = form;
            InitializeComponent();
            readHigsc dane = new readHigsc();

            imie = dane.gsImie;
            wyniki = dane.gsWyniki;

            grafika();

            wypiszHigsc();
        }

        public void grafika()
        {
            this.BackgroundImage = Image.FromFile("pattern.png");
        }

        public void wypiszHigsc()
        {
            textBox1.AppendText("Imie\t\t\tWyniki\n\n");
            for (int i = 0; i < 10; i++)
            {
                textBox1.AppendText((i+1)+". " +imie[i] + "\t\t\t" + wyniki[i] + "\n");
            }
        }

        public void reset()
        {
            int pom=100;
            for (int i = 0; i < 10; i++)
            {
                imie[i] = "John";
                wyniki[i] = pom.ToString();
                pom = pom - 10;
            }
        }

        public void zapiszDoPliku()
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            zapiszDoPliku();
            textBox1.Text = "";
            wypiszHigsc();
        }
    }
}
