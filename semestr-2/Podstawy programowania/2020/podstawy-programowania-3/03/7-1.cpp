//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    // ## Część 7

    // - stwórz program który pobiera imię, nazwisko numer telefonu i zapisuje do pliku

    string firstName, lastName, phoneNumber;
    cout << "Podaj imię: ";
    cin >> firstName;
    cout << "Podaj nazwisko: ";
    cin >> lastName;
    cout << "Podaj numer telefonu: ";
    cin >> phoneNumber;

    //tworzymy strumień wyjściowy plików i zapisujemy zebrane dane
    ofstream file;
    file.open("wizytowka.txt");
    file << firstName << endl;
    file << lastName << endl;
    file << phoneNumber << endl;
    file.close();
}