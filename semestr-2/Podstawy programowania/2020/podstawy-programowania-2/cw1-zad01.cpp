//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    double x;
    cout << "Podaj liczbę: ";
    cin >> x;
    if (x > 0)
    {
        cout << "Liczba jest dodatnia" << endl;
    }
    else if (x < 0)
    {
        cout << "Liczba jest ujemna" << endl;
    }
    else if (x == 0)
    {
        cout << "Liczba jest zerowa" << endl;
    }
    else
    {
        cout << "Gratulacje, zniszczyłeś system" << endl;
    }
}