//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>

using namespace std;

//funkcja op przyjmuje dwa argumenty i decyduje o operacji na podstawie trzeciego
double op(int a, int b, int n)
{
    if (n == 1)
        return a + b;
    else if (n == 2)
        return a - b;
    else if (n == 3)
        return a * b;
    else if (n == 4)
        //mały trick by zmusić do zwrócenia wartości zmiennoprzecinkowej.
        return a / 1. / b;
    else
    {
        cout << "Nieprawidłowa operacja" << endl;
        return 0;
    }
}

int main()
{
    // stwórz program który pobiera dwie liczby i pozwala na wybranie operacji dodawania, odejmowania, mnożenia, dzielenia. Wyświetla wynik. Napisać wersję if oraz switch.
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
    // korzystamy z funkcji która wybiera operację zależnie od podanej wartosci n
    float result = op(a, b, n);
    cout << "Wynik operacji: " << result << endl;
}