//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
#include <vector>
using namespace std;
int main()
{
    // - stwórz program który wczyta pomiary z pliku do tablicy, a następnie powie ile było pomiarów i wypisze je wszystkie na ekranie. Skorzystaj z funkcji eof.

    fstream file;
    file.open("pomiary.txt");

    vector<double> tab;

    while (!file.eof())
    {
        double x;
        file >> x;
        tab.push_back(x);
    }

    cout << "Zanotowano " << tab.size() << " wyników" << endl;

    for (int i = 0; i < tab.size(); i++)
    {
        cout << "Wynik " << i + 1 << ": " << tab[i] << endl;
    }
}