//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <limits.h>

using namespace std;

int main()
{
    int x;
    cout << "Podaj wiek (w latach): ";
    cin >> x;

    if (x < 18)
    {
        cout << "Osoba nieletnia" << endl;
    }
    else if (x < 35)
    {
        cout << "Osoba młoda" << endl;
    }
    else if (x < 65)
    {
        cout << "Osoba w średnim wieku" << endl;
    }
    else
    {
        cout << "Osoba starsza" << endl;
    }
}