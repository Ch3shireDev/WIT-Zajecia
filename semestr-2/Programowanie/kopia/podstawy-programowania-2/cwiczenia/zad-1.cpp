//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    // Zad 1. Napisz program obliczający średnią arytmetyczną dla dowolnej ilości podanych liczb całkowitych dodatnich x (zastosuj pętlę).

    int suma = 0;
    int x;
    int n = 0;
    cout << "Podaj liczbę: ";
    while (cin >> x)
    {
        suma += x;
        n += 1;
        cout << "Podaj liczbę: ";
    }

    cout << "Śrezdnia: " << suma / 1. / n << endl;
}