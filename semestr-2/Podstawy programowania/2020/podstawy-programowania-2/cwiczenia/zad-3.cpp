//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{

    //Zad 3. Napisz program który podnosi podaną liczbę całkowitą x do kwadratu dopóki nie będzie ona większa niż 10000 i podaje jej wartość. Program ma wypisać wszystkie liczby i ich wyniki na ekranie.
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;

    while (x < 10000)
    {
        cout << "Bieżąca wartość: " << x << endl;
        x *= x;
    }

    cout << "Zakończono na wartości: " << x << endl;
}