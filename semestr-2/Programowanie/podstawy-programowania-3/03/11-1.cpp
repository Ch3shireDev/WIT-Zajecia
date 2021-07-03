//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    // Stwórz program pobierający od użytkownika 3 liczby i wyświetlający największą z
    // nich. Pierwszy wariant napisz z użyciem funkcji if,
    // drugi ze wstępnym sortowaniem liczb.

    int a, b, c;
    cout << "Podaj trzy liczby: ";
    cin >> a >> b >> c;
    int max;
    if (a >= b && a >= c)
    {
        max = a;
    }
    else if (b >= a && b >= c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
    cout << "Największa liczba: " << max << endl;
}