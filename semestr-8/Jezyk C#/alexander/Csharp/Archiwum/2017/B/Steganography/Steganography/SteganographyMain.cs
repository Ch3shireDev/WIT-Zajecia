using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Steganography
{
    public partial class SteganographyMain : Form
    {
        private Bitmap bmp = null;
        public SteganographyMain()
        {
            InitializeComponent();
        }

        private void BtnOpenBmp_Click(object sender, EventArgs e)
        {
            DlgOpen.Title = "Load image ...";
            DlgOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All files (*.*)|*.*";
            DlgOpen.FilterIndex = 1;
            if (DlgOpen.ShowDialog()==DialogResult.OK)
            {
                bmp = new Bitmap(DlgOpen.FileName);
                BmpBox.Image = bmp;
            }
        }

        private void BtnSaveBmp_Click(object sender, EventArgs e)
        {
            DlgSave.Title = "Save image ...";
            DlgSave.Filter = "Bitmaps (*.bmp)|*.bmp|All files (*.*)|*.*";
            DlgSave.FilterIndex = 1;
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(DlgSave.FileName);                
            }
        }

        private void BtnOpenTxt_Click(object sender, EventArgs e)
        {
            DlgOpen.Title = "Load text ...";
            DlgOpen.Filter = "Bitmaps (*.txt)|*.txt|All files (*.*)|*.*";
            DlgOpen.FilterIndex = 1;
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                TxtBox.Text = File.ReadAllText(DlgOpen.FileName);
            }
        }

        private void BtnSaveTxt_Click(object sender, EventArgs e)
        {
            DlgSave.Title = "Save text ...";
            DlgSave.Filter = "Bitmaps (*.txt)|*.txt|All files (*.*)|*.*";
            DlgSave.FilterIndex = 1;
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(DlgSave.FileName, TxtBox.Text);
            }
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            byte[] arr = BitmapHelper.BitmapArray.BmpToArr(bmp);
            byte[] data = Encoding.UTF8.GetBytes(TxtBox.Text);
            int pos = 0, mask = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                byte val = 0;
                if(pos < data.Length)
                {
                    val = (byte)((data[pos] >> mask) & 1);
                    if (++mask >= 8)
                    {
                        mask = 0;
                        ++pos;
                    }
                }
                arr[i] &= 0xFE;
                arr[i] ^= val;
            }
            bmp = BitmapHelper.BitmapArray.ArrToBmp(arr, bmp.Width, bmp.Height);
            BmpBox.Image = bmp;
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            byte[] arr = BitmapHelper.BitmapArray.BmpToArr(bmp);
            List<byte> data = new List<byte>();
            byte val = 0;
            int mask = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                val |= (byte)((arr[i] & 1) << mask);
                if (++mask >= 8)
                {
                    if (val == 0) break;
                    data.Add(val);
                    val = 0;
                    mask = 0;
                }
            }
            TxtBox.Text = Encoding.UTF8.GetString(data.ToArray());
        }
    }
}
