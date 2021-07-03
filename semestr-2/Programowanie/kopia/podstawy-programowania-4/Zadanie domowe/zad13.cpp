// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int tab[5][4];
    int suma = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            tab[i][j] = i * j;
            if (tab[i][j] % 2 == 0)
                suma += tab[i][j];
        }
    }

    cout << "Suma wszystkich parzystych elementów: " << suma << endl;
}