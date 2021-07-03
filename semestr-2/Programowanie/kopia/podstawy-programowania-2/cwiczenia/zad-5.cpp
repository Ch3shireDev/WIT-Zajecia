//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

int main()
{
    //Zad 5. Napisz program sprawdzający czy użytkownik wprowadził prawidłowo Imię, Nazwisko, Hasło jeśli tak to przyznaje mu dostęp, jeśli nie to prosi ponownie o podanie ponownie danych.
    //Poprawnie dane: Jan, Kowalski, kowal37
    string firstName, lastName, pass;
    cout << "Podaj imię: ";
    cin >> firstName;
    cout << "Podaj nazwisko: ";
    cin >> lastName;
    cout << "Podaj hasło: ";
    cin >> pass;

    if (firstName != "Jan" || lastName != "Kowalski" || pass != "kowal37")
    {
        cout << "Nieprawidłowe dane!" << endl;
        return 0;
    }

    cout << "Udzielono dostępu" << endl;
}