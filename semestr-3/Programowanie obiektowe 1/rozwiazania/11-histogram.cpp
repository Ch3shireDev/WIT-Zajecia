// #include <cstdlib>
// #include <cstring>

//Klasa korzysta tylko z plików nagłówkowych cstdlib i cstring;

// 6.2.5 Histogram: Histogram - bitcoin
// Napisz klase Histogram reprezentujaca jednowymiarowy histogram o binach jednakowej szerokosci. Zaimplementuj:

class Histogram {
    int bins;
    double left;
    double right;
    int* tab;
public:
    // - Konstruktor bezargumentowy tworzacy histogram o zerowej liczbie binów, 
    Histogram() {
        bins = 0;
        tab = nullptr;
    }

    // konstruktor kopiujacy, 
    Histogram(const Histogram& histogram) {
        bins = histogram.bins;
        left = histogram.left;
        right = histogram.right;
        tab = new int[bins];
        for (int i = 0;i < bins;i++) {
            tab[i] = histogram.tab[i];
        }
    }

    //a takze konstruktor przyjmujacy krance przedziału histogramowania oraz liczbe binów i zerujacy wszystkie biny.

    Histogram(double a, double b, int n) {
        left = a;
        right = b;
        bins = n;
        tab = new int[n];
        for (int i = 0;i < bins;i++) {
            tab[i] = 0;
        }
    }

    // - Destruktor zwalniajacy pamiec i zerujacy liczbe binów.
    ~Histogram() {
        bins = 0;
        delete[] tab;
        tab = nullptr;
    }

    // - Operator =, po którego lewej i prawej stronie stoi odpowiednio zwykła i stała referencja histogramu, a wynikiem jest referencja histogramu po lewej. Operator tworzy w nim głeboka kopie histogramu po prawej.

    Histogram& operator=(const Histogram& histogram) {
        left = histogram.left;
        right = histogram.right;
        bins = histogram.bins;
        delete[] tab;
        tab = new int[bins];
        for (int i = 0;i < bins;i++) {
            tab[i] = histogram.tab[i];
        }
        return *this;
    }

    // - Stały operator [], który przyjmuje indeks binu i zwraca liczbe zliczen w tym binie. Biny sa indeksowane od zera.

    int operator[](const int index) const {
        if (index < 0 || index >= bins)return 0;
        return tab[index];
    }

    // - Stała bezargumentowa metode size zwracajaca liczbe binów.

    int size() const {
        return bins;
    }

    // - Metode insert, która przyjmuje liczbe rzeczywista i zwieksza o jeden liczbe zliczen w binie, w którym wypada ta liczba. Jezeli liczba lezy poza przedziałem histogramowania, histogram pozostaje bez zmian. 

    Histogram& insert(double value) {
        if (value<left || value>right)return *this;
        int index = (value-left)/(right-left)*bins;
        if (index < 0 || index >= bins)return *this;
        tab[index]++;
        return *this;
    }

    // Metoda zwraca referencje obiektu, na którym została wywołana.


};

// Klasa powinna byc przystosowana do uzycia w przykładowym programie ponizej. Klasa korzysta tylko z plików nagłówkowych cstdlib i cstring;

#include <iostream>
using namespace std;

// Przykładowy program
std::ostream& operator <<(std::ostream& stream, const Histogram& histogram) {
    for (int index = 0; index < histogram.size();) {
        stream << histogram[index++] << " ";
    }
    return stream;
}
int main() {
    Histogram histogram1(0., 1., 2), histogram2;
    histogram1.insert(0.17);
    (histogram2 = histogram1).insert(0.75);
    const Histogram histogram3 = Histogram(histogram2).insert(0.33);
    std::cout << histogram1 << std::endl
        << histogram2 << std::endl
        << histogram3 << std::endl;
}
// Wykonanie
// Out: 1 0
// Out: 1 1
// Out: 2 1