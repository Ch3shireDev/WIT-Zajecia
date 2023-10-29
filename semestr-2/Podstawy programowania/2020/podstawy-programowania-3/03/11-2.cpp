//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

void swap(int &a, int &b)
{
    int c = a;
    a = b;
    b = c;
}

int main()
{
    // Stwórz program pobierający od użytkownika 3 liczby i wyświetlający największą z
    // nich. Pierwszy wariant napisz z użyciem funkcji if,
    // drugi ze wstępnym sortowaniem liczb.

    int a, b, c;
    cout << "Podaj trzy liczby: ";
    cin >> a >> b >> c;

    if (a > b)
    {
        swap(a, b);
    }
    if (b > c)
    {
        swap(b, c);
    }
    if (a > c)
    {
        swap(a, c);
    }

    cout << "Największa liczba: " << c << endl;
}