

class Bottle {
    double max_amount;
    double current_amount = 0;
public:
    // 4.2.3 Bottle: Butelka o ograniczonej pojemnosci - bitcoin
    // Napisz klase Bottle reprezentujaca butelke. Zaimplementuj:

    //  Konstruktor przyjmujacy pojemnosc butelki.

    Bottle(double amount) {
        max_amount = amount;
    }

    //  Stała bezargumentowa metode volume, która zwraca objetosc płynu w butelce.

    double volume() const{
        return current_amount;
    }

    //  Metode fill, która przyjmuje objetosc płynu, jaki chcemy wlac do butelki, zmienia odpowiednio objetosc płynu w butelce i zwraca objetosc płynu, który rzeczywiscie udało sie wlac.

    double fill(double amount) {
        if (current_amount + amount <= max_amount) {
            current_amount += amount;
            return amount;
        }
        amount = max_amount - current_amount;
        current_amount = max_amount;
        return amount;
    }

    //  Metode pour, która przyjmuje objetosc płynu, jaki chcemy wylac z butelki, zmienia odpowiednio objetosc płynu w butelce i zwraca objetosc płynu, który rzeczywiscie udało sie wylac.

    double pour(double amount) {
        if(amount <= current_amount){
            current_amount -= amount;
            return amount;
        }
        amount = current_amount;
        current_amount = 0;
        return amount;
    }

    // Nowoutworzona butelka jest pusta. Klasa powinna byc przystosowana do uzycia w przykładowym programie
    // ponizej. Klasa nie korzysta z zadnych plików nagłówkowych.

};

#include <iostream>
using namespace std;

// Przykładowy program

int main() {
const    Bottle bottle(4.5);
    std::cout << bottle.volume() << "\n";
    std::cout << bottle.fill(3.5) << "\n";
    std::cout << bottle.volume() << "\n";
    cout<<"Dolewamy 5 litrow"<<endl;
    std::cout << bottle.fill(5) << "\n";
    std::cout << bottle.volume() << "\n";
    std::cout << bottle.pour(5.5) << "\n";
    std::cout << bottle.volume() << std::endl;

    double volume = bottle.volume();
}
// Wykonanie
// Out: 0 3.5 3.5 3.5 0
