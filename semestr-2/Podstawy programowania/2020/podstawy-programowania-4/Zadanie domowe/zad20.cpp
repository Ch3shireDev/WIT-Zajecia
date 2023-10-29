// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;
    if (x > 0)
    {
        cout << "Liczba jest dodatnia" << endl;
    }
    else if (x < 0)
    {
        cout << "Liczba jest ujemna" << endl;
    }
    else
    {
        cout << "Liczba jest równa zeru" << endl;
    }
}