using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Steganography
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(openImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openImage.FileName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openText.ShowDialog() == DialogResult.OK)
                {
                    dataTextBox.Text = File.ReadAllText(openText.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveImage.FileName);
                    MessageBox.Show("Image saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveText.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveText.FileName, dataTextBox.Text);
                    MessageBox.Show("Text saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            Helper.hideText(dataTextBox.Text, (Bitmap)pictureBox.Image);
            pictureBox.Invalidate();
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            dataTextBox.Text = Helper.extractText((Bitmap)pictureBox.Image);
        }
    }
}
