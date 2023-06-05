using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotTest
{
    public partial class MandelbrotForm : Form
    {
        private double X = -2, Y = -1, Zoom = 1; // Punkt zespolony odpowiedni do plaszczyzny Mandelbrota + Powiększenie
        public MandelbrotForm()
        {
            InitializeComponent();
            ShowValues(); // pokazuje punkt zespolony + powiększenie na formatce
            PicManbelbroat.Image = CalcBitmap(); // Obliczmy i podmieniamy obrazek
        }
        private void ShowValues()
        {
            EdX.Text = string.Format("{0:F18}", X); // pokazuje na formatce wartość X
            EdY.Text = string.Format("{0:F18}", Y); // pokazuje na formatce wartość Y
            EdZoom.Text = string.Format("{0:F18}", Zoom); // pokazuje na formatce wartość Zoom
        }
        private double CalcMul() // oblicza wartość mul dla przyśpieszenia obliczeń
        {
            return 3 / (PicManbelbroat.Width * Zoom);
        }
        private double ToComplex(double value,double mul,double shift) // wylicza współrzedną zespoloną z indeksu pixelowego
        { // mul z funkcji wyżej, shift to jedna ze zmiennych składowych X lub Y
            return value * mul + shift;
        }
        private Bitmap CalcBitmap() // Obliczmy obrazek
        {
            int xSize = PicManbelbroat.Width; // pobieramy szerokość
            int ySize = PicManbelbroat.Height; // pobieramy wysokość
            Color[,] clr = new Color[ySize, xSize]; // tworzymy regularną tablice kolorów
            double mul = CalcMul();// obliczamy wartość mul dla przyśpieszenia obliczeń
            for (int y = 0; y < ySize; ++y) // dla każdego y w tablice kolorów
            {
                double Pi = ToComplex(y, mul, Y); // wylicza współrzedną wyimaginowaną z indeksu pixelowego
                for (int x = 0; x < xSize; ++x) // dla każdego x w tablice kolorów
                {
                    double Pr = ToComplex(x, mul, X); // wylicza współrzedną rzeczywistą z indeksu pixelowego
                    uint index = MandelbrotHelper.Calc(Pi, Pr); // wyliczamy indeks koloru
                    clr[y, x] = MandelbrotHelper.Theme[index]; // wstawiamy kolor do regularnej tablicy kolorów
                }
            }
            return MandelbrotHelper.ArrToBmp(clr); // przeksztalcamy tablece kolorów na Bitmap'e i zwracamy
        }
        private void Ed_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlClient_Resize(object sender, EventArgs e)
        {
            PicManbelbroat.Image = CalcBitmap(); // Obliczmy i podmieniamy obrazek
            //PicManbelbroat.Dock = DockStyle.Fill; // "Workaround" buga .NET any onrazek został na całość panelu, VS-13
        }

        private void PicManbelbroat_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void PicManbelbroat_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void PicManbelbroat_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
