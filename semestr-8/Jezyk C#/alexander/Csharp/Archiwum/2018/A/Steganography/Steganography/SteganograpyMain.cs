using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class SteganographyMain : Form
    {
        Bitmap img = null;
        public SteganographyMain()
        {
            InitializeComponent();
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if(DlgOpen.ShowDialog()==DialogResult.OK)
            {
                ImgBox.Image = img = new Bitmap(DlgOpen.FileName);
            }
        }
        
        private int CalcMaxSize()
        {
            return 3 * img.Width * img.Height / 8;
        }
                
        private bool AbsentBitmap()
        {
            bool result = (img == null);
            if (result) MessageBox.Show("Najpierw należy otworzyć obrazek");
            return result;
        }

        private bool ToLongText(int len)
        {
            if (AbsentBitmap()) return true;
            bool result = (len >= CalcMaxSize());
            if (result) MessageBox.Show("Tekst jest zbyt długi");
            return result;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(AbsentBitmap()) return;
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                img.Save(DlgSave.FileName);
            }
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            byte[] str = UTF8Encoding.UTF8.GetBytes(EdText.Text.Trim());
            if (ToLongText(str.Length)) return;
            byte[] bmp = BitmapHelper.BitmapArray.BmpToArr(img);
            byte one = 1;
            for (int i = 0; i < bmp.Length; ++i) bmp[i] &= (byte)~one;
            int p = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                for (int m = 0; m < 8; ++m, ++p)
                {
                    if (p < bmp.Length) bmp[p] |= (byte)((str[i] >> m) & one);
                }
            }
            ImgBox.Image = img = BitmapHelper.BitmapArray.ArrToBmp(bmp, img.Width, img.Height);
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            if (AbsentBitmap()) return;
            byte[] str = new byte[CalcMaxSize()];
            byte[] bmp = BitmapHelper.BitmapArray.BmpToArr(img);
            byte one = 1;
            int p = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                for (int m = 0; m < 8; ++m, ++p)
                {
                    if (p < bmp.Length) str[i] |= (byte)((bmp[p] & one) << m);
                }
            }
            EdText.Text = UTF8Encoding.UTF8.GetString(str);
        }
    }
}
