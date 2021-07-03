#include <iostream>
using namespace std;

// 4.2.17 Set: Zbiór znaków - bitcoin
// Napisz klase Set reprezentujaca zbiór znaków typu char. Zaimplementuj:
class Set {
    char* array = nullptr;
    int current_size = 0;
public:
    //  Stała bezargumentowa metode size zwracajaca liczbe elementów zbioru.
    int size() const{
        return current_size;
    }

    //  Stała metode contains, która przyjmuje znak i zwraca prawde jesli nalezy on do zbioru albo fałsz
    // w przeciwnym razie.

    bool contains(char character) const {
        for (int i = 0;i < current_size;i++) {
            if (array[i] == character)return true;
        }
        return false;
    }

    //  Metode insert, która przyjmuje znak, dodaje go do zbioru i zwraca modyfikujaca referencje obiektu, na rzecz którego została wywołana.

    Set& insert(char character) {
        if (!contains(character)) {
            char* new_array = new char[current_size + 1];
            for (int i = 0;i < current_size;i++) {
                new_array[i] = array[i];
            }
            if (current_size > 0) { delete[] array; }
            new_array[current_size] = character;
            array = new_array;
            current_size += 1;
        }
        return *this;
    }


    //  Metode remove, która przyjmuje znak, usuwa go ze zbioru i zwraca modyfikujaca referencje obiektu, na rzecz którego została wywołana.

    Set& remove(char character) {

        bool is_in = contains(character);

        if (is_in && current_size == 1) {
            delete[] array;
            array = nullptr;
            current_size = 0;
            return *this;
        }

        if (is_in) {
            char* new_array = new char[current_size - 1];
            int index = 0;
            for (int i = 0;i < current_size;i++)
                if (array[i] == character)index = i;

            for (int i = 0;i < current_size;i++) {
                if (i == index)continue;
                if (i < index)new_array[i] = array[i];
                else new_array[i - 1] = array[i];
            }

            array = new_array;
            current_size -= 1;
        }
        return *this;
    }


    // Nowoutworzony zbiór jest pusty. Klasa powinna byc przystosowana do uzycia w przykładowym programie ponizej. Klasa nie korzysta z zadnych plików nagłówkowych.
};

int main() {
    Set set = Set().insert('a')
    .insert('b')
    .insert('b')
    .remove('b').remove('c');
    std::cout << set.size() << std::endl << std::boolalpha;
    std::cout << set.contains('a') << " " << set.contains('b') << " "
        << set.contains('c') << " " << set.contains('d') << std::endl;
}
// Wykonanie
// Out: 1
// Out: true false false false