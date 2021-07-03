//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    int x, y;
    cout << "Podaj dwie liczby: ";
    cin >> x >> y;
    if (x % y == 0)
    {
        cout << "Liczba " << x << " jest podzielna przez liczbę " << y << endl;
    }
    else
    {
        cout << "Liczba " << x << " nie jest podzielna przez liczbę " << y << endl;
    }
}