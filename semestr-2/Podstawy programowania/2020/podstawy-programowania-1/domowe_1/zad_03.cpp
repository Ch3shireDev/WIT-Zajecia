//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    double a;
    cout << "Podaj wartosc boku kwadratu: ";
    cin >> a;
    double pole_kw = a * a;
    cout << "Pole kwadratu to " << pole_kw << endl;

    double b, c;
    cout << "Podaj wartosc pierwszego boku prostokata: ";
    cin >> b;
    cout << "Podaj wartosc drugiego boku prostokata: ";
    cin >> c;
    double pole_prost = b * c;

    cout << "Pole prostokata to " << pole_prost << endl;

    double d, h;
    cout << "Podaj dlugosc podstawy trojkata: ";
    cin >> d;
    cout << "Podaj wysokosc trojkata: ";
    cin >> h;
    double pole_tr = d * h / 2;
    cout << "Pole trojkata to " << pole_tr << endl;
}