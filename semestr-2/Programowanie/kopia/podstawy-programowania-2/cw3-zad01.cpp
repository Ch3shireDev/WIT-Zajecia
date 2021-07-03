//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    for (int i = 1; i < 11; i++)
    {
        for (int j = i; j < 11; j++)
        {
            cout << i << " * " << j << " = " << i * j << endl;
        }
    }
}