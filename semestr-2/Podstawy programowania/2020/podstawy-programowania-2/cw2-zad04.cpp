//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;
enum Food
{
    ciastka = 1,
    kopytka = 2,
    karmelki = 3
};

int main()
{
    int x;
    cout << "Czy chcesz zjeść ciastka czy kopytka?" << endl;
    cout << "Odpowiedź (1-ciastka, 2-kopytka, 3-karmelki): ";

    while (true)
    {
        cin >> x;

        switch (x)
        {
        case ciastka:
            cout << "Ciasteczka są dobre :3" << endl;
            return 0;
        case kopytka:
            cout << "Lubimy kopytka" << endl;
            return 0;
        case karmelki:
            cout << "Karmelki!" << endl;
            return 0;
        default:
            cout << "Wartość nieprawidłowa, podaj liczbę z przedziału 1-3: ";
            break;
        }
    }
}