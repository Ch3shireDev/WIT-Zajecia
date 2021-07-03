# BD2 LAB 06

0. Opracować perspektywę `BD3_WYNIKI_ZAWODOW` tworzącą zbiór o postaci: `NR_ZAWODOW, ZAWODNIK, KLUB, REZULTAT`, gdzie rezultat jest postaci `mm:ss`. Następnie w oparciu o perspektywą tworzyć zbiory wyników dla poszczególnych zawodów wykorzystując zmienną wiązania `:nr_zawodow`. Należy wykorzystać konstrukcję `case` oraz funkcję `to_char` w połączeniu z działaniem konkatenacji.

```sql
create or replace view
    BD3_WYNIKI_ZAWODOW
        (
            NR_ZAWODOW,
            ZAWODNIK,
            KLUB,
            REZULTAT
        )
    as
        select
            NR_ZAWODOW, NAZWISKO, NAZWA_KLUBU, TO_CHAR(REZULTAT_MIN, 'FM00') || ':' || TO_CHAR(REZULTAT_SEK, 'FM00')
        from
            BD3_WYNIKI
            inner join BD3_ZAWODNICY using(NR_ZAWODNIKA)
            inner join BD3_KLUBY using(NR_KLUBU)
    ;

select * from BD3_WYNIKI_ZAWODOW where NR_ZAWODOW = :NR_ZAWODOW;
```

1. Opracować zestawienie pokazujące zawodników i osiągnięte przez nich rezultaty, którzy należą do tego samego klubu, co zwycięzca zawodów nr 2 wśród mężczyzn.

```sql

```

2. Opracować zestawienie kobiet należących do klubów, w których liczność zawodników
przekracza liczbę 5.
3. Opracować zestawienie (Imię i nazwisko, Nazwa klubu i Nazwa Kategorii) pokazujące
zawodniczki, które należą do klubów niewarszawskich i ich wiek jest większy od średniej wieku wszystkich kobiet w ewidencji.5
4. Opracować zdanie pokazujące zawodnika i zawodniczkę (Nazwisko i imię, przynależność
klubowa oraz kategoria wiekowa), którzy zdobyli najwięcej punktów w klasyfikacji generalnej.
5. (trudne) Opracować zdanie pokazujące najlepszych zawodników i zawodniczki (Nazwisko i
imię, przynależność klubowa oraz kategoria wiekowa), którzy zdobyli najwięcej punktów
w klasyfikacji w kategoriach.
W tym zadaniu należy wykorzystać następujące techniki:
* zamiana minut i sekund na sekundy, 
* tworzenie na liście from perspektyw chwilowych: pierwszej zawierającej najlepszy wynik w każdej kategorii wiekowej i drugiej znajdującej numer zawodnika w każdej kategorii wiekowej, który ten najlepszy wynik uzyskał.
  
Należy skorzystać ze zdania podrzędnego, a rezultaty wyświetlić w postaci `mm:ss` .
Należy wykonać raport przy pomocy zdania podrzędnego. Jako kryterium kwalifikacji do klubów warszawskich przyjąć nazwę klubu, w której znajduje się fragment słowa Warszawa (np. Warsz) w dowolnym miejscu nazwy.
