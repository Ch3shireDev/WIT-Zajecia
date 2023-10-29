//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

bool op(int a, int b, int n)
{
    switch (n)
    {
    case (1):
        return a > b;
    case (2):
        return a < b;
    case (3):
        return a == b;
    case (4):
        return a != b;
    }
}

int main()
{
    int a, b, n;
    cout << "Podaj dwie liczby:";
    cin >> a >> b;
    cout << "Wybierz operację:" << endl;
    cout << "1. Czy a jest większy od b ( a > b)" << endl;
    cout << "2. Czy a jest mniejszy od b ( a < b)" << endl;
    cout << "3. Czy a równy b ( a == b)" << endl;
    cout << "4. Czy a nie jest równy b ( a != b)" << endl;

    cin >> n;

    cout << "Wynik: " << (op(a, b, n) ? "true" : "false") << endl;
}