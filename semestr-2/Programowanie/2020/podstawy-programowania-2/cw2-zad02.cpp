//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{

    int x, y;
    char operator_val;

    cout << "Podaj dwie liczby: ";
    cin >> x >> y;
    cout << "Podaj operację matematyczną (+,-,*,:): ";
    cin >> operator_val;

    switch (operator_val)
    {
    case '+':
        cout << "Wynik dodawania: " << x + y << endl;
        return 0;
    case '-':
        cout << "Wynik odejmowania: " << x - y << endl;
        return 0;
    case '*':
        cout << "Wynik mnożenia: " << x * y << endl;
        return 0;
    case ':':
        cout << "Wynik dzielenia: " << 1. * x / y << endl;
        return 0;
    }
}