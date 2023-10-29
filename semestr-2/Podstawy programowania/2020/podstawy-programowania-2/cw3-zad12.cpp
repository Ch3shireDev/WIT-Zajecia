//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>

using namespace std;

void fun(int x, int y = 0)
{
    for (int i = 0; i < y; i++)
    {
        cout << " ";
    }
    for (int i = 0; i < x; i++)
    {
        cout << "*";
    }
    cout << endl;
}

int main()
{
    int n;
    cout << "Podaj liczbę gwiazdek w boku: ";
    cin >> n;

    for (int i = 0; i < n; i++)
    {
        fun(2 * i + 1, n - i - 1);
    }
    for (int i = 1; i < n; i++)
    {
        fun(2 * n + 1 - 2 * i - 2, i);
    }
}