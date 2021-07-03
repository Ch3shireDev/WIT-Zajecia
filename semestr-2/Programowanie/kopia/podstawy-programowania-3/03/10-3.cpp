//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    // - stwórz funkcję obliczającą średnią z n liczb z wykorzystaniem wskaźników.
    int n;
    cout << "Podaj liczbę wartości: ";
    cin >> n;
    double *tab = new double[n];

    for (int i = 0; i < n; i++)
    {
        cout << "Podaj wartość " << i + 1 << ": ";
        cin >> tab[i];
    }

    double suma = 0;
    for (int i = 0; i < n; i++)
    {
        suma += tab[i];
    }

    cout << "Średnia: " << suma / n << endl;
}