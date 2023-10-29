// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    double tab[10];
    cout << "Podaj 10 kolejnych liczb rzeczywistych: ";
    for (int i = 0; i < 10; i++)
        cin >> tab[i];

    double sum = 0;
    for (int i = 0; i < 10; i++)
    {
        sum += tab[i];
    }

    cout << "Suma: " << sum << endl;
}