// 5.2.7 Geometric: Ciag geometryczny - bitcoin
// n-ty wyraz ciagu geometrycznego o wyrazie poczatkowym a0 oraz ilorazie q jest równy an = a0qn. 

// Napisz klase Geometric reprezentujaca ciag geometryczny o zadanych parametrach a0 i q. Klasa korzysta tylko z pliku nagłówkowego cmath.

#include <cmath>

class Geometric {
    double a0;
    double q;
public:

    //Zaimplementuj:
    // Konstruktor przyjmujacy a0 i q.
    Geometric(double a0, double q) :a0(a0), q(q) {}

    // Stały operator [], który przyjmuje n i zwraca an.
    double operator[](int n) const {
        return a0 * pow(q, n);
    }


};

// Klasa powinna byc przystosowana do uzycia w przykładowym programie ponizej. 
// Przykładowy program
#include <iostream>

int main() {
    const Geometric geometric(1., 0.5);
    std::cout << geometric[2] << std::endl;
}
//Wykonanie
// Out: 0.25