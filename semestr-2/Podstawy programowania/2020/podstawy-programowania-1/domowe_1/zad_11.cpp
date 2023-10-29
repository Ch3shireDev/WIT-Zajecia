//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    double a1, k;
    int n;
    cout << "Podaj pierwszy wyraz ciagu arytmetycznego: ";
    cin >> a1;
    cout << "Podaj roznice miedzy wyrazami ciagu arytmetycznego: ";
    cin >> k;
    cout << "Podaj liczbe elementow: ";
    cin >> n;
    double an = a1 + k * (n - 1);
    cout << "Wartosc " << n << "-tego wyrazu ciagu: " << an << endl;
}