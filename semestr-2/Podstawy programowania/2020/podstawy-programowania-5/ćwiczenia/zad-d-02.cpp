// Zadanie dodatkowe 2
// Napisz kod/program który będzie odgadywał liczbę całkowitą jaką mam na myśli i zrobi to w przy
// możliwie jak najmiejszej liczbie pytań. (Dla uproszczenia na początek można założyć zakres od
// -32000 do 32000)
// Ja mogę odpowiadać programowi tylko wciskając literę "t" lub "n" na wyświetlane pyania.
// Na końcu program ma wyswietlić liczbę o której pomyślałem i ilość pytań kóre zadał.

#include <iostream>
using namespace std;

int main()
{

    cout << "Gra w zgadywanie liczb z zakresu -32000-32000. Użytkownik wymyśla liczbę, program próbuje ją zgadnąć minimalnym zestawem pytań." << endl;
    int a = -32000;
    int b = 32000;
    int counter = 0;
    while (a != b)
    {
        counter++;
        int n = (a + b) / 2;
        cout<<"Czy ta liczba jest większa od "<<n<<"? (t jeśli tak, n jeśli nie): ";
        char answer;
        cin >> answer;
        switch (answer)
        {
        case 't':
            a = n+1;
            break;
        case 'n':
            b = n;
            break;
        }
    }

    cout << "Ta liczba to musi być " << a << endl;
    cout << "Liczba prób: " << counter << endl;
}