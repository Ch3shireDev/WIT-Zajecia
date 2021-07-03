// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int nwd(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }
    return a;
}

int main()
{
    int x, y;

    cout << "Podaj dwie liczby: ";
    cin >> x >> y;

    cout << "Największy wspólny dzielnik: " << nwd(x, y) << endl;
}