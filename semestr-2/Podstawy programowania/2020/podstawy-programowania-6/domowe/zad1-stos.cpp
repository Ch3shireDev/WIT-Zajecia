// Igor Nowicki
// 18608

// a) Napisz program w c++ na zastosowanie stosu mające zastosowanie w praktyce
#include <stack>
#include <string>
#include <iostream>
using namespace std;

int main()
{
    //stos można zastosować przy tłumaczeniu liczb z binarnych na dziesietne

    stack<int> stos = stack<int>();
    string bin_num;

    //pobieramy liczbe binarna od uzytkownika w postaci stringa
    cout << "Binarna: ";
    cin >> bin_num;

    for (int i = 0; i < bin_num.length(); i++)
    {
        //wrzucam znaki z liczby binarnej w postaci 0 i 1.
        stos.push(bin_num[i] - '0');
    }

    int output_num = 0;
    int x = 1;

    //dopóki stos nie będzie opróżniony, powtarzam operację. Tę operację należy zaczynać od głowy, czyli wchodzi naturalnie struktura stosu.
    while (!stos.empty())
    {
        output_num += x * stos.top();
        stos.pop();
        x *= 2;
    }

//wypisuję liczbę dziesiętną
    cout << "Dziesiętna: " << output_num << endl;
}