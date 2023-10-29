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
    int a, b;
    srand(time(0));
    cout << "Podaj przedział (a, b): ";
    cin >> a >> b;
    for (int i = 0; i < 10; i++)
    {
        cout << rand() % (b - a) + a << endl;
    }
}