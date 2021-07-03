Omówimy dziś znajdywanie najkrótszej drogi w grafie metodą Dijkstry. Metoda ta pozwala nam w sposób optymalny znaleźć trasę o najniższym koszcie pomiędzy dwoma punktami.

Formalnie - dany jest graf ważony krawędziowo o nieujemnych wagach. Czy dla danych dwóch węzłów jesteśmy w stanie znaleźć minimalny koszt przejścia? Czy taki algorytm zwróci nam również optymalną trasę?

Algorytm Dijkstry używa metody zachłannej rozwiązywania problemu - przechodząc przez graf za każdym razem wybieramy najbardziej opłacalną opcję.

Jak to działa? Po pierwsze, wybierz jeszcze nieodwiedzony węzeł o najniższym koszcie. Po drugie, zaktualizuj koszty wszystkich sąsiadów. Powtarzaj to tak długo, aż odwiedzisz wszystkie węzły.

Schemat blokowy algorymu wygląda następująco. Na wstępie przyjmujemy graf w postaci macierzy oraz indeks węzła z którego będziemy prowadzili ścieżki. Tworzymy pomocnicze zbiorniki danych o rozmiarach równych liczbie wierzchołków grafu - zbiór POZOSTAŁE w którym trzymamy indeksy nieodwiedzonych węzłów, tablicę KOSZTY w których szacujemy koszty przejścia oraz tablicę POPRZEDNICY w której zapamiętujemy węzły poprzedzające.

Następnie, wykonujemy pętlę tak długo, dopóki nie opróżnimy zbioru POZOSTAŁE.

Znajdujemy węzeł bieżący - jest on tą wartością z pozostałych, która ma minimalny przypisany koszt. Usuwamy węzeł z pozostałych.

Wykonujemy teraz wewnętrzną pętlę dla wszystkich sąsiadów bieżącego węzła.

Jeśli sąsiad jest już odwiedzony, to go pomijamy. Jeśli nie, sprawdzamy czy możemy zaktualizować jego koszt o wartość kosztów bieżącego węzła plus dystans do sąsiada. Jeśli tak, aktualizujemy koszty, oraz zmieniamy poprzednika sąsiada na węzeł bieżący.

Po wyjściu z pętli zwracamy tablice kosztów oraz poprzedników. Z niej będziemy mogli odczytać optymalne trasy i koszty przejścia do wszystkich węzłów.

Jako przykład działania weźmiemy graf z początku prezentacji. Będziemy szukać optymalnej trasy z A do B.

Zaczynamy. Ustalamy koszt A na zero - ponieważ jest to węzeł początkowy.

Pierwszy krok. Usuwamy A ze zbioru POZOSTAŁE. Uzupełniamy koszty B, C, D oraz E. Uzupełniamy wartość poprzedników na A. Ustalamy, że węzłem o najniższym koszcie jest E.

Drugi krok. Usuwamy E z listy pozostałych. Aktualizujemy C - pomijamy A jako odwiedzone oraz D jako węzeł o kosztach równych nowej wartości. Ustalamy, że C ma najniższy koszt.

Trzeci krok. Kasujemy C z pozostałych. Aktualizujemy koszty drogi do B, natomiast D zostawiamy. Następcą będzie B.

Czwarty krok. Usuwamy B z listy pozostałych. Nie mamy żadnego sąsiada do zaktualizowania. Następnym węzłem jest D.

Uzyskaliśmy tablice wyników KOSZTY oraz POPRZEDNICY. Na podstawie tego ustalamy, że najtańsza droga z A do B kosztuje 3 oraz idzie trasą: z A do E do C do B.

Poniżej przedstawiona jest implementacja algorytmu w Pythonie.
Tworzone są trzy pojemniki - pozostałe, poprzednicy oraz koszty. Aby przyspieszyć działanie programu, pojemnik pozostałe został zdefiniowany jako zbiór.

Wykonywana jest pętla while tak długo, dopóki zbiór pozostałe nie zostanie opróżniony. Węzeł bieżący to indeks z pozostałych odpowiadający minimalnemu kosztowi. Z pozostałych jest usuwany węzeł bieżący. Następnie pobierana jest z grafu lista dystansów do sąsiadów.

Wykonywana jest teraz pętla po wszystkich możliwych sąsiadach bieżącego węzła. Jeśli dany sąsiad nie znajduje się w pozostałych, lub prezentowany dystans jest równy zeru - węzeł jest pomijany. Ustalany jest nowy koszt. Jeśli taka wartość jest niższa niż bieżący koszt, aktualizowany jest poprzednik oraz koszt sąsiada.

Na końcu funkcji zwracana jest lista kosztów oraz poprzedników.

Oszacujemy teraz złożoność czasową algorytmu. Proces przyjmowania danych ma koszt jednostkowy, tworzenie zbiorników danych na N elementów ma złożoność N. Pętle powodują przemnożenie danych wartości przez N. Wyszukiwanie węzła bieżącego ma również złożoność N. Sprawdzanie czy sąsiad jest w POZOSTAŁE ma złożoność log(N) dzięki zastosowaniu zbioru zamiast listy. Pozostałe operacje przypisania, porównania oraz zwracania wartości mają złożoności jednostkowe.

Podstawiamy wartości pod schemat i ustalamy funkcję złożoności czasowej. Na jej podstawie stwierdzamy, że najszybciej rosnącym czynnikiem jest N^2 log N - zatem funkcja będzie miała złożoność O-duże od N2logN

Badając czas przetwarzania losowych grafów o zadanych wielkościach uzyskałem następujące punkty pomiarowe, reprezentowane czerwonymi kropkami. Widzimy, że można do nich dopasować krzywą x^2 log x, na rysunku pod postacią niebieskiej krzywej. Zatem przewidywania złożoności czasowej są poprawne.