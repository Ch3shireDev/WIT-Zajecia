#include <iostream>
using namespace std;
int main()
{
    int month, day;
    cout << "Podaj miesiąc: ";
    cin >> month;
    cout << "Podaj dzień: ";
    cin >> day;

    if (month == 1 && day == 1)
        cout << "Nowy rok" << endl;
    else if (month == 1 && day == 6)
        cout << "Trzech Króli" << endl;
    else if (month == 5 && day == 1)
        cout << "Święto Pracy" << endl;
    else if (month == 5 && day == 3)
        cout << "Święto Konstytucji 3 Maja" << endl;
    else if (month == 8 && day == 15)
        cout << "Święto Wojska Polskiego" << endl;
    else if (month == 11 && day == 1)
        cout << "Wszystkich Świętych" << endl;
    else if (month == 11 && day == 11)
        cout << "Święto Niepodległości" << endl;
    else if (month == 12 && day == 25)
        cout << "Boże Narodzenie" << endl;
    else if (month == 12 && day == 26)
        cout << "Boże Narodzenie" << endl;
    else
    {
        cout << "Ordinary day" << endl;
    }
}