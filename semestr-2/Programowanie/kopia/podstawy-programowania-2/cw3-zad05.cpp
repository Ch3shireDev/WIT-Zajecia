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
    int sum = 0;
    for (int i = 1; i < n + 1; i++)
    {
        sum += i;
    }
    cout << "Suma ciągu od 1 do " << n << ": " << sum << endl;
}