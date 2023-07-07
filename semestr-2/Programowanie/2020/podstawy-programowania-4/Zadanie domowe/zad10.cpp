// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    string tab[10];
    cout << "Podaj kolejne 10 imion: ";
    for (int i = 0; i < 10; i++)
    {
        cin >> tab[i];
    }
    cout << endl;
    cout << "Imiona w odwrotnej kolejności:" << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << tab[9 - i] << endl;
    }
}