//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <random>
#include <ctime>

using namespace std;

int main()
{
    srand(time(0));
    int r = rand() % 6 + 1;
    cout << r << endl;
}