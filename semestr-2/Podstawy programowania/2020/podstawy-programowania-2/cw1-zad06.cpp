//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    vector<double> tab = vector<double>(3);
    cout << "Podaj trzy liczby: ";
    cin >> tab[0] >> tab[1] >> tab[2];
    sort(tab.begin(), tab.end());

    cout << "Z liczb " << tab[0] << " " << tab[1] << " " << tab[2] << " ";

    if (abs(tab[0] * tab[0] + tab[1] * tab[1] - tab[2] * tab[2]) < 0.001)
    {
        cout << "można zbudować trójkąt prostokątny." << endl;
    }
    else
    {
        cout << "nie można zbudować trójkąta prostokątnego." << endl;
    }
}