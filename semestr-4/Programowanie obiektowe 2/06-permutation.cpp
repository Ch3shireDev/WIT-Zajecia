#include <cstdlib>
#include <ctime>
#include <algorithm>
#include <iostream>
#include <numeric>
#include <vector>

// Permutation: Losowa permutacja - grupowo

// Napisz program permutation, który wczytuje ze standardowego wejścia nieujemną liczbę całkowitą i wypisuje na standardowe wyjście losową permutację mniejszych od niej nieujemnych liczb całkowitych. Program zawiera po jednym wywołaniu funkcji std::iota oraz std::random_shuffle i nie używa innych algorytmów biblioteki standardowej. Program załącza tylko pliki nagłówkowe cstdlib, ctime, algorithm,
// iostream, numeric i vector.
// Przykładowe wykonanie
// In: 5
// Out: 2 0 4 1 3

typedef std::vector<int> Vec;

int main()
{
    srand(time(0));

    int x;
    std::cin >> x;

    // Jeśli wczytana wartość jest mniejsza od 1, to nie uzyskamy żadnego wektora z liczbami.
    if (x < 1)
        return 0;

    Vec vec = Vec(x);
    std::iota(vec.begin(), vec.end(), 0);
    std::random_shuffle(vec.begin(), vec.end());

    for (int i = 0; i < vec.size(); i++)
    {
        std::cout << vec[i] << " ";
    }
}