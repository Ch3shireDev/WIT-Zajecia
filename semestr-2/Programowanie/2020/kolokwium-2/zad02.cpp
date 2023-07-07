#include <iostream>
#include <cmath>
#include <cstdlib>
#include <ctime>
using namespace std;
int main()
{
    srand(time(0));
    int k1 = rand() % 6 + 1;
    int k2 = rand() % 6 + 1;
    cout << "Kostka 1: " << k1 << endl;
    cout << "Kostka 2: " << k2 << endl;
    cout << "Suma: " << k1 + k2 << endl;
}