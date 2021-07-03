// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

bool is_prime(int x)
{
    if (x < 2)
        return false;

    for (int i = 2; i < x / 2 + 1; i++)
    {
        if (x % i == 0)
            return false;
    }
    return true;
}

int main()
{
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;
    if (is_prime(x))
    {
        cout << "tak" << endl;
    }
    else
    {
        cout << "nie" << endl;
    }
}