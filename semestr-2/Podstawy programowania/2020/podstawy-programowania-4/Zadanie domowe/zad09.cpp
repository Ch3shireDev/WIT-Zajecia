// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int tab[10];
    for (int i = 0; i < 10; i++)
    {
        tab[i] = i;
    }

    cout << "Zawartość tablicy: " << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << "Adres: " << &(tab[i]) << "\t\tWartość: " << tab[i] << endl;
    }
}