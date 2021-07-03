#include <iostream>
#include <cmath>
using namespace std;

// barometric
int main()
{
    double p, T;
    cout << "Ciśnienie w hektopaskalach: ";
    cin >> p;
    cout << "Temperatura w Kelwinach: ";
    cin >> T;

    double R = 8.3144598;
    double mu = 0.0289644;
    double p0 = 1013.25;
    double g = 9.80665;

    double h = -R * T / (mu * g) * log10(p / p0);

    cout << h << endl;
}