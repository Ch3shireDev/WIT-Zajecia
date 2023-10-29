
// Zadanie 3
// Napisać funkcję swap, która zamieni miejscami dwa elementy, typu int, podane jako jej argumenty. Oczywiście argumenty muszą być przekazane przez adres. Uwaga: Choć taka funkcja operująca na danych typu int może wydawać się nieprzydatna. (W podobny sposób można napisać funkcję zamieniającą dwa rekordy – bardzo złożone typy danych).
#include <iostream>
using namespace std;

template <typename T>
void swap(T *a, T *b)
{
    T val = *a;
    *a = *b;
    *b = val;
}

int main()
{
    int a = 5, b = 3;
    cout << "Wartość a: " << a << endl;
    cout << "Wartość b: " << b << endl;
    swap(&a, &b);
    cout << "Wartość a: " << a << endl;
    cout << "Wartość b: " << b << endl;
    return 0;
}