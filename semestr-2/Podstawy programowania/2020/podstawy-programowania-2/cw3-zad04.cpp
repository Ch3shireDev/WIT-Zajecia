//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    int n;
    cout << "Podaj liczbę wartości na wejściu: ";
    cin >> n;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        int x;
        cout << "Podaj liczbę: ";
        cin >> x;
        sum += x;
    }
    cout << "Średnia: " << sum * 1. / n << endl;
}