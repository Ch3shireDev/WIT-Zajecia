#include <iostream>
#include <cmath>
using namespace std;

double srednia(double *tab, int n)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += tab[i];
    }
    return sum / n;
}

double blad(double *tab, int n, double x)
{
    double wynik = 0;
    for (int i = 0; i < n; i++)
    {
        wynik += (x - tab[i]) * (x - tab[i]);
    }

    return sqrt(wynik / (n - 1) / n);
}

int main()
{
    double sum = 0;
    int n = 0;

    double x;

    //użyłbym vector, ale nie mam dostępu do biblioteki. Zatem max wyników to 1024.
    double tab[1024];
    while (cin >> x)
    {
        tab[n] = x;
        n++;
    }

    cout << "Średnia: " << srednia(tab, n) << endl;
    cout << "Błąd: " << blad(tab, n, x) << endl;
}