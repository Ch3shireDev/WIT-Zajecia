#define _USE_MATH_DEFINES ;

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double a1, a2, h;
    cout << "Podaj pierwsza podstawe trapezu: ";
    cin >> a1;
    cout << "Podaj druga podstawe trapezu: ";
    cin >> a2;
    cout << "Podaj wysokosc trapezu: ";
    cin >> h;
    double area1 = (a1 + a2) * h / 2;
    cout << "Pole trapezu: " << area1 << endl;

    double a3, h2;
    cout << "Podaj bok rownolegloboku i jego wysokosc: ";
    cin >> a3 >> h2;
    double area2 = a3 * h2;
    cout << "Pole rownolegloboku: " << area2 << endl;

    double r1, r2;

    cout << "Podaj wiekszy i mniejszy promien pierscienia: ";
    cin >> r1 >> r2;
    double area3 = M_PI * (r1 * r1 - r2 * r2);
    cout << "Pole pierscienia: " << area3;
}