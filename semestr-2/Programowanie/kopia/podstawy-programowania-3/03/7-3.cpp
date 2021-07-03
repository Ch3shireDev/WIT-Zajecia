//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    // stwórz program który pobiera quizy z pliku tekstowego. Quiz składa się z pytania, czterech odpowiedzi i nazwie poprawnej odpowiedzi. Może być dowolna liczba pytań.

    fstream file;
    file.open("quiz.txt");

    while (!file.eof())
    {
        string pytanie;
        string a, b, c, d;
        string odpowiedz;

        getline(file, pytanie);
        getline(file, a);
        getline(file, b);
        getline(file, c);
        getline(file, d);
        getline(file, odpowiedz);

        cout << pytanie << endl;
        cout << "a) " << a << endl;
        cout << "b) " << b << endl;
        cout << "c) " << c << endl;
        cout << "d) " << d << endl;
        cout << "Odpowiedź: ";
        char answer;
        cin >> answer;
        if (answer == odpowiedz[0])
        {
            cout << "Poprawna odpowiedź!" << endl;
        }
        else
        {
            cout << "Zła odpowiedź. Poprawna odpowiedź to: " << odpowiedz[0] << endl;
        }
    }
}