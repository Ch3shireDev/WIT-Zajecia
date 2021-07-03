//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <time.h>
using namespace std;
int main()
{
    // - zmierz ile czasu zajmie alokacja n liczb w tablicy i wykonanie prostej operacji na nich. Porównaj to z analogiczną operacją z wykorzystaniem wskaźnika.

    int n = 100000;
    int N = 100;

    int t1 = clock();

    for (int j = 0; j < N; j++)
    {
        int tab1[n];
        for (int i = 0; i < n; i++)
        {
            tab1[i] = i;
            tab1[i] += 50;
        }
    }
    int t2 = clock();

    int t3 = clock();
    for (int j = 0; j < N; j++)
    {
        int *tab2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            tab2[i] = i;
            tab2[i] += 50;
        }
        delete[] tab2;
    }
    int t4 = clock();

    cout << "Czas operacji na tablicy: " << t2 - t1 << endl;
    cout << "Czas operacji na wskaźnikach: " << t4 - t3 << endl;
}