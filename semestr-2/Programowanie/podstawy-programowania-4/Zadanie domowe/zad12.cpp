// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int tab[5][3];
    int suma = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            tab[i][j] = i * j;
            suma += tab[i][j];
        }
    }

    cout << "Suma wszystkich elementów: " << suma << endl;
}