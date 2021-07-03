// Napisz funkcje insert, która przyjmuje napis, indeks znaku w tym napisie, oraz drugi napis i wstawia
// drugi napis do pierwszego poczawszy od podanego indeksu. Funkcja przesuwa pózniejsze znaki pierwszego
// napisu odpowiednio w prawo realokujac pamiec. Funkcja zwraca wskaznik poczatkowy wynikowego
// napisu. Funkcja powinna byc przystosowana do uzycia w przykładowym programie ponizej. Funkcja korzysta
// tylko z pliku nagłówkowego cstdlib.
// Przykładowy program

// Wykonanie
// Out: dictionary

#include <iostream>
using namespace std;

int length(const char* str) {
    int n = 0;
    while (str[n] != '\0')n++;
    return n;
}
char* insert(char* str, int pos, const char* add_str) {
    int m = length(add_str);
    int n = length(str) + m;
    char* new_str = new char[n];
    for (int i = 0;i < n+1;i++) {
        if (i < pos)new_str[i] = str[i];
        else if (i < pos + m)new_str[i] = add_str[i - pos];
        else new_str[i] = str[i - m];
    }
    return new_str;
}


int main() {
    char* string = (char*)std::calloc(1, sizeof(char));
    string = insert(string, 0, "diary");
    string = insert(string, 2, "ction");
    std::cout << string << std::endl;
    std::free(string);
    {
        char* string = (char*)std::calloc(1, sizeof(char));
        string = insert(string, 0, "litwo moja ty jestes jak zdrowie ile cie trzeba cenic ten tylko sie dowie kto cie stracil dzis pieknosc twa w calej ozdobie widze i opisuje bo tesknie po tobie");
        string = insert(string, 6, "ojczyzno ");
        cout << string << endl;
    }
}