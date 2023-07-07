//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    // Zad 2. Napisz program liczący sumę kwadratów wszystkich liczb całkowitych dodatnich do podanej liczby x.
    int x;
    cout << "Podaj liczbę: ";
    cin >> x;
    int suma = 0;
    for (int i = 1; i <= x; i++)
    {
        suma += i * i;
    }
    cout << "Suma kwadratów: " << suma << endl;
}