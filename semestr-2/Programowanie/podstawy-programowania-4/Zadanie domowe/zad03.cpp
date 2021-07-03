// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
#include <time.h>
using namespace std;

int main()
{
    time_t t = time(NULL);
    tm *tPtr = localtime(&t);

    string name;
    int age;
    bool this_year;
    cout << "Podaj swoje imię: ";
    cin >> name;
    cout << "Podaj swój wiek: ";
    cin >> age;
    cout << "Czy Twoje urodziny były już w tym roku? (0 - nie, 1 - tak): ";
    cin >> this_year;

    int curr_year = (tPtr->tm_year) + 1900;

    int year = curr_year - age;
    if (!this_year)
    {
        year -= 1;
    }

    cout << "Twoje imię to " << name << ", a rok Twoich urodzin to " << year << "." << endl;
}