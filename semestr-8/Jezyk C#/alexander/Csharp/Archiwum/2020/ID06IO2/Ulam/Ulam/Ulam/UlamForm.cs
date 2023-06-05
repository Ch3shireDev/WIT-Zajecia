using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ulam
{
    public partial class UlamForm : Form
    {
        private int textH;
        private int textW;
        private uint[,] spirall;
        private bool[] noPrimes;
        private static readonly int Margin = 20;
        private static readonly Font font = new Font("Lucida Console", 12);
        public UlamForm()
        {
            InitializeComponent();
        }
        private void Sito(uint count)
        {
            noPrimes = new bool[count + 1];
            uint sqrt = (uint)Math.Sqrt(count);
            noPrimes[0] = noPrimes[1] = true;
            for (int i = 2; i < sqrt; ++i)
            {
                if (!noPrimes[i])
                {
                    for (int j = i << 1; j <= count; j += i)
                    {
                        noPrimes[j] = true;
                    }
                }
            }
        }

        private void textSize(uint count)
        {
            Bitmap bitmap = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(bitmap);
            
            //TO DO
            //SizeF size = g.MeasureString(, font)
        }

        private void fillSpirall(uint count)
        {
            bool b = (count & 1) == 0; // is odd

            int sqrt = (int)Math.Sqrt(count);
            spirall = new uint[sqrt, sqrt];
            int maxX, minX, maxY, minY;
            maxX = maxY = sqrt - 1;
            minX = minY = 0;
            while ((minX <= maxX) && (minY <= maxY))
            {
                if (!b)
                {
                    for (int x = minX; x <= maxX; ++x)
                    {
                        spirall[minY, x] = count--;
                    }
                    ++minY;
                    for (int y = minY; y <= maxY; ++y)
                    {
                        spirall[y, maxX] = count--;
                    }
                    --maxX;
                    b = true;
                }
                for (int x = maxX; x >= minX; --x)
                {
                    spirall[maxY, x] = count--;
                }
                --maxY;
                for (int y = maxY; y >= minY; --y)
                {
                    spirall[y, minX] = count--;
                }
                ++minX;
            }

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            uint count;
            if (uint.TryParse(TbCount.Text, out count))
            {
                count = (uint)Math.Ceiling(Math.Sqrt(count));
                count *= count;
                Sito(count);
                fillSpirall(count);
                return;
            }
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}