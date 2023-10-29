//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{

    int currYear = 2020;
    int age;

    cout << "Podaj swoj wiek: ";
    cin >> age;
    int birthYear = currYear - age;
    cout << "Rok Twojego urodzenia przypada na " << birthYear << " lub " << birthYear - 1 << endl;
}