// Igor Nowicki
// IZ02P03
// 18608
#define _USE_MATH_DEFINES
#include <cmath>
#include <iostream>
using namespace std;

int main()
{
    double r;
    cout << "Podaj promień kuli: ";
    cin >> r;
    cout << "Objętość: " << 4 / 3. * M_PI * r * r * r << endl;
}