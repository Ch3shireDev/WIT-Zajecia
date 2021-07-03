// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int divisors_sum(int n)
{
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum;
}

int main()
{

    int n;
    cout << "Podaj liczbę naturalną: ";
    cin >> n;

    cout << "Suma dzielników: " << divisors_sum(n) << endl;
}