//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    int n;
    cout << "Podaj liczbę wartości: ";
    cin >> n;
    int factorial = 1;
    for (int i = 1; i < n + 1; i++)
    {
        factorial *= i;
    }
    cout << "Silnia z " << n << ": " << factorial << endl;
}