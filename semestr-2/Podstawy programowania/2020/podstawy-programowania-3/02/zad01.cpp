//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    cout << "Podaj zakres (od a do b): ";
    int a, b;
    cin >> a >> b;
    for (int i = a; i <= b; i++)
    {
        if (i % 2 == 0)
        {
            cout << i << endl;
        }
    }
}