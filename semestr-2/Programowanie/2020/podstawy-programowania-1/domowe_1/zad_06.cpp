//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    int a, b;
    cout << "Podaj dwie wartosci: ";
    cin >> a >> b;
    cout << "Wartosc a to " << a << ", wartosc b to " << b << endl;

    int c = a;
    a = b;
    b = c;
    cout << "Wartosc a to " << a << ", wartosc b to " << b << endl;
}