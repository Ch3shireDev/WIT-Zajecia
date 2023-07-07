//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath> // Ważne!
using namespace std;
int main()
{
    double a(6), b(6); // Definicje potrzebnych zmiennych
    cout << "Witaj w programie obliczajacym a^b!" << endl;
    cout << "Podaj wartość a: "; // Monit o podanie pierwszej liczby
    cin >> a;
    cout << "Podaj wartość b: "; // Monit o podanie drugiej liczby
    cin >> b;
    double const wynik(pow(a, b)); // Wykonanie obliczeń
    // Moina też napisać tak:
    // double const wynik = pow(a,b);
    // Zapamietaj te dwie formy inicjacji zmiennych
    cout << a << " A " << b << " = " << wynik << endl; // Wyświetlenie wyniku
    return 0;
}