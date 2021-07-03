//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    double celsjusz, kelvin;

    cout << "Podaj temperature w skali Celsjusza: ";
    cin >> celsjusz;
    kelvin = celsjusz + 273.15;

    cout << "Temperatura w skali Kelvina: " << kelvin << endl;
    cout << "Podaj temperature w skali Kelvina: ";
    cin >> kelvin;
    celsjusz = kelvin - 273.15;
    cout << "Temperatura w skali Celsjusza: " << celsjusz << endl;
}