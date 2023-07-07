//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    // - stwórz program który odczytuje dane wizytówki i wypisuje je na ekran
    ifstream file;
    file.open("wizytowka.txt");
    string firstName, lastName, phone;

    // odczytujemy dane przez fstream
    file >> firstName >> lastName >> phone;

    cout << firstName << endl;
    cout << lastName << endl;
    cout << phone << endl;
}