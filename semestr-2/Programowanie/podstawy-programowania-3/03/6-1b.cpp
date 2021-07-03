//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

// identycznie jak w poprzednim przypadku, funkcja op zwraca różne operacje
// dla liczb a i b zależnie od podanych parametrów.
double op(int a, int b, int n)
{
    switch (n)
    {
    case (1):
        return a + b;
    case (2):
        return a - b;
    case (3):
        return a * b;
    case (4):
        return a / 1. / b;
    }

    int main()
    {
        int n, a, b;
        cout << "Podaj operację:" << endl;
        cout << "1. Dodawanie a + b" << endl;
        cout << "2. Odejmowanie a - b" << endl;
        cout << "3. Mnożenie a * b" << endl;
        cout << "4. Dzielenie całkowite a / b" << endl;
        cout << "Operacja: ";
        cin >> n;
        cout << "Podaj liczby a i b: ";
        cin >> a >> b;
        float result = op(a, b, n);
        cout << "Wynik operacji: " << result << endl;
    }