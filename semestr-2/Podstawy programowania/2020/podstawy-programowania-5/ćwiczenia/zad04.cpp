

// Zadanie 4
// Napisać funkcję sklej, której parametrami są dwa wskaźniki na tekst s i t. Funkcja ma dopisać do tekstu znajdującego się w tablicy s tekst t. Funkcja ma operować na wskaźnikach do tekstu, a nie na tablicach i indeksowaniu. Funkcja nie może utworzyć trzeciego tekstu - ma dokleić drugi do pierwszego. Uwaga, tablica zawierająca tekst pierwszy musi być wystarczająco duża, by pomieściła dodatkowo znaki tekstu drugiego.
#include <iostream>
using namespace std;

void sklej(string *base, string *add)
{
    (*base) += *add;
}

int main()
{

    string a = "abc";
    string b = "cde";

    cout << "Tekst 1: " << a << endl;
    cout << "Tekst 2: " << b << endl;

    sklej(&a, &b);

    cout << "Tekst 1: " << a << endl;

    return 0;
}