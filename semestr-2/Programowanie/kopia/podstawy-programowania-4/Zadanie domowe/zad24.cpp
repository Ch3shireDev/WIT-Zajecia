// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
#include <string>
using namespace std;

int main()
{
    int n;
    cout << "Podaj liczbę naturalną: ";
    cin >> n;
    string str = to_string(n);

    cout << "Liczba cyfr: " << str.length() << endl;
}