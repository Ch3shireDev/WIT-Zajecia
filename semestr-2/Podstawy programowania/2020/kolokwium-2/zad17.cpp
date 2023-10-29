#include <iostream>
using namespace std;

int factorial(int n)
{
    return n == 0 ? 1 : factorial(n - 1) * n;
}

int newton(int n, int k)
{
    return factorial(n) / factorial(k) / factorial(n - k);
}

int main()
{
    int n;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < n - i; k++)
            cout << " ";
        for (int j = 0; j <= i; j++)
        {
            cout << newton(i, j) << " ";
        }
        cout << endl;
    }
}