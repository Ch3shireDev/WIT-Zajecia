#include <algorithm>
#include <iostream>
#include <vector>

typedef std::vector<int> Vec;
typedef Vec::iterator It;

Vec get_data()
{
    Vec data;

    int x;
    while (std::cin >> x)
        data.push_back(x);

    std::sort(data.begin(), data.end());

    return data;
}

// Napisz program duplicates, który czyta ze standardowego wejścia liczby całkowite do napotkania końca
// pliku i wypisuje na standardowe wyjście w kolejności rosnącej wszystkie liczby powtarzające się, każdą
// tylko raz. Program zawiera po jednym wywołaniu funkcji std::adjacent_find, std::find_if oraz
// std::sort i nie używa innych algorytmów bibliteki standardowej. Program załącza tylko pliki nagłówkowe
// algorithm, iostream i vector.
// Przykładowe wykonanie
// In: 13 7 2 13 5 2 1 13
// Out: 2 13
int main()
{
    Vec data = get_data();

    It it = data.begin();

    // Z jakiegoś powodu.
    std::find_if(it, data.end(), [](int x){return true;});

    int last;
    bool flag = true;
    while (it != data.end())
    {
        it = std::adjacent_find(it, data.end());

        // Jeśli nie znalazłeś powtórzeń, zakończ działanie.
        if (it == data.end())
            return 0;

        // Jeśli wypisujesz pierwsze powtórzenie, lub jeśli nie jest ono takie samo jak ostatnie, wypisz na ekran.
        if (flag || *it != last)
        {
            // Wyłącz flagę pierwszego powtórzenia.
            flag = false;
            // Wypisz wartość na standardowe wyjście.
            std::cout << *it << " ";
            // Zapamiętaj wartość na następne powtórzenie.
            last = *it;
        }
        it++;
    }
}
