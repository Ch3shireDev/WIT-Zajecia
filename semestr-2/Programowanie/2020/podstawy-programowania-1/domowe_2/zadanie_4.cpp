//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int min(int a, int b)
{
    return a < b ? a : b;
}
int main()
{
    int x = 5, y = 3;
    int z = min(x, y);
    cout << z << endl;
}