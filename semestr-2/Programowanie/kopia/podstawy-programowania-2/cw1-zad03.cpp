//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;
    if (x % 2 == 0)
    {
        cout << "Liczba jest parzysta" << endl;
    }
    else
    {
        cout << "Liczba jest nieparzysta" << endl;
    }
}