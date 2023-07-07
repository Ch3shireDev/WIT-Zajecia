#include <iostream>
using namespace std;

int collatz(int n)
{
    return n % 2 == 0 ? n / 2 : 3 * n + 1;
}

int main()
{
    int n;
    cout << "Podaj liczbę: ";
    cin >> n;
    while (n > 1)
    {
        n = collatz(n);
        cout << n << endl;
    }
}