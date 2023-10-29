// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
#include <cmath>
using namespace std;

int factorial(int x)
{
    if (x < 0)
        return 0;
    if (x == 0)
        return 1;
    return x * factorial(x - 1);
}

int main()
{
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;
    if (x < 0)
    {
        cout << "Liczba musi być dodatnia." << endl;
        return 0;
    }
    cout << "Silnia: " << factorial(x) << endl;
}