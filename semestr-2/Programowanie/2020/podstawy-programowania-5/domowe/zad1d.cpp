#include <iostream>
using namespace std;

struct list
{
    int value;
    list *next;
};

int main()
{
    //przykład wykorzystania pamięci - tworzenie struktury listy.
    //alokacja dużej ilości danych (rzędu gb) z wykorzystaniem
    //prostej struktury tablic jest niemożliwa, ponieważ zakłada
    //że w pamięci istnieje duża, niezajęta przestrzeń - praktycznie niemożliwe
    //na nowoczesnych systemach operacyjnych. Sposobem na ominięcie tego problemu
    //jest alokacja z wykorzystaniem dynamicznych struktur danych, np. listy
    //jednokierunkowej.

    int N = 100000000;
    list *a = new list;
    list *first = a;

    int counter = 0;

    //alokacja pamieci
    for (int i = 0; i < N; i++)
    {
        list *next = new list;
        if (next != a + sizeof(list))
        {
            counter++;
        }
        a->next = next;
        a = next;
        a->value = rand();
        a->next = nullptr;
    }

    // a = first;
    // for (int i = 0; i < N; i++)
    // {
    //     cout << i << " " << a << " " << a->value << endl;
    //     a = a->next;
    // }

    a = first;

    //zwalnianie pamieci
    cout << "Zwalnianie pamięci." << endl;
    for (int i = 0; i < N; i++)
    {
        list *b = a;
        a = a->next;
        delete b;
    }
    cout << "Pamięć zwolniona" << endl;

    cout << "Przeskok wskaźnika nastąpił " << counter << " razy." << endl;
}