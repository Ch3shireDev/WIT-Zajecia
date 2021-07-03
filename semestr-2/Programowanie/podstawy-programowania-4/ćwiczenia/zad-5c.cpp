//Igor Nowicki
//IZ02P03
//18608


//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <random>
#include <time.h>
using namespace std;

int main()
{
    int n, a, b;
    srand(time(0));
    cout << "Ile liczb wylosować: ";
    cin >> n;
    cout << "Podaj przedział (a, b): ";
    cin >> a >> b;
    for (int i = 0; i < n; i++)
    {
        cout << rand() % (b - a) + a << endl;
    }
}