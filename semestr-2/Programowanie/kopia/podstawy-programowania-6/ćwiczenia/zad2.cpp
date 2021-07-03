// Igor Nowicki
// 18608

#include <iostream>
using namespace std;
// Zadanie 2

// Napisz program w którym utworzysz strukturę przechowującą następujące dane:
// Imię
// Nazwisko
// Adres
// Kod
// Miasto
// Wiek
// Płeć
// Numer_telefonu
// Adres_e-mail
// Program powinien pozwolić użytkownikowi wprowadzić dane do struktury, a następnie wyświetlić te dane.

class Person
{
    string firstName;
    string lastName;
    string address;
    string zipCode;
    string city;
    int age;
    string gender;
    string phoneNumber;
    string mailAddress;

public:
    Person() {}

    void get_input()
    {
        cout << "Imię: ";
        cin >> firstName;
        cout << "Nazwisko: ";
        cin >> lastName;
        cout << "Adres: ";
        cin >> address;
        cout << "Kod pocztowy: ";
        cin >> zipCode;
        cout << "Miasto: ";
        cin >> city;
        cout << "Wiek: ";
        cin >> age;
        cout << "Płeć: ";
        cin >> gender;
        cout << "Numer telefonu: ";
        cin >> phoneNumber;
        cout << "Adres mailowy: ";
        cin >> mailAddress;
    }

    void show_info()
    {
        cout << "Imię: " << firstName << endl;
        cout << "Nazwisko: " << lastName << endl;
        cout << "Adres: " << address << endl;
        cout << "Kod pocztowy: " << zipCode << endl;
        cout << "Miasto: " << city << endl;
        cout << "Wiek: " << age << endl;
        cout << "Płeć: " << gender << endl;
        cout << "Numer telefonu: " << phoneNumber << endl;
        cout << "Adres mailowy: " << mailAddress << endl;
    }
};

int main()
{
    Person person;
    person.get_input();
    person.show_info();
}