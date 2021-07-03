// Zadanie dodatkowe 1
// Program zagadujący liczbę od 1 do 50.
// Na zasadzie pytań czy jest większa czy miejsza od.
// Uczytkownik potwiedza "w"- większa, "m" - miejsza, z - zgadłeś.
// Na koniec wyświetla podsumownaie zgadłem w x próbach twoja liczba to y.

#include <iostream>
using namespace std;

int main()
{

    cout << "Gra w zgadywanie 1-50. Użytkownik wymyśla liczbę, program próbuje ją zgadnąć minimalnym zestawem pytań." << endl;
    int a = 1;
    int b = 50;
    int counter = 0;
    while (a != b)
    {
        counter++;
        int n = (a + b) / 2;
        cout << "Czy ta liczba to " << n << "? (napisz 'w' jeśli większa, 'm' jeśli mniejsza, 'z' jeśli zgadłem): ";
        char answer;
        cin >> answer;
        switch (answer)
        {
        case 'w':
            a = n;
            break;
        case 'm':
            b = n;
            break;
        case 'z':
            a = n;
            b = n;
            break;
        }
    }

    cout << "Ta liczba to musi być " << a << endl;
    cout << "Liczba prób: " << counter << endl;
}