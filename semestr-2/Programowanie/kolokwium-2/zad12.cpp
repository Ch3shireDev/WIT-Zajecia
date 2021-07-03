#include <iostream>
using namespace std;

void clock(int hours, int minutes, double &x, double &y)
{
    x = hours % 12 * 30 + minutes / 60. * 30;
    y = minutes % 60 * 6;
}

int main()
{
    int hours, minutes;
    cout << "Podaj godziny: ";
    cin >> hours;
    cout << "Podaj minuty: ";
    cin >> minutes;
    double x, y;
    clock(hours, minutes, x, y);

    cout << x << " " << y << endl;
}