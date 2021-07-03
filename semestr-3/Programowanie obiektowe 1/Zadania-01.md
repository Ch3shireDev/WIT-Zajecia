# Zadania domowe - 1 zajęcia

## 1.2.10 Letters: Zliczanie liter - bitcoin

Napisz program letters, który czyta ze standardowego wejscia znaki do napotkania konca pliku, a
nastepnie wypisuje na standardowe wyjscie liczby wystapien kolejnych liter posród wpisanych znaków.
Program nie rozróznia wielkich i małych liter oraz pomija wszelkie inne znaki. Program załacza tylko
pliki nagłówkowe cctype i iostream.

### Przykładowe wykonanie
```
In: Lorem ipsum dolor sit amet!
Out: 1 0 0 1 2 0 0 0 2 0 0 2 3 0 3 1 0 2 2 2 1 0 0 0 0 0
```


## 1.2.22 Unique: Usuwanie powtórzen - bitcoin

Napisz funkcje unique, która przyjmuje modyfikujacy wskaznik poczatkowy i koncowy wycinka tablicy
liczb całkowitych i wszystkie elementy rózne od swoich poprzedników przepisuje na kolejne pozycje wycinka
poczynajac od poczatku. Funkcja zwraca modyfikujacy wskaznik koncowy wycinka powstałego
z przepisanych elementów. Funkcja powinna byc przystosowana do uzycia w przykładowym programie
ponizej. Funkcja nie korzysta z zadnych plików nagłówkowych.

### Przykładowy program

```
int main() {
int table[] = {-7, 5, 2, 2, 11, 2, 3, 3};
int *result = unique(table, table + 8);
for (const int *pointer = table; pointer < result;) {
std::cout << *pointer++ << " "; }
std::cout << std::endl; }
```
### Wykonanie
Out: -7 5 2 11 2 3

## 2.2.2 Eratostenes: Sito Eratostenesa - bitcoin
Wszystkie liczby pierwsze mniejsze od dodatniej liczby całkowitej n mozna wyznaczyc nastepujaca metoda
zwana sitem Eratostenesa. Sposród liczb wiekszych od 1 i mniejszych od n wykreslamy wszystkie
wielokrotnosci 2 poczynajac od 4, nastepnie wszystkie wielokrotnosci 3 poczynajac od 6 i tak dalej.
Pozostałe na koniec niewykreslone liczby to wszystkie liczby pierwsze mniejsze od n. Napisz program
eratostenes, który przyjmuje jako argument wywołania dodatnia liczbe całkowita i wypisuje na standardowe
wyjscie wszystkie mniejsze od niej liczby pierwsze w kolejnosci rosnacej. Program załacza tylko
pliki nagłówkowe cstdlib i iostream.

### Przykładowe wykonanie
```
Linux: ./eratostenes 100
Windows: eratostenes.exe 100
Out: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97
```