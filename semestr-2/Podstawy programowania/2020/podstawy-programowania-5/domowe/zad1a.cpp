#include <iostream>
using namespace std;

void sort_two_variables_ptr(int *a, int *b)
{
    if (*a < *b)
        return;
    int c = *a;
    *a = *b;
    *b = c;
}
void sort_two_variables_ref(int &a, int &b)
{
    if (a < b)
        return;
    int c = a;
    a = b;
    b = c;
}

void sort_three_variables_ptr(int *a, int *b, int *c)
{
    sort_two_variables_ptr(a, b);
    sort_two_variables_ptr(a, c);
    sort_two_variables_ptr(b, c);
}

void sort_three_variables_ref(int &a, int &b, int &c)
{
    sort_two_variables_ptr(&a, &b);
    sort_two_variables_ptr(&a, &c);
    sort_two_variables_ptr(&b, &c);
}

int main()
{
    //program przedstawiajacy przydatność funkcji wykorzystujących wskaźniki.
    //korzystając z funkcji operującej na wskaźnikach mogę posortować trzy zmienne
    //bez dodatkowych operacji nadpisywania w programie.

    int a = 5;
    int b = 3;
    int c = 10;

    cout << "Sortowanie poprzez wskaźniki: " << a << " " << b << " " << c << endl;
    sort_three_variables_ptr(&a, &b, &c);

    cout << a << endl;
    cout << b << endl;
    cout << c << endl;

    int x = 3;
    int y = 20;
    int z = 5;

    cout << "Sortowanie poprzez referencje: " << x << " " << y << " " << z << endl;
    
    //wersja wykorzystująca referencje do zmiennych.
    sort_three_variables_ref(x, y, z);

    cout << x << endl;
    cout << y << endl;
    cout << z << endl;
}