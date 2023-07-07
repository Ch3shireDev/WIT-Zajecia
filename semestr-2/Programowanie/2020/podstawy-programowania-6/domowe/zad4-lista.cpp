// Igor Nowicki
// 18608

// d) Napisz program w c++ na zastosowanie listy mające zastosowanie w praktyce
#include <iostream>
#include <list>

using namespace std;

//strukturę listy można wykorzystać do składowania wartości (w przypadku braku konieczności natychmiastowego dostępu)
int main()
{
    list<int> lista;

    int x;
    //pobieram kolejne wartości od użytkownika i zapisuję je do listy
    while (cin >> x)
    {
        lista.push_back(x);
    }

    //przeprowadzam sortowanie bąbelkowe listy
    for (int i = 0; i < lista.size(); i++)
    {

        for (auto it = lista.begin(); it != lista.end(); it++)
        {
            auto it2 = it;
            it2++;
            if (it2 == lista.end())
                break;
            int x = *it;
            int y = *it2;

            if (x > y)
            {
                *it = y;
                *it2 = x;
            }
        }
    }

    // zwracam posortowaną listę
    cout << "Posortowana lista: " << endl;
    for (auto it = lista.begin(); it != lista.end(); it++)
    {

        cout << *it << endl;
    }
}