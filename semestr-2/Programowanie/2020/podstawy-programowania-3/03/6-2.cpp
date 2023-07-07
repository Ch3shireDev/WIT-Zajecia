//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int get_days(int month)
{
    //robimy operację switch dla kolejnych numerów miesiąca
    switch (month)
    {
    case (1):
    case (3):
    case (5):
    case (7):
    case (8):
    case (10):
    case (12):
        //styczeń, marzec, maj, lipiec, sierpień, październik, grudzień mają 31 dni
        return 31;
    case (4):
    case (6):
    case (9):
    case (11):
        //kwiecień, czerwiec, wrzesień, listopad mają 30 dni
        return 30;
    case (2):
        //luty jest dość dziki, dla podzielnych przez 4 jest 29 dni,
        //chyba że jest podzielny przez 100 to 28,
        //chyba że podzielny przez 400 to 29.
        cout << "Podaj rok: ";
        int year;
        cin >> year;
        if (year % 4 != 0)
        {
            return 28;
        }
        else if (year % 100 != 0)
        {
            return 29;
        }
        else if (year % 400 != 0)
        {
            return 28;
        }
        else
        {
            return 29;
        }
    }
    cout << "Nieprawidłowy miesiąc!" << endl;
    return 0;
}

int main()
{
    // stwórz program który pobiera numer miesiąca i wyświetla liczbę jego dni.
    // W przypadku lutego pobiera dodatkowo rok.
    int month;
    cout << "Podaj numer miesiąca: ";
    cin >> month;

    //liczbę dni zamykamy w funkcji
    int n = get_days(month);
    cout << "Liczba dni: " << n << endl;
}