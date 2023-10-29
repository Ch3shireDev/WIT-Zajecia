//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "Podaj liczbe calkowita: ";
    cin >> n;
    string x = to_string(n);

    int setki = 0, dziesiatki = 0, jednosci = 0;
    if (n > 99)
        setki = x[x.length() - 3] - '0';
    if (n > 9)
        dziesiatki = x[x.length() - 2] - '0';
    jednosci = x[x.length() - 1] - '0';

    cout << "Liczba setek to " << setki << endl;
    cout << "Liczba dziesiatek to " << dziesiatki << endl;
    cout << "Liczba jednosci to " << jednosci << endl;
}