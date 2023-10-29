//Igor Nowicki
//IZ02P03
//18608

//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <random>
#include <time.h>
using namespace std;

int main()
{
    srand(time(0));
    int a = 50, b = 200;
    int r = rand() % (b - a) + a;
    int n = 0;
    while (true)
    {
        string buffer;
        int x;
        cout << "Podaj liczbę: ";
        getline(cin, buffer);

        try
        {
            x = atoi(buffer.c_str());
        }
        catch (exception)
        {
            cout << "Wartość nieprawidłowa!" << endl;
            continue;
        }

        if (x < a || x > b)
        {
            cout << "Wartość powinna być z zakresu od " << a << " do " << b << " !" << endl;
            continue;
        }

        if (x > r)
        {
            cout << "Za duża!" << endl;
        }
        else if (x < r)
        {
            cout << "Za mała!" << endl;
        }
        else if (x == r)
        {
            cout << "Gratulacje, szukana liczba to " << r << " !" << endl;
            break;
        }
    }
}