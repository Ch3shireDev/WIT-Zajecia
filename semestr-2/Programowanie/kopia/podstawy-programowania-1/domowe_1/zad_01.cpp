//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    int currYear;
    int grunwaldYear = 1410;

    cout << "Podaj biezacy rok: ";
    cin >> currYear;
    int delta = currYear - grunwaldYear;
    cout << "Liczba lat od bitwy pod Grunwaldem: " << delta << endl;
}