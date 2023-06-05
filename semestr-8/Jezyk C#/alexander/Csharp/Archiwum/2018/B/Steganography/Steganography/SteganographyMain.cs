using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitmapHelper;

namespace Steganography
{
    public partial class Steganography : Form
    {
        private Bitmap img = null;
        public Steganography()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(DlgOpen.FileName);
                BoxImage.Image = img;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (img == null) return;
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                img.Save(DlgSave.FileName);
            }
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (img == null) return;
            byte[] bmp = BitmapArray.BmpToArr(img);
            byte[] arr = UTF8Encoding.UTF8.GetBytes(EdText.Text);
            byte one = 1, none = (byte)(~one);
            for (int k = 0; k < bmp.Length; ++k) bmp[k] &= none;
            int i = 0;
            for (int a = 0; a < arr.Length; ++a)
            {
                for (int b = 0; b < 8; ++b, ++i)
                {
                    if (i < bmp.Length) bmp[i] |= (byte)((arr[a] >> b) & one);
                }
            }
            img = BitmapArray.ArrToBmp(bmp, img.Width, img.Height);
            BoxImage.Image = img;
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)BoxImage.Image;
            if (img == null) return;
            byte[] bmp = BitmapArray.BmpToArr(img);
            byte[] arr = new byte[(3 * img.Width * img.Height) >> 3];
            byte one = 1, none = (byte)(~one);
            int i = 0;
            for (int a = 0; a < arr.Length; ++a)
            {
                for (int b = 0; b < 8; ++b, ++i)
                {
                    if (i < bmp.Length) arr[a] |= (byte)((bmp[i] & one) << b);
                }
            }
            EdText.Text = UTF8Encoding.UTF8.GetString(arr);
        }
    }
}
