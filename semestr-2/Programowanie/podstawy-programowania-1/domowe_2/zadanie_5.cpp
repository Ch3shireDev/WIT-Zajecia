//Igor Nowicki
//IZ02P03
//18608
#include <iostream>

using namespace std;

bool leapYear(int year)
{
    if (year % 4 != 0)
        return false;
    if (year % 100 != 0)
        return true;
    if (year % 400 == 0)
        return true;
    return false;
}

int main()
{
    int year;
    cout << "Podaj biezacy rok: ";
    cin >> year;
    if (leapYear(year))
    {
        cout << "Rok " << year << " jest przestepny" << endl;
    }
    else
    {
        cout << "Rok " << year << " nie jest przestepny" << endl;
    }
}