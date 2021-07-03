// ## 2.2.2 Eratostenes: Sito Eratostenesa - bitcoin
// Wszystkie liczby pierwsze mniejsze od dodatniej liczby całkowitej n mozna wyznaczyc nastepujaca metoda
// zwana sitem Eratostenesa. Sposród liczb wiekszych od 1 i mniejszych od n wykreslamy wszystkie
// wielokrotnosci 2 poczynajac od 4, nastepnie wszystkie wielokrotnosci 3 poczynajac od 6 i tak dalej.
// Pozostałe na koniec niewykreslone liczby to wszystkie liczby pierwsze mniejsze od n. Napisz program
// eratostenes, który przyjmuje jako argument wywołania dodatnia liczbe całkowita i wypisuje na standardowe
// wyjscie wszystkie mniejsze od niej liczby pierwsze w kolejnosci rosnacej. Program załacza tylko
// pliki nagłówkowe cstdlib i iostream.

// ### Przykładowe wykonanie
// ```
// Linux: ./eratostenes 100
// Windows: eratostenes.exe 100
// Out: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97
// ```

#include<cstdlib>
#include<iostream>

int main(int argc, char** argv) {
    int n = atoi(argv[1]);
    if (n < 2)return 0;
    bool* tab = new bool[n] {false, false};

    for (int i = 2;i < n;i++) {
        tab[i] = true;
    }

    int i = 2;

    while (i < n) {
        std::cout << i << " ";

        // Kasujemy wszystkie wielokrotności i.
        for (int j = 2 * i;j < n;j += i) {
            tab[j] = false;
        }

        // Szukamy następnej pozycji na której tab[i] jest true
        i++;
        while (i < n && !tab[i])i++;

    }
    delete[] tab;
}