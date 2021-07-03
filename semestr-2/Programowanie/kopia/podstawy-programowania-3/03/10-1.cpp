//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{

    // ## Część 10

    // - Stwórz na wskaźnikach pobieranie n liczb do tablicy.
    int n;
    cout << "Podaj liczbę wartości: ";
    cin >> n;

    int *tab = new int[n];

    for (int i = 0; i < n; i++)
    {
        cin >> tab[i];
    }

    cout << "Pobrano " << n << " wartości:" << endl;
    for (int i = 0; i < n; i++)
    {

        cout << "Wartość " << i +1<< ": " << tab[i] << endl;
    }
}