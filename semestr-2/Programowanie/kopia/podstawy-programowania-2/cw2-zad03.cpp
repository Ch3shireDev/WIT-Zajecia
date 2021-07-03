//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>

using namespace std;

int main()
{
    int x;
    cout << "Wybierz figurę której pole będziemy liczyć:" << endl;
    cout << "\t1. Kwadrat" << endl;
    cout << "\t2. Koło" << endl;
    cout << "\t3. Trójkąt" << endl;
    cout << "Podaj numer figury (1-3): " << endl;
    cin >> x;

    double area;

    switch (x)
    {
    case 1:
        double a;
        cout << "Podaj długość boku: ";
        cin >> a;
        area = a * a;
        break;
    case 2:
        double r;
        cout << "Podaj długość promienia: ";
        cin >> r;
        area = M_PI * r * r;
    case 3:
        double b, h;
        cout << "Podaj długość podstawy i wysokość: ";
        cin >> b >> h;
        area = b * h / 2;
    }
    cout << "Pole figury: " << area << endl;
}