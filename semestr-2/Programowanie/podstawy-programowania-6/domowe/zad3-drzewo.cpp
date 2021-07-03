// c) Napisz program w c++ na zastosowanie drzewa mające zastosowanie w praktyce
#include <set>
#include <iostream>
using namespace std;
int main()
{
    //struktura drzewa - używana przy zbiorze - jest bardzo dobra do sortowania liczb
    cout << "Wprowadź liczby do posortowania: ";

    set<int> tree = set<int>();
    int x;

    //pobieram od uzytkownika kolejne liczby i zapisuję je do zbioru
    while (cin >> x)
    {
        tree.insert(x);
    }

    cout << "Posortowane liczby: " << endl;

    //przechodzę iteratorem po zbiorze i wypisuję kolejne elementy. Wyskakują posortowane.
    for (auto it = tree.begin(); it != tree.end(); it++)
    {
        cout << *it << endl;
    }
}