// Igor Nowicki
// 18608

// b) Napisz program w c++ na zastosowanie kolejki mające zastosowanie w praktyce
#include <iostream>
#include <string>
#include <queue>

using namespace std;

int main()
{

    //tutaj będę zwyczajnie przechowywał liczby by wypisac je w tej samej kolejności
    queue<int> kolejka = queue<int>();
    int x;

    //pobieram liczby od użytkownika
    cout << "Wprowadź liczby: " << endl;
    while (cin >> x)
    {
        kolejka.push(x);
    }

    //dopóki kolejka nie będzie opróżniona wypisuję kolejne liczby
    cout << "Wprowadzone liczby:" << endl;
    while (!kolejka.empty())
    {
        cout << kolejka.front() << endl;
        kolejka.pop();
    }
}