
#include <cmath>

// 4.2.19 Turtle: Grafika zółwia - bitcoin
// Logo to jezyk programowania dla dzieci słuzacy do sporzadzania rysunków. Kresli sie je przy pomocy
// zółwia, który przemieszcza sie po ekranie i pozostawia za soba linie. Mozna mu wydac polecenie przesuniecia
// sie do przodu o dana liczbe punktów lub skrecenia o dany kat. Napisz klase Turtle reprezentujaca
// zółwia. Zaimplementuj:

#define _USE_MATH_DEFINES

class Turtle {

    double x_pos = 0;
    double y_pos = 0;
    double current_angle = 0;

public:

    //  Stałe bezargumentowe metody x oraz y zwracajace odpowiednie współrzedne zółwia.

    double x() const {
        return x_pos;
    }

    double y() const {
        return y_pos;
    }

    Turtle() {}

    //  Metode go, która przyjmuje rzeczywista liczbe punktów, przemieszcza zółwia o te liczbe punktów do przodu i zwraca referencje biezacego obiektu.
    Turtle& go(double value) {
        x_pos += cos(current_angle/360.*2*M_PI) * value;
        y_pos += sin(current_angle/360.*2*M_PI) * value;
        return *this;
    }

    //  Metode turn, która przyjmuje rzeczywisty kat w stopniach, obraca zółwia o ten kat w lewo i zwraca referencje biezacego obiektu. Ujemny kat odpowiada obrotowi w prawo.
    Turtle& turn(double angle) {
        current_angle += angle;
        while (current_angle > 360)current_angle -= 360;
        while (current_angle < 0)current_angle += 360;
        return *this;
    }

    // Nowoutworzony zółw znajduje sie w poczatku układu współrzednych i jest skierowany w prawo. Klasa powinna byc przystosowana do uzycia w przykładowym programie ponizej. Klasa korzysta tylko z pliku
    // nagłówkowego cmath.
};

#include <iostream>
using namespace std;

int main() {
    Turtle turtle;
    turtle.turn(30.).go(100.);
    std::cout << turtle.x() << " " << turtle.y() << std::endl;
}

// Wykonanie
// Out: 86.6025 50
