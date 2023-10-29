// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int year;
    cout << "Podaj rok: ";
    cin >> year;

    bool is_leap_year = true;

    if (year % 4 != 0)
    {
        is_leap_year = false;
    }
    else if (year % 100 != 0)
    {
        is_leap_year = true;
    }
    else if (year % 400 == 0)
    {
        is_leap_year = true;
    }
    else
    {
        is_leap_year = false;
    }

    cout << "Rok " << year << " " << (is_leap_year ? "" : "nie ") << "jest rokiem przestępnym." << endl;
}