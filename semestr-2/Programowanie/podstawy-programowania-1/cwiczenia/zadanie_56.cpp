//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <string>
using namespace std;
int main()
{
    cout << "Jak masz na imie?" << endl;
    string imieUzytkownika("Brak imienia"); // Rezerwujemy miejsce na laficuch znakéw
    cin >> imieUzytkownika;                 // Zapisujemy w utworzonej zmiennej tekst wpis:
    cout << "Ile wynosi liczba pi?" << endl;
    double piUzytkownika(-1.); // Rezerwujemy miejsce w pamieci na liczbe rzec:
    cin >> piUzytkownika;      // Zapisujemy w tej zmiennej to, co wpisze uiv‘
    cout << "Nazywasz sie " << imieUzytkownika << " i Twoim zdaniem liczba pi wynosi "
         << piUzytkownika << "" << endl;
    return 0;
}