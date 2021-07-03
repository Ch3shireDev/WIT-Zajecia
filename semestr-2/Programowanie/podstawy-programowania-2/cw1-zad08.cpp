//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <limits.h>

using namespace std;

int main()
{
    int x;
    cout << "Podaj wzrost (w centymetrach): ";
    cin >> x;

    if (x < 165)
    {
        cout << "Niski wzrost" << endl;
    }
    else if (x < 175)
    {
        cout << "Średni wzrost" << endl;
    }
    else
    {
        cout << "Wysoki wzrost" << endl;
    }
}