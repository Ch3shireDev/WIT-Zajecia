# BD2 LAB 04

1. Opracować zestawienie zawodników zawierające imię i nazwisko jako jedną kolumnę
o postaci A. ABACKI, wiek zawodnika i nazwę kategorii, dla zawodników, których numery
zawarte są w przedziałach `[30, 60]` i `[300, 350]` . Posortować zbiór malejąco według wieku zawodnika.

```sql
select 
    nr_zawodnika as "Numer", 
    substr(imie, 1,1)||'.'||upper(nazwisko) as "IMIĘ.NAZWISKO", 
    floor(months_between(sysdate, data_urodzenia) /12)  AS "Wiek" 
from 
    bd3_zawodnicy 
where   
    nr_zawodnika between 30 and 60 
    or 
    nr_zawodnika between 300 and 350 
order by 3 desc;

```

2. Obliczyć, ile kobiet należy do klubów o numerach z przedziału `[10, 20]`, które brały udział w zawodach nr 4.

```sql
select 
    count(*) 
from 
    BD3_ZAWODNICY z, 
    BD3_WYNIKI w 
where 
    z.NR_ZAWODNIKA = w.NR_ZAWODNIKA 
    and 
    PLEC = 'K' 
    and
    NR_ZAWODOW = 4
    and
    NR_KLUBU between 10 and 20
```

3. Opracować zestawienie liczności uczestników zawodów nr 3 w postaci `Nazwa kategorii, Liczba uczestników`. Posortować malejąco zbiór według liczności uczestników.

```sql
select
    nazwa_kategorii as "Nazwa kategorii",
    count(*) as "Liczba uczestników" 
from 
    BD3_ZAWODNICY z, BD3_KATEGORIE k
where 
    z.NR_KATEGORII = k.NR_KATEGORII
group by 
    z.nr_kategorii, 
    nazwa_kategorii
order by
    z.nr_kategorii
```

4. Opracować zestawienie pokazujące sumaryczną liczbę zdobytych punktów w klasyfikacji generalnej ( `punkty_globalne` ) przez poszczególne kluby w zawodach nr 1 uwzględniając tylko mężczyzn. Raport zawierający numery klubów posortować malejąco według zdobytych
punktów i numerów klubów rosnąco i nie pokazywać w nim klubów, które nie zdobyły punktów.

```sql
select 
    z.nr_klubu as "Numer klubu", 
    sum(w.punkty_globalne) as "Suma punktów"
from 
    bd3_zawodnicy z, 
    bd3_wyniki w 
where 
    z.nr_zawodnika = w.nr_zawodnika
    and
    z.plec = 'M'
    and
    w.nr_zawodow = 1
group by
    z.nr_klubu,
    z.plec
having
    sum(w.punkty_globalne) is not null
order by
    2 desc,
    1 asc
```

5. Opracować zestawienie pokazujące sumaryczną liczbę zdobytych punktów w klasyfikacji
generalnej przez poszczególne kluby w zawodach nr 3 uwzględniając tylko kobiety. Raport ten zawierający nazwy klubów posortować malejąco według zdobytych punktów i nie pokazywać w nim klubów, które zdobyły mniej niż 50 punktów.

```sql
select
    z.nr_klubu as "Numer klubu",
    k.nazwa_klubu as "Nazwa klubu",
    sum(w.punkty_globalne) as "Klasyfikacja generalna"
from
    bd3_zawodnicy z,
    bd3_wyniki w,
    bd3_kluby k
where
    z.nr_zawodnika = w.nr_zawodnika
    and
    k.nr_klubu = z.nr_klubu
    and
    z.plec = 'K'
    and
    w.nr_zawodow = 3
group by
    z.nr_klubu,
    z.plec,
    k.nazwa_klubu
having
    sum(w.punkty_globalne) >= 50
order by
    3 desc
```

6. Opracować zestawienie obrazujące średni wiek kobiet i mężczyzn uczestniczących
w poszczególnych zawodach o postaci: `Płeć, Data zawodów, Nazwa zawodów, Średni wiek, Liczba zawodników` . Średni wiek przedstawiać z dokładnością do jednego miejsca po przecinku (np. 42.4), a datę zawodów w formacie zawierającym pełną nazwę miesiąca. Zbiór wyników uporządkować według daty zawodów, płci oraz liczby zawodników malejąco.

```sql
select
    plec as "Płeć",
    to_char(data_zawodow, 'YYYY-MONTH-DD') as "Data zawodów",
    nazwa_zawodow as "Nazwa zawodów",
    to_char(sum(floor(months_between(sysdate, data_urodzenia) /12) ) / count(*), '00.0')  as "Średni wiek",
    count(*) as "Liczba zawodników"
from
    bd3_zawodnicy
    inner join bd3_wyniki using(nr_zawodnika)
    inner join bd3_zawody using(nr_zawodow)
group by
    nr_zawodow,
    plec,
    data_zawodow,
    nazwa_zawodow
order by
    2 desc,
    1 desc,
    5 desc
```

7. Utworzyć tabelę mogącą przechowywać zagregowane dane dotyczące klubów o strukturze:
nazwa klubu, liczności zarejestrowanych zawodników, średniej ich wieku. Wykorzystać
konstrukcję `insert into ... select ...` .

```sql
drop table BD4_DANE_KLUBOW;

create table BD4_DANE_KLUBOW 
(
    NR_KLUBU number primary key,
    NAZWA_KLUBU varchar2(64) not null,
    LICZBA_ZAWODNIKOW number not null,
    SREDNIA_WIEKU number(3,1) not null
);

insert into 
    BD4_DANE_KLUBOW (NR_KLUBU, NAZWA_KLUBU, LICZBA_ZAWODNIKOW, SREDNIA_WIEKU)
select 
    NR_KLUBU,
    NAZWA_KLUBU,
    COUNT(*),
    round(sum(floor(months_between(sysdate, data_urodzenia) /12) ) / count(*), 1)
from
    BD3_ZAWODNICY
    inner join BD3_KLUBY using(NR_KLUBU)
group by
    NR_KLUBU,
    NAZWA_KLUBU
    ;

select * from bd4_dane_klubow;
```

1. Utworzyć tabelę mogącą przechowywać zagregowane dane dotyczące daty zawodów
(o postaci YYYY-MM-DD) oraz liczby uczestniczących w nich zawodników. Wykorzystać
konstrukcję `create table ... as select ...` .

```sql
drop table BD4_ZAWODY_DANE;

create table 
    BD4_ZAWODY_DANE 
as 
(
    select
        NR_ZAWODOW,
        NAZWA_ZAWODOW,
        TO_CHAR(DATA_ZAWODOW, 'YYYY-MM-DD') as "Data zawodów",
        COUNT(*) AS LICZBA_UCZESTNIKOW
    from
        BD3_ZAWODY
        inner join BD3_WYNIKI using(NR_ZAWODOW)
        inner join BD3_ZAWODNICY using(NR_ZAWODNIKA)
    group by
        NR_ZAWODOW,
        NAZWA_ZAWODOW,
        DATA_ZAWODOW
)
;
```

9. Wykonać eksperyment polegający na uruchomieniu poniższych zdań zawierających funkcje
agregujące:

```sql
select count ( * ) as "Liczba zawodników" from bd3_zawodnicy;
-- Wynik : 771

select 
    nr_klubu as "Nr klubu", 
    count ( * ) as "Liczba zawodników" 
from 
    bd3_zawodnicy
group by 
    nr_klubu
; 

-- 22 rows selected

select 
    count ( * ) as "Liczba zawodników"
from 
    bd3_zawodnicy
group by 
    nr_klubu
; 

-- 22 rows selected

select 
    avg (count ( * )) as "Średnia liczba zawodników"
from 
    bd3_zawodnicy
group by 
    nr_klubu
; 

-- Wynik: 35.0454545

select 
    max (count ( * )) as "Maks liczba zawodników"
from 
    bd3_zawodnicy
group by 
    nr_klubu
;

-- Wynik: 146
```

Zastanowić się nad interpretacją wyników, szczególnie trzech ostatnich zdań. Jest to o tyle ważne, że takie konstrukcje występują w bardziej skomplikowanych zdaniach SQL, 
na przykład w podzapytaniach.
