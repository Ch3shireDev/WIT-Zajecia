//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

double srednia(double &a, double &b, double &c)
{
    return (a + b + c) / 3;
}

int main()
{
    // - stwórz funkcję obliczającą średnią z 3 liczb z wykorzystaniem referencji.
    double a, b, c;
    cout << "Podaj trzy liczby: ";
    cin >> a >> b >> c;
    double mean = srednia(a, b, c);
    cout << "Średnia: " << mean << endl;
}