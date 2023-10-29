#define _USE_MATH_DEFINES

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double r;
    cout << "Podaj promien kola: ";
    cin >> r;
    double area = M_PI * r * r;
    double circum = 2 * M_PI * r;
    cout << "Pole kola: " << area << endl;
    cout << "Obwod kola: " << circum << endl;
}