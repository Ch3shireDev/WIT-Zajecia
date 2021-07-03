#include <iostream>
#include <string>
using namespace std;

void swap(string *a, string *b)
{
    string c = *a;
    *a = *b;
    *b = c;
}

bool by_length(string &a, string &b)
{
    return a.length() > b.length();
}

int min(int a, int b)
{
    return a < b ? a : b;
}

bool alphabetical(string &a, string &b)
{
    return a > b;
}

// funkcja sortująca tablicę tab o rozmiarze size według zadanej reguły f.
void sort(string *tab, int size, bool (*f)(string &, string &))
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (f(tab[j], tab[j + 1]))
            {
                swap(tab + j, tab + j + 1);
            }
        }
    }
}

void print_all(string *tab, int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << tab[i] << endl;
    }
}

int main()
{
    string tab[8] = {
        "ciasteczka",
        "kopytka",
        "karmelki",
        "owocki",
        "kremowki",
        "szarlotka",
        "rodzynki",
        "twarozek"};

    cout << "Sortowanie według długości słów:" << endl;
    sort(tab, 8, by_length);
    print_all(tab, 8);

    cout << "Sortowanie alfabetyczne:" << endl;
    sort(tab, 8, alphabetical);
    print_all(tab, 8);
}