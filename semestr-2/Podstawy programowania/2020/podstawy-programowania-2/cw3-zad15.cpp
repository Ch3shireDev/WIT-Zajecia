//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>

using namespace std;

void fun(int x, char c)
{
    for (int i = 0; i < x; i++)
    {
        cout << c;
    }
}

void fun2(int n, char a, char b)
{

    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            fun(n, a);
            fun(n, b);
        }
        cout << endl;
    }
}

int main()
{
    int n = 4;

    for (int i = 0; i < 4; i++)
    {
        fun2(n, '*', ' ');
        fun2(n, ' ', '*');
    }
}
