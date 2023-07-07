
// Zadanie 2
// Napisz program, który wypisze zawartość tablicy zadeklarowanej w następujący sposób: int a[ ] = {1, 3, 5, 7, 9, 11, 13}; Należy napisać dwie funkcje: wersję zwykłą opartą o indeksowanie tablicy i wersję wskaźnikową.

#include <iostream>
using namespace std;

void show_pointers(int* a, int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << *(a+i) << " ";
    }
    cout << endl;
}

int main()
{
    int a[] = {1, 3, 5, 7, 9, 11, 13};

    show_pointers(a, 7);

    return 0;
}