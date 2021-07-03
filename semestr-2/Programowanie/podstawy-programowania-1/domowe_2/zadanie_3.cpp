//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    int otw, zam, godz;
    cout << "Podaj godzine otwarcia i godzine zamkniecia sklepu: " << endl;
    cin >> otw >> zam;
    cout << "Podaj biezaca godzine: ";
    cin >> godz;
    bool otwarty = godz >= otw && godz <= zam;
    if (otwarty)
    {
        cout << "Sklep jest otwarty" << endl;
    }
    else
    {
        cout << "Sklep jest zamkniety" << endl;
    }
}