//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    double a(0), b(0); // Definicje potrzebnych zmiennych
    cout << "Witaj w programie sumujacym liczby a i b!" << endl;
    cout << "Podaj wartosć liczby a: "; // Poproszenie użytkownika o pierwsza liczbe
    cin >> a;
    cout << "Podaj wartosć liczby b: "; // Poproszenie użytkownika o druga liczbe
    cin >> b;
    double const wynik(a + b);                         // Wykonanie działania
    cout << a << " + " << b << " = " << wynik << endl; // wyswietlenie wyniku
    return 0;
}