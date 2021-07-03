# BD2 LAB 08
1. Opracować procedurę wyświetlającą datę zawodów oraz liczbę startujących w nich
zawodników. Argumentem wejściowym jest data zawodów. W przypadku, gdy w zadanym dniu
nie było zawodów należy wyświetlić komunikat o braku zawodów w tym dniu.
2. Opracować procedurę, która wpisuje do tabeli klubów nowy klub. Argumentem wejściowym ma
być nazwa klubu. Wartość numeru klubu obliczać przy pomocy funkcji max (nr_klubu) + 1.
Procedura ma sprawdzać, czy taka nazwa klubu już istnieje w tabeli. Jeśli tak należy
wyświetlić stosowny komunikat.
3. Opracować procedurę, która wyświetla zadaną liczbę najlepszych zawodników danych
zawodach w następujący sposób: Nazwisko, Nazwa Klubu, czas_min:czas_sek. Argumentami
wejściowymi ma być numer zawodów oraz liczba wyświetlanych zawodników.
4. Opracować funkcję, która na wejściu posiada atrybuty: numer klubu oraz Action mogący
przyjmować następujące wartości: COUNT, SUMA, AVG w postaci napisu.
W zależności od tego atrybutu funkcja będzie zwracała:

* COUNT - liczbę aktywnych zawodników czyli tych, którzy startowali w sezonie
chociaż raz, 
* SUMA - sumę zdobytych punktów przez zawodników tego klubu, 
* AVG - średnią wieku zawodników tego klubu w rozbiciu na płeć.

Do tego celu opracować odpowiednią perspektywę lub perspektywy i jej / ich używać w ciele
funkcji. Użyć tej funkcji w kodzie programowym do wyświetlania wyników (wedle uznania).
5. Napisać procedurę, która przyjmuje jako dane wejściowe numer istniejącego klubu oraz nowy
numer tego klubu. Zadaniem jej jest zmiana numeru klubu na nowy w ewidencji klubów, jak
również zmiana numeru klubu w ewidencji zawodników.
6. Opracować funkcję logiczną, która stwierdza czy zawodnik o zadanym numerze startował
w zawodach o określonym numerze. W przypadku nieistnienia zadanego numeru zawodnika
lub numeru zawodów funkcja powinna zwracać null.
7. Słownik kategorii wiekowych (BD3_KATEGORIE) zawiera przedziały czasowe w postaci
roczników, które decydują o przynależności każdego zawodnika do odpowiedniej kategorii:

......

......
, przy czym nr_kategorii = 1 oznacza najmłodszą kategorię męską, 
= 11 oznacza najstarszą kategorię męską, 
= 20 oznacza najmłodszą kategorię żeńską, 
= 30 oznacza najstarszą kategorię żeńską.
Po zakończeniu rocznego cyklu biegowego czyli na początku każdego roku kalendarzowego
musi nastąpić modyfikacja przynależności zawodników do odpowiednich kategorii wiekowych.
Odbywało się to według następującego scenariusza:
• Modyfikacja tabeli BD3_KATEGORIE polegająca na przesunięciu okna
czasowego dla każdej kategorii o jeden rok, czyli przykładowo na początku roku
2018 dla kategorii o numerze 1 nowe wartości okna czasowego powinny
wynosić 1999 .. 2018, a dla kategorii o numerze 2 – 1989 .. 1998 itd. Dla
najstarszych kategorii obojga płci wartości w kolumnie dolny_prog mają
charakter symboliczny i nie muszą podlegać modyfikacji.
• Dla wszystkich zawodników (ale osobno dla mężczyzn i osobno dla kobiet)
następowało powtórne obliczenie przynależności do odpowiednich kategorii
wiekowych przy pomocy zdań SQL:

```sql
update bd3_zawodnicy
set nr_kategorii = (select nr_kategorii
from bd3_kategorie
where extract (year from data_urodzenia)
between dolny_prog and gorny_prog
and nr_kategorii between 1 and 11 )
where plec = 'M';
update bd3_zawodnicy
set nr_kategorii = (select nr_kategorii
from bd3_kategorie
where extract (year from data_urodzenia)
between dolny_prog and gorny_prog
and nr_kategorii between 20 and 30 )
where plec = 'K'
;
```

Zatwierdzenie transakcji zdaniem commit; 

Należy opracować procedurę, która zautomatyzuje ten proces oraz uniemożliwi powtórną
modyfikację tabel BD3_KATEGORIE i BD3_ZAWODNICY w tym samym roku kalendarzowym.
Ta druga funkcjonalność może być zapewniona przez sprawdzenie wartości w kolumnie
gorny_prog dla kategorii o numerze 1. W tym polu zawsze będzie znajdował się bieżący rok, jeśli nastąpiło już przeliczenie na jego początku.

Dodatkowo można zautomatyzować wykonanie się tej procedury poprzez opracowanie
zadania, które może być uruchamiane raz w roku (np. każdego 1 stycznia o godzinie 8:00).

Tworzenie zadań (jobs) zostało opisane w Laboratorium BD9.
