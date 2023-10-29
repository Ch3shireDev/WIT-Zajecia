//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

void rysujProstokat(int l, int h, char znak = '*')
{
    if (l <= 0 || h <= 0)
    {
        cout << "Nieprawidłowe wymiary prostokąta!" << endl;
        exit(0);
    }
    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < l; j++)
        {
            cout << znak;
        }
        cout << endl;
    }
}

int main()
{
    int szer, wys;
    cout << "Szerokość: ";
    cin >> szer;
    cout << "Wysokość: ";
    cin >> wys;
    cout << "Znak: ";
    char znak;
    cin >> znak;
    rysujProstokat(szer, wys, znak);
}