#include <iostream>
#include <random>
#include <ctime>
using namespace std;

void swap(int *a, int *b)
{
    int c = *a;
    *a = *b;
    *b = c;
}

void sortuj(int *tab, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (tab[j] > tab[j + 1])
            {
                //funkcja swap korzysta ze wskaźników do zmiennych które ma
                //zamienić miejscami. ponieważ tab jest wskaźnikiem na pierwszy
                //element tablicy, i-ty element tablicy mogę przekazać zwyczajnie
                //przez dodawanie wartości liczbowej do wskaźnika.
                swap(tab + j, tab + j + 1);
            }
        }
    }
}

int main()
{
    //program przedstawiający związek tablic ze wskaźnikami.
    srand(time(0));
    const int N = 128;
    int tab[N];
    for (int i = 0; i < N; i++)
    {
        tab[i] = rand() % N;
    }

    sortuj(tab, N);

    for (int i = 0; i < N; i++)
    {
        cout << tab[i] << endl;
    }

    //tablicę mogę też stworzyć przez użycie wskaźnika. To pozwala mi na dynamiczne
    //ustalenie rozmiaru tablicy, zamiast trzymać się ustalonego rozmiaru na samym początku.
    int *tab2 = new int[N];

    for (int i = 0; i < N; i++)
    {
        tab2[i] = rand() % N;
    }

    cout << "Sortowanie dynamicznie zaalokowanej tablicy" << endl;
    sortuj(tab2, N);
    for (int i = 0; i < N; i++)
    {
        cout << tab[i] << endl;
    }

    //po zakończeniu pracy muszę zwolnić pamięć,
    // inaczej ten sektor pamięci pozostanie zajęty aż do restartu komputera
    delete[] tab2;
}