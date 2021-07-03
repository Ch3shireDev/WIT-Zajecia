// 5.2.1 Add: Łaczenie wektorów - bitcoin


#include <vector>

typedef std::vector<double> Vec;
typedef std::vector<double>::iterator It;

// Zaimplementuj:
// Operator +, po którego obu stronach stoja niemodyfikujace referencje wektorów liczb rzeczywistych, zas wynikiem jest nowy wektor zawierajacy wszystkie elementy wektora po lewej, a po nich wszystkie elementy wektora po prawej.
Vec operator+(const Vec& x, const Vec& y) {
    Vec z = Vec( x.size() + y.size());
    for (int i = 0;i < x.size() + y.size();i++) {
        if (i < x.size())z[i] = x[i];
        else z[i] = y[i - x.size()];
    }
    return z;
}

// Operator +=, po którego lewej i prawej stronie stoi odpowiednio modyfikujaca i niemodyfikujaca referencja wektora liczb rzeczywistych, a wynikiem jest modyfikujaca referencja wektora po lewej.
// Operator dopisuje na jego koniec wszystkie elementy wektora po prawej.

Vec& operator+=(Vec& x, const Vec& y) {
    x = x + y;
    return x;
}

// Operatory powinny byc przystosowane do uzycia w przykładowym programie ponizej. Operatory korzystaja tylko z pliku nagłówkowego vector.

// Przykładowy program
#include <iostream>

int main() {
    std::vector<double> vector = std::vector<double>{ 6.7, -12.3 }
    + std::vector<double> {-2.7, 19};
    (vector += std::vector<double> {0.5, -2.7}) += std::vector<double> {19};
    for (double element : vector) {
        std::cout << element << " ";
    }
    std::cout << std::endl;
}
// Wykonanie
// Out: 6.7 -12.3 -2.7 19 0.5 -2.7 19