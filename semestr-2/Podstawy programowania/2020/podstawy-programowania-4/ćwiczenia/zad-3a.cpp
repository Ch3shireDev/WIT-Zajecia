//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    int h, m, s;
    cout << "Podaj godziny: ";
    cin >> h;
    cout << "Podaj minuty: ";
    cin >> m;
    cin >> m;
    cout << "Podaj sekundy: ";
    cin >> s;

    int stotal = h * 3600 + m * 60 + s;
    cout << "Czas w sekundach: " << stotal << endl;
}