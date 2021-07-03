//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <limits.h>

using namespace std;

int main()
{
    int x;
    int max = INT_MIN;

    cout << "Podaj zestaw liczb. By zakończyć, wciśnij CTRL+D : ";
    while (cin >> x)
    {
        if (x > max)
        {
            max = x;
        }
    }

    cout << "Największa liczba z zestawu: " << max << endl;
}