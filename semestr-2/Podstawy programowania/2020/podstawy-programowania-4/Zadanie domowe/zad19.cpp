// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

void reverse_copy(int *tab1, int *tab2, int n)
{
    for (int i = 0; i < n; i++)
    {
        tab2[n - i - 1] = tab1[i];
    }
}

void show_array(int *tab, int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << "Adres: " << &tab[i] << "\t\t"
             << "Wartość: " << tab[i] << endl;
    }
}

int main()
{
    int n;
    cout << "Podaj wielkość tablicy: ";
    cin >> n;

    int *tab1 = new int[n];
    int *tab2 = new int[n];

    for (int i = 0; i < n; i++)
    {
        cout << "Podaj element " << i << ": ";
        cin >> tab1[i];
    }

    reverse_copy(tab1, tab2, n);

    cout << "Pierwsza tablica:" << endl;
    show_array(tab1, n);
    cout << "Druga tablica:" << endl;
    show_array(tab2, n);

    delete[] tab1, tab2;
}