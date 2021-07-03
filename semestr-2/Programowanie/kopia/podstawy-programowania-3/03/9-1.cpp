//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    // ## Część 9

    // Stwórz funkcję która pobierze od użytkownika odległość w metrach i zwróci w jardach oraz cali.
    double metry;
    cout << "Odległość w metrach: ";
    cin >> metry;

    double jardy = 1.09361 * metry;
    double cale = 39.3701 * metry;

    cout << "Odległość w jardach: " << jardy << endl;
    cout << "Odległość w calach: " << cale << endl;
}