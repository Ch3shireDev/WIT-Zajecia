//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cmath> // Ten wiersz jest bardzo ważny

using namespace std;

int main()

{
    double const liczba(16); // Hartosé; dla ktérej bedzie obliczany pierwiastek kwadrat
    // Ponieważ wartosć ta nie bedzie sie zmieniać, definiujemy ją jako stałą
    double wynik;         // Miejsce w pamieci na zapisanie wyniku
    wynik = sqrt(liczba); // wykonanie obliczeń
    cout << "Pierwiastek kwadratowy z " << liczba << " wynosi " << wynik << endl;
    return 0;
}