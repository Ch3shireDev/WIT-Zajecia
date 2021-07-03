//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    // stwórz program wyznaczajacy n-tą liczbę fibonacciego
    cout << "Podaj którą liczbę Fibonacciego wyznaczyć: ";
    int n;
    cin >> n;

    //alokacja n wartości w tablicy jest w niektórych kompilatorach niedozwolona,
    // natomiast zawsze możemy uzyć wskaźników.
    int *tab = new int[n];

    tab[0] = 1;
    tab[1] = 1;

    for (int i = 2; i < n; i++)
    {
        tab[i] = tab[i - 1] + tab[i - 2];
    }

    cout << "Liczba Fibonacciego " << n << ": " << tab[n - 1] << endl;
}