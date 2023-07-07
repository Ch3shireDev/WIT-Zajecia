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
    for (int i = 0; i < n; i++)
    {
        suma += tab[i];
    }
    return suma / n;
}

int main()
{

    cout << "Podaj 5 ocen: ";
    int tab[5];
    for (int i = 0; i < 5; i++)
    {
        cin >> tab[i];
    }

    double sr = srednia(tab, 5);
    cout << "Średnia z ocen: " << sr << endl;
}