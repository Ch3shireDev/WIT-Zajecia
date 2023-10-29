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
    cout << "Podaj promień koła: ";
    cin >> r;

    double circ = 2 * M_PI * r;
    double area = M_PI * r * r;

    cout << "Pole koła: " << area << endl;
    cout << "Obwód koła: " << circ << endl;
}