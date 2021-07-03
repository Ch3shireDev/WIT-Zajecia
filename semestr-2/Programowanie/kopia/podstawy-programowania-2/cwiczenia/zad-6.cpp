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

    double bmi = mass / height / height;

    if (bmi < 16)
    {
        cout << "Osoba wygłodzona" << endl;
    }
    else if (bmi < 16.9)
    {
        cout << "Osoba wychodzona" << endl;
    }

    else if (bmi < 18.5)
    {
        cout << "Osoba z niedowagą" << endl;
    }

    else if (bmi < 24.9)
    {
        cout << "Osoba zdrowa" << endl;
    }

    else if (bmi < 29.9)
    {
        cout << "Osoba z nadwagą" << endl;
    }

    else if (bmi < 34.9)
    {
        cout << "Osoba z otyłością pierwszego stopnia" << endl;
    }
    else if (bmi < 39.9)
    {
        cout << "Osoba z otyłością drugiego stopnia" << endl;
    }
    else if (bmi < 44.9)
    {
        cout << "Osoba z otyłością trzeciego stopnia" << endl;
    }
    else
    {
        cout << "Osoba śmiertelnie otyła" << endl;
    }
}