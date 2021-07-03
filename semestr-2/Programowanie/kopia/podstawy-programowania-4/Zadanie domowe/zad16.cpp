// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

double mean(int *x, int n)
{
    double suma = 0;
    for (int i = 0; i < n; i++)
    {
        suma += x[i];
    }
    return suma / n;
}

int main()
{
    int x[10];
    cout << "Podaj 10 liczb całkowitych: ";
    for (int i = 0; i < 10; i++)
        cin >> x[i];
    cout << "Średnia: " << mean(x, 10) << endl;
}