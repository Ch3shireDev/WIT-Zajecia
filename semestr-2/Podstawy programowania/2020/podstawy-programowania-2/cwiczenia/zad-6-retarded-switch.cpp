//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{

    //Zad 6. Napisz program obliczający BMI i wyświetlający komunikat o wielkości BMI jak i informacje o stopniu otyłości, nawagi, wadze prawidłowej, niedowadze, itd. ... (napisz go w dwóch wariantach tylko z if i z zastosowaniem case).

    double mass, height;

    cout << "Podaj masę ciała: ";
    cin >> mass;
    cout << "Podaj wzrost: ";
    cin >> height;

    int bmi = mass / height / height;

    switch (bmi)
    {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
    case 12:
    case 13:
    case 14:
    case 15:
        cout << "Osoba wygłodzona" << endl;
        return 0;
    case 16:
        cout << "Osoba wychodzona" << endl;
        return 0;
    case 17:
    case 18:
        cout << "Osoba z niedowagą" << endl;
        return 0;
    case 19:
    case 20:
    case 21:
    case 22:
    case 23:
    case 24:
    case 25:
        cout << "Osoba zdrowa" << endl;
        return 0;
    case 26:
    case 27:
    case 28:
    case 29:
        cout << "Osoba z nadwagą" << endl;
        return 0;
    case 30:
    case 31:
    case 32:
    case 33:
    case 34:
        cout << "Osoba z otyłością pierwszego stopnia" << endl;
        return 0;
    case 35:
    case 36:
    case 37:
    case 38:
    case 39:
        cout << "Osoba z otyłością drugiego stopnia" << endl;
        return 0;
    case 40:
    case 41:
    case 42:
    case 43:
    case 44:
        cout << "Osoba z otyłością trzeciego stopnia" << endl;
        return 0;
    default:

        cout << "Osoba śmiertelnie otyła" << endl;
        return 0;
    }
}