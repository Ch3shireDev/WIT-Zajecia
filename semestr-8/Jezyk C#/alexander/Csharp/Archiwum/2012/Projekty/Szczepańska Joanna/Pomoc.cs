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
    public partial class Pomoc : Form
    {
        Form frmMain;

        public Pomoc(Form form)
        {
            frmMain = form;
            InitializeComponent();
            grafika();
        }

        public void grafika()
        {
            this.BackgroundImage = Image.FromFile("pattern.png");
            textBox1.Text = "Zadaniem gracza jest usuwanie kulek z planszy poprzez ustawianie obok siebie w ciągłej linii (poziomej, pionowej lub ukośnej) pięciu lub więcej kulek jednakowego koloru. Za każdą usuniętą kulkę otrzymuje się jeden punkt." + "\r\n" + "\r\n"

+ "W jednym ruchu dowolną kulkę można przestawić na dowolne puste pole planszy, o ile istnieje możliwość dojścia do niego poruszając się jedynie po sąsiednich pustych polach planszy (sąsiednie pola przylegają do siebie bokiem)." + "\r\n" + "\r\n"

+ "Jeśli przestawienie powoduje usunięcie kulek z planszy, to gracz wykonuje od razu kolejny ruch, a jeśli nie powoduje, na planszy pojawiają się trzy nowe kulki, zanim można wykonać kolejny ruch." + "\r\n" + "\r\n"

+ "Gra kończy się w momencie zapełnienia planszy, kiedy nie można już przestawić żadnej kulki.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.Visible = true;
            this.Close();
        }
    }
}
