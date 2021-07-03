// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

void swap(int &a, int &b)
{
    int c = a;
    a = b;
    b = c;
}

void show(int &x)
{
    cout << "Adres: " << &x << "\t\t"
         << "Wartość: " << x << endl;
}

int main()
{
    int x, y;
    cout << "Podaj dwie liczby: ";
    cin >> x >> y;
    show(x);
    show(y);
    cout << "Zamiana:" << endl;
    swap(x, y);
    show(x);
    show(y);
}