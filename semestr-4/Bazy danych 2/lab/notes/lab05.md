# BD2 LAB 05

1. Opracować perspektywę `bd3_liczba_zawodnikow` zliczającą zarejestrowanych zawodników
w rozbiciu na płeć, a następnie na jej podstawie obliczyć liczbę zaewidencjonowanych
zawodniczek.

```sql
create or replace view 
    BD3_LICZBA_ZAWODNIKOW 
    (
        "Płeć", 
        "Liczba uczestników"
    ) 
as
    select 
        PLEC, 
        count(*)
    from
        BD3_ZAWODNICY
    group by
        PLEC
    ;

select "Liczba uczestników" from BD3_LICZBA_ZAWODNIKOW where "Płeć" = 'K';
```

2. Opracować perspektywę `bd3_ewidencja` zawierającą kolumny `Nazwisko, Klub, Kategoria, Wynik, Zawody, Data zawodów`

przy czym:
* Nazwisko jest złożeniem kolumn `nazwisko` i `imie`, 
* Klub to `nazwa_klubu`, 
* Kategoria to `nazwa_kategorii`, 
* Wynik to złożenie kolumn `rezultat_min` i `rezultat_sek` i przedstawienie jej w formacie `mm:ss`, (wykorzystać funkcję `to_char` lub cast), 
* Zawody to kolumna nazwa_zawodow, 
* Data Zawodów to kolumna data_zawodow.
  
Opracować zdanie SQL, które na podstawie tej perspektywy będzie generować listę osiągnięć
podanego tylko z nazwiska zawodnika porządkując zbiór malejąco według daty zawodów.

```sql
create or replace view
    BD3_EWIDENCJA
    (
        "Nazwisko",
        "Klub",
        "Kategoria",
        "Wynik",
        "Zawody",
        "Data zawodów"
    )
as
    select 
        NAZWISKO || ' ' || IMIE, 
        NAZWA_KLUBU, 
        NAZWA_KATEGORII, 
        TO_CHAR(REZULTAT_MIN, 'FM00') || ':' || TO_CHAR(REZULTAT_SEK, 'FM00'),
        NAZWA_ZAWODOW,
        DATA_ZAWODOW
    from
        BD3_ZAWODNICY
        inner join BD3_WYNIKI using(NR_ZAWODNIKA)
        inner join BD3_ZAWODY using(NR_ZAWODOW)
        inner join BD3_KATEGORIE using(NR_KATEGORII)
        inner join BD3_KLUBY using(NR_KLUBU)
    ;

select * from BD3_EWIDENCJA where "Nazwisko" like 'Nowakowski%';
```

3. Założyć tabelę `BD3_KLASYFIKACJA_GEN` przy pomocy konstrukcji `create table as select ...` przechowującą nr klubu, sumę zdobytych punktów w klasyfikacji generalnej, liczbę zawodników każdego klubu startujących w zawodach oraz liczbę zawodników zaewidencjonowanych w każdym klubie. Na jej podstawie opracować perspektywę generującą raport pokazujący klasyfikację klubów, w którym są uwzględnione tylko te kluby, które zdobyły punkty w tej klasyfikacji zawierający nazwę klubu, sumę zdobytych punktów w klasyfikacji globalnej oraz liczbę startujących zawodników.

Należy wykorzystać technikę złączeń zewnętrznych oraz odpowiednio zastosować argument funkcji `count`.

```sql
drop table BD3_KLASYFIKACJA_GEN;

create table 
    BD3_KLASYFIKACJA_GEN 
    (
        NR_KLUBU,
        SUMA_PUNKTOW,
        LICZBA_ZAWODNIKOW_W_ZAWODACH,
        LICZBA_ZAWODNIKOW_W_KLUBIE
    )
as 
    select
        NR_KLUBU,
        sum(PUNKTY_GLOBALNE),
        count(PUNKTY_GLOBALNE),
        count(*)
    from
        BD3_WYNIKI
        inner join BD3_ZAWODNICY using(NR_ZAWODNIKA)
    group by
        NR_KLUBU
;
```

4. Założyć sekwencję umożliwiającą wprowadzanie nowych wierszy do tabeli `BD3_ZAWODY` przy uwzględnieniu już istniejących.

5. Założyć indeks zwiększający wydajność serwera dla wybranych kluczy obcych oraz dla wybranych kolumn często stosowanych przy filtrowaniu bazy (na przykład nazwisko i imię).

```sql
create index inx_bd3_nazwisko on bd3_zawodnicy(NAZWISKO);
```