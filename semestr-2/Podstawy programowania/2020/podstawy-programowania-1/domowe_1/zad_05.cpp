//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double x, y, z;
    cout << "Podaj wartosci x oraz y: ";
    cin >> x >> y;

    z = pow(x + y, 2);
    z = pow(x, 2) + pow(y, 2);
    z = pow(x, 3) + pow(y, 2);
    z = pow(x + 3, 2);
    z = pow(x - 3, 2);
    z = x * (x + y);
    z = (pow(x, 2) + pow(y, 2)) / (x - y);
    z = pow(x + y, 2) / (x - y);
    z = (x + y) / (pow(x - y, 2));
    z = (pow(x, 2) + pow(y, 2)) / (pow(x, 2) - pow(y, 2));
    z = pow((x+3)/(x-3), 2);
}