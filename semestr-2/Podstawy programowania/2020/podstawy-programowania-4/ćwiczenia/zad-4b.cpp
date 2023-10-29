//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

double srednia(int *tab, int n)
{
    double suma = 0;
    int m = 0;
    for (int i = 0; i < n; i++)
    {
        if (tab[i] != 0)
            m++;
        suma += tab[i];
    }
    return suma / m;
}

int main()
{
    int n = 10000;
    int tab[n];
    for (int i = 0; i < n; i++)
    {
        tab[i] = 0;
    }

    cout << "Podaj oceny: ";

    int i = 0;
    while (cin >> tab[i])
    {
        i++;
    }

    double sr = srednia(tab, n);
    cout << "Średnia z ocen: " << sr << endl;
}