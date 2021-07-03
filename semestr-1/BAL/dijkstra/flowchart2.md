1. WEJŚCIE:
    - GRAF - N list o N wartościach nieujemnych
    - START - indeks węzła z którego będziemy prowadzić poszukiwania

2. Stwórz zbiór `POZOSTAŁE` zawierający liczby od 1 do N.
3. Stwórz tablicę N elementów `KOSZTY` o wartościach `inf`. Dla pozycji `POCZĄTEK` ustaw wartość 0.
4. Stwórz tablicę N elementów `POPRZEDNICY` o pustych wartościach.

5. Dopóki `POZOSTAŁE` nie jest pusty:
    1. Niech `BIEŻĄCY` będzie wartością z `POZOSTAŁE` o minimalnej wartości `KOSZTY[BIEŻĄCY]`.
    2. Usuń `BIEŻĄCY` z `POZOSTAŁE`
    3. Dla każdego sąsiada `SĄSIAD` z `BIEŻĄCY`:
        1. Niech `NOWA_CENA` będzie równa `KOSZTY[BIEŻĄCY]` + `DYSTANS[SĄSIAD]`
        2. Jeśli `NOWA_CENA < KOSZTY[SĄSIAD]`:
            1. Niech `KOSZTY[SĄSIAD]` będą równe `NOWA_CENA`
            2. Niech `POPRZEDNICY[SĄSIAD]` będzie równy `BIEŻĄCY`.

6. Zwróć wartości `KOSZTY`, `POPRZEDNICY`