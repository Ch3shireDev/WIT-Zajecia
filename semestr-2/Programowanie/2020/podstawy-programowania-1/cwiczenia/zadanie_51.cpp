//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <string>
using namespace std;
int main()
{
    int lataUzytkownika;
    string imieUzytkownika;
    string nazwiskoUzytkownika;
    cout << "Jak masz na imie?: " << endl;
    cin >> imieUzytkownika;
    cout << "Jak masz na nazwisko?:" << endl;
    cin >> nazwiskoUzytkownika;
    cout << "Ile masz lat?:" << endl;
    cin >> lataUzytkownika;
    cout << "Nazywasz się " << imieUzytkownika << " " << nazwiskoUzytkownika << " i masz lat " << lataUzytkownika << endl;
    return 0;
}