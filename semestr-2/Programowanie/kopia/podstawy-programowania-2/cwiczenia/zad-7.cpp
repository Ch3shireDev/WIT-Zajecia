//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{

    //Zad 7. Rozbuduj program BMI z zadania 6 aby była możliwość wyboru liczenia w jednostkach kg, m (europejskich) lub (angielskich).

    double mass, height;

    cout << "Wybierz jednostki:" << endl;
    cout << "1. Metryczne (kg, m)" << endl;
    cout << "2. Imperialne (funty, stopy)" << endl;
    int type;
    cin >> type;

    if (type == 1)
        cout << "Podaj masę ciała (w kg): ";
    else
    {

        cout << "Podaj masę ciała (w funtach): ";
    }
    cin >> mass;
    if (type == 1)
    {
        cout << "Podaj wzrost (w metrach): ";
    }
    else
    {

        cout << "Podaj wzrost (w stopach): ";
    }
    cin >> height;

    if (type == 2)
    {
        mass /= 2.2046;
        height /= 3.2808;
    }

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