//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath>

using namespace std;

float op(int a, int b, int n)
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
        return a / b;
    case (5):
        int x = 1;
        for (int i = 0; i < b; i++)
        {
            x *= a;
        }
        return x;
    case (6):
        return log(a) / log(b);
    }
}

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