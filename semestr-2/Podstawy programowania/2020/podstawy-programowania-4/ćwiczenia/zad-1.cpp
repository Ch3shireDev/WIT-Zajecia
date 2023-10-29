//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include "kalkulator.h"
using namespace std;

int main()
{
    int n, a, b;
    cout << "Podaj operację:" << endl;
    cout << "1. Dodawanie a + b" << endl;
    cout << "2. Odejmowanie a - b" << endl;
    cout << "3. Mnożenie a * b" << endl;
    cout << "4. Dzielenie całkowite a / b" << endl;
    cout << "5. Potęgowanie a^b" << endl;
    cout << "6. Logarytmowanie log_b(a)" << endl;
    cout << "Operacja: ";
    cin >> n;
    cout << "Podaj liczby a i b: ";
    cin >> a >> b;
    float result = op(a, b, n);
    cout << "Wynik operacji: " << result << endl;
}