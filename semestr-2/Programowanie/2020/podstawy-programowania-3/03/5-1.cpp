//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    // stwórz program który zbiera 5 kolejnych ocen i wyznacza z nich średnią
    int tab[5];
    cout << "Podaj 5 kolejnych ocen: ";

    //zbieramy pięć kolejnych wartości od użytkownika, od razu w postaci int
    for (int i = 0; i < 5; i++)
        cin >> tab[i];

    //obliczamy średnia i wyświetlamy na ekranie.
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        sum += tab[i];
    }
    cout << "Średnia ocen: " << sum / 5. << endl;
}