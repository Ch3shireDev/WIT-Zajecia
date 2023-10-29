// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int tab[10];
    int x = 1;
    for (int i = 0; i < 10; i++)
    {
        tab[i] = x;
        x *= 2;
    }

    for (int i = 0; i < 10; i++)
    {
        cout << tab[i];
        if (i < 9)
            cout << ", ";
    }
    cout << endl;
}