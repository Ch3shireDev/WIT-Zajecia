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
    int h, m;
    cout << "Podaj godziny: ";
    cin >> h;
    cout << "Podaj minuty: ";
    cin >> m;
    int mtotal = h * 60 + m;
    cout << "Czas w minutach: " << mtotal << endl;
}