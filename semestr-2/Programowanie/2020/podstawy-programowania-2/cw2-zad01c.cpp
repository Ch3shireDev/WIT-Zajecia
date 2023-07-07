//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string *tab = new string[12]{"styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień"};

string get_month(int x)
{
    if (x > 0 && x < 13)
    {
        return tab[x - 1];
    }
    else
    {
        return "nieprawidłowy numer miesiąca";
    }
}
int main()
{
    int x;

    cout << "Podaj liczbe: ";
    cin >> x;
    cout << get_month(x) << endl;
}
