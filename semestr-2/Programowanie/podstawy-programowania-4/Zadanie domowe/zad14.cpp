// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int factorial(int x)
{
    if (x < 0)
        return 0;
    if (x == 0)
        return 1;
    return factorial(x - 1) * x;
}

int main()
{
    int x;
    cout<<"Podaj liczbę: ";
    while (cin >> x)
    {
        cout << "Silnia z " << x << ": " << factorial(x) << endl;
        cout<<"Podaj liczbę: ";
    }
}