// Igor Nowicki
// 18608
// IZ02P03

#include <iostream>
#include <algorithm>
using namespace std;

int main()
{

    //deklaracja zmiennych
    string slowo;

    //pobieranie wartości od gracza
    cout << "Wpisz słowo: ";
    cin >> slowo;

    //zapisanie oryginalnego słowa w drugiej zmiennej
    string slowo2 = slowo;

    //mieszanie słowa
    random_shuffle(slowo.begin(), slowo.end());

    //wymazanie ekranu
    system("cls");

    string answer;

    //powtarzanie pętli tak długo aż gracz nie zgadnie słowa
    while (true)
    {
        cout << "Pomieszane slowo to: " << slowo << endl;
        cout << "Podaj poprawną postać słowa:";
        cin >> answer;
        if (answer != slowo2)
        {
            cout << "Odpowiedź niepoprawna!" << endl
                 << endl;
        }
        else
        {
            cout << "Poprawna odpowiedź!" << endl
                 << endl;
            return;
        }
    }
}