//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string *tab = new string[7]{"poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela"};

string get_day(int x)
{
    if(x>0 && x<8){
        return tab[x-1];
    }
    else{
        return "nieprawidłowy numer dnia";
    }
}
int main()
{
    int x;

    cout << "Podaj liczbe: ";
    cin >> x;
    cout << get_day(x) << endl;
}
