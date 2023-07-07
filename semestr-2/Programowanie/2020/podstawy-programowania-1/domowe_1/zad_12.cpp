//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double a1, q;
    int n;
    cout << "Podaj pierwszy wyraz ciagu geometrycznego: ";
    cin >> a1;
    cout << "Podaj iloraz ciagu geometrycznego: ";
    cin >> q;
    cout << "Podaj liczbe elementow ciagu: ";
    cin >> n;
    double an = a1 * pow(q, n - 1);
    cout << "Wartosc n-tego wyrazu ciagu geometrycznego: " << an << endl;
}