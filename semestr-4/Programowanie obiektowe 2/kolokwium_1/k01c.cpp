// Zadanie K01C
// Napisz funkcję function, która z danej mapy usuwa pary o wartości nie
// mniejszej od zadanej liczby. Funkcja powinna być przystosowana do użycia w
// przykładowym programie poniżej. // Funkcja korzysta tylko z pliku
// nagłówkowego map. Przykładowy program

// int main() {
//     std::map<int, int> map {{7, 1}, {3, 8}, {5, 7}, {1, 4}, {4, 5}, {8, 3}};
//     function(map, 5);
//     for (auto pair: map) {
//         std::cout << pair.first << " " << pair.second << std::endl; }}

// Wykonanie

// Out: 1 4
// Out: 7 1
// Out: 8 3

#include <iostream>
#include <map>
#include "k01c.hpp"

int main() {
  std::map<int, int> map{{7, 1}, {3, 8}, {5, 7}, {1, 4}, {4, 5}, {8, 3}};
  function(map, 5);
  for (auto pair : map) {
    std::cout << pair.first << " " << pair.second << std::endl;
  }
}