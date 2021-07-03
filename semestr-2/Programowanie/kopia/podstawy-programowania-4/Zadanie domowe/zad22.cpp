// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

template<class T> 
T maximum(T *tab, int n)
{
    T max = tab[0];
    for (int i = 0; i < n; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }
    return max;
}

int main()
{
    int n;
    cout << "Podaj liczbę elementów: ";
    cin >> n;

    double *tab = new double[n];

    for (int i = 0; i < n; i++)
    {
        cout << "Podaj liczbę rzeczywistą nr " << i << ": ";
        cin >> tab[i];
    }

    cout << "Największa liczba: " << maximum(tab, n) << endl;
}