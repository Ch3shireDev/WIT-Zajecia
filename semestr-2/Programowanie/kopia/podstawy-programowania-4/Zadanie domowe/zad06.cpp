// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

void sort(double &x, double &y)
{
    if (x > y)
        return;

    double z = x;
    x = y;
    y = z;
}

int main()
{
    double x, y, z;
    cout << "Podaj trzy liczby rzeczywiste: ";
    cin >> x >> y >> z;
    sort(x, y);
    sort(x, z);
    cout << "Najwieksza liczba: " << x;
}