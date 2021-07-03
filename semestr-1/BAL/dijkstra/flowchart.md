# Schemat blokowy

1. Wejście: 
- `GRAF`: N list N-elementowych, 
- `START`: numer startowego wierzchołka
- `KONIEC`: numer końcowego wierzchołka.

2. Stwórz następujące pojemniki na dane:
- Zbiór `NIEODWIEDZONE` zawierajacy wartości od `1` do `N`.
- Tablicę `POPRZEDNI` o rozmiarze N.
- Tablicę `KOSZT` o rozmiarze N, wypełnioną wartościami `inf`. Na pozycji `START` wpisz wartość `0`.
- Zmienną `OSTATNI` równą `-1`.
3. Potwarzaj co następuje tak długo, dopóki zbiór `NIEODWIEDZONE` nie będzie pusty:
    1. Stwórz zmienną `i` zawierajacą pierwszą wartość z `NIEODWIEDZONE`.
    2. Przejdź po wszystkich `j` z `NIEODWIEDZONE`:
        1. Jeśli `KOSZT[j] < KOSZT[i]`, to przypisz `i` wartość `j`.
    2. Wpisz w `POPRZEDNI[i]` wartość `OSTATNI`.
    3. Wpisz w `OSTATNI` wartość `i`.
    4. Wyrzuć ze zbioru `NIEODWIEDZONE` wartość `i`.
    5. Stwórz listę `SĄSIEDZI` w którą wstaw wartości z `GRAF[i]`.
    6. Powtórz co następuje dla wszystkich `j` z zakresu od `1` do `N`:
        1. Jeśli `j` nie istnienie w `NIEODWIEDZONE`, to pomiń to powtórzenie.
        2. Jeśli `SĄSIEDZI[j]` jest równe 0 to pomiń to powtórzenie.
        3. Stwórz `NOWA_WARTOŚĆ` równą `KOSZT[i] + SĄSIEDZI[j]`
        4. Jeśli `NOWA_WARTOŚĆ` jest niższa niż `KOSZT[j]`, to wpisz ją w `KOSZT[j]`.

4. Stwórz pustą listę `TRASA`.
5. Do zmiennej `OSTATNI` wpisz wartość `KONIEC`.
6. Powtarzaj co następuje:
    1. Jeśli wartość `OSTATNI` jest równa -1, zakończ pętlę
    2. Dopisz wartość `OSTATNI` na początek listy.
    3. Do zmiennej `OSTATNI` wpisz wartość `POPRZEDNI[OSTATNI]`.

7. Zwróć wartości `TRASA` oraz `KOSZT[OSTATNI]`.