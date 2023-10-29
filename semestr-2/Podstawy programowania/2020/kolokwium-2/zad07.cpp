#include <iostream>
using namespace std;

bool is_in(int n, int *tab, int size)
{
    for (int i = 0; i < size; i++)
    {
        if (tab[i] == n)
            return true;
    }
    return false;
}

int main()
{
    int setTab[6] = {1, 2, 5, 6, 7, 9};
    int dziesTab[4] = {1, 2, 4, 8};

    for (int i = 100; i < 1000; i++)
    {
        int jednostki = i % 10;
        int dziesiatki = i / 10 % 10;
        int setki = i / 100;

        if (!is_in(setki, setTab, 6))
            continue;
        if (!is_in(dziesiatki, dziesTab, 4))
            continue;
        if (jednostki % 2 == 1)
            continue;
        if (jednostki + dziesiatki + setki != 7)
            continue;
        cout << i << endl;
    }
}