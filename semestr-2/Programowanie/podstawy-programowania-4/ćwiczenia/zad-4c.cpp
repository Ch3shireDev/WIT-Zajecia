//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>

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

    ofstream file;
    file.open("oceny.txt");

    double sr = srednia(tab, n);
    cout << "Średnia z ocen: " << sr << endl;
    file << "Średnia z ocen: " << sr << endl;
    for (int i = 0; i < n; i++)
    {
        if (tab[i] == 0)
            continue;
        file << tab[i] << endl;
    }
}