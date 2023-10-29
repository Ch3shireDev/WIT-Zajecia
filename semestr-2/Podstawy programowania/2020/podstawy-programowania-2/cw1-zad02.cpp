//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    double x, y;
    cout << "Podaj dwie liczby: ";
    cin >> x >> y;
    if (x > y)
    {
        cout << "Pierwsza liczba jest większa od drugiej" << endl;
    }
    else if (x < y)
    {
        cout << "Druga liczba jest większa od pierwszej" << endl;
    }
    else if (x == y)
    {
        cout << "Liczby są sobie równe" << endl;
    }
    else
    {
        cout << "Gratuluję, zniszczyłeś system" << endl;
    }
}