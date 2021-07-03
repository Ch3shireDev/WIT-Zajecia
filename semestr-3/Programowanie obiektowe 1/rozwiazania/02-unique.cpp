// ## 1.2.22 Unique: Usuwanie powtórzen - bitcoin

// Napisz funkcje unique, która przyjmuje modyfikujacy wskaznik poczatkowy i koncowy wycinka tablicy
// liczb całkowitych i wszystkie elementy rózne od swoich poprzedników przepisuje na kolejne pozycje wycinka
// poczynajac od poczatku. Funkcja zwraca modyfikujacy wskaznik koncowy wycinka powstałego
// z przepisanych elementów. Funkcja powinna byc przystosowana do uzycia w przykładowym programie
// ponizej. Funkcja nie korzysta z zadnych plików nagłówkowych.

// ### Przykładowy program

// ```
// ```
// ### Wykonanie
// Out: -7 5 2 11 2 3

#include <iostream>

// Funkcja jest dość zwarta, ale jej założenia są dość proste - tak długo jak bieżąca liczba jest inna niż poprzednia, przepisujemy ją na miejsce w tej samej tablicy
// na indeksie j (i zwiększamy j). Po całej akcji zwracamy a+j jako wskaźnik miejsca za ostatnim nowej tablicy.
int* unique(int* a, int* b) {
    int j = 0, i = 0;
    while (a+i != b) {
        if (j == 0 || a[i-1] != a[i]) {
            a[j++] = a[i];
        }
        i++;
    }
    return a+j;
}

int main() {
    int table[] = { -7, 5, 2, 2, 11, 2, 3, 3 };
    int* result = unique(table, table + 8);
    for (const int* pointer = table; pointer < result;) {
        std::cout << *pointer++ << " ";
    }
    std::cout << std::endl;
}
