//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{

    // Zad 4. Napisz program wyświetlający po kolei liczby o x większe od podanej liczby y aż do liczby 1000.
    int x, y;
    cout << "Podaj liczbę startu: ";
    cin >> y;
    cout << "Podaj różnicę: ";
    cin >> x;

    for (int i = y; i < 1000; i += x)
    {
        cout << "Bieżąca wartość: " << i << endl;
    }
}