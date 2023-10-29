// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    double fahr;
    cout << "Podaj temperaturę w stopniach Fahrenheita: ";
    cin >> fahr;

    double celsjusz = (fahr - 32) * 5 / 9;

    cout << "Temperatura w stopniach Celsjusza: " << celsjusz << endl;

}