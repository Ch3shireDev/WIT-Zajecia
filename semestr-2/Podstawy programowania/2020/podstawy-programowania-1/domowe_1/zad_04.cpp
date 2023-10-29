//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    double netto;
    cout << "Podaj kwote netto: ";
    cin >> netto;
    double vat = netto * 0.23;
    double brutto = netto + vat;
    cout << fixed << setprecision(2);
    cout << "VAT wynosi " << vat << " PLN" << endl;
    cout << "Kwota brutto wynosi " << brutto << " PLN" << endl;
}