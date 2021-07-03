//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

int main()
{
    double celsjusz, fahrenheit;

    cout << "Podaj temperature w stopniach Celsjusza: ";
    cin >> celsjusz;
    fahrenheit = celsjusz * 9 / 5. + 32;
    cout << "Temperatura w skali Fahrenheita: " << fahrenheit << endl;

    cout << "Podaj temperature w stopniach Fahrenheita: ";
    cin >> fahrenheit;
    celsjusz = 5 * (fahrenheit - 32) / 9.;
    cout << "Temperatura w skali Celsjusza: " << celsjusz << endl;
}