# BD2 LAB 03

Poniższe zadania wykonać przy następujących założeniach:

* We wszystkich zadaniach pobierać dane z minimum trzech tabel, 
* Kolumny Imię i Nazwisko łączyć w jedną kolumnę, 
* Stosować aliasy do zmiany nazw kolumn, 
* Zestawienia powinny zawierać takie kolumny jak Nazwisko i imię, Nazwa klubu, 
Nazwa kategorii.

01.  Opracować raport zawierający zestawienie mężczyzn, którzy brali udział w zawodach numer 1
i 3 i uzyskali wynik między 44 i 48 min (kolumny `Rezultat_Min` i `Rezultat_Sek` ). Posortować zbiór według numeru zawodów i osiągniętego czasu.

```sql
select 
    imie || ' ' || nazwisko as "Imie i nazwisko", 
    nazwa_klubu as "Nazwa klubu", 
    nazwa_kategorii as "Nazwa kategorii",
    nr_zawodow as "Numer zawodów",
    to_char(rezultat_min) ||':'||to_char(rezultat_sek, 'FM00') as "Czas"
    from 
        bd3_zawodnicy, 
        bd3_kluby, 
        bd3_kategorie,
        bd3_wyniki
    where 
        bd3_zawodnicy.nr_klubu = bd3_kluby.nr_klubu 
        and 
        bd3_zawodnicy.nr_kategorii = bd3_kategorie.nr_kategorii
        and
        bd3_zawodnicy.nr_zawodnika = bd3_wyniki.nr_zawodnika
        and
        bd3_zawodnicy.plec = 'M'
        and
        bd3_wyniki.nr_zawodow in (1,3)
        and 
        rezultat_min between 44 and 48
    order by
        nr_zawodow, 
        rezultat_min, 
        rezultat_sek
    ;
```

02.  Opracować zestawienie kobiet, które należą do klubów o numerach od 5 do 40, urodzone są
w latach między 1975 i 1984 i które nie zdobyły punktów w klasyfikacji generalnej (kolumna
Punkty_Globalne).

```sql
select 
    IMIE || ' ' || NAZWISKO as "Imię i nazwisko", 
    DATA_URODZENIA,
    bd3_kluby.nr_klubu as "Numer klubu", 
    bd3_kluby.nazwa_klubu as "Nazwa klubu", 
    bd3_kategorie.nazwa_kategorii as "Nazwa kategorii",
    bd3_wyniki.nr_zawodow as "Numer zawodów",
    bd3_wyniki.punkty_globalne as "Punkty"
from
    bd3_zawodnicy, 
    bd3_kluby, 
    bd3_kategorie,
    bd3_wyniki
where
    bd3_zawodnicy.nr_klubu = bd3_kluby.nr_klubu 
    and bd3_zawodnicy.nr_kategorii = bd3_kategorie.nr_kategorii
    and bd3_zawodnicy.nr_zawodnika = bd3_wyniki.nr_zawodnika
    and PLEC = 'K'
    and bd3_kluby.NR_KLUBU between 5 and 40
    and EXTRACT(YEAR FROM DATA_URODZENIA) between 1975 and 1984
    and PUNKTY_GLOBALNE is NULL
    ;
```

03. Opracować komunikat końcowy zawodów numer 3 pokazujący klasyfikację zawodników
(mężczyzn) na mecie według osiągniętych czasów. Wykorzystać kolumnę Lokata_W_Biegu.

```sql
select 
    LOKATA_W_BIEGU,
    IMIE || ' ' || NAZWISKO as "Imię i nazwisko",
    REZULTAT_MIN || ':' || TO_CHAR(REZULTAT_SEK, 'FM00') AS "Czas",
    bd3_kluby.nr_klubu as "Numer klubu", 
    bd3_kluby.nazwa_klubu as "Nazwa klubu", 
    bd3_kategorie.nazwa_kategorii as "Nazwa kategorii",
    bd3_wyniki.nr_zawodow as "Numer zawodów",
    bd3_wyniki.punkty_globalne as "Punkty"
from
    bd3_zawodnicy, 
    bd3_kluby, 
    bd3_kategorie,
    bd3_wyniki
where
    bd3_zawodnicy.nr_klubu = bd3_kluby.nr_klubu 
    and bd3_zawodnicy.nr_kategorii = bd3_kategorie.nr_kategorii
    and bd3_zawodnicy.nr_zawodnika = bd3_wyniki.nr_zawodnika
    and PLEC = 'M'
    and BD3_WYNIKI.NR_ZAWODOW = 3
    order by LOKATA_W_BIEGU
    ;
```

04. Przy pomocy unii zaprojektować raport pokazujący zestawienie mężczyzn należących do
kategorii IV i kobiet urodzonych w latach 1970 – 1985, których nazwiska zaczynają się na literę
K i kończą na ‘ska’. Posortować zbiór według roku urodzenia i nazwiska.

```sql
select
    z.NAZWISKO || ' ' || z.IMIE  as "Nazwisko i imię",
    z.DATA_URODZENIA as "Data urodzenia",
    k.nr_klubu as "Numer klubu", 
    k.nazwa_klubu as "Nazwa klubu", 
    c.nazwa_kategorii as "Nazwa kategorii",
    w.nr_zawodow as "Numer zawodów",
    w.punkty_globalne as "Punkty"
from
    bd3_zawodnicy z, 
    bd3_kluby k, 
    bd3_kategorie c,
    bd3_wyniki w
where
    z.nr_klubu = k.nr_klubu 
    and z.nr_kategorii = c.nr_kategorii
    and z.nr_zawodnika = w.nr_zawodnika
    and PLEC = 'M'
    and c.nazwa_kategorii = 'IV'
union

select
    z.NAZWISKO || ' ' || z.IMIE  as "Nazwisko i imię",
    z.DATA_URODZENIA as "Data urodzenia",
    k.nr_klubu as "Numer klubu", 
    k.nazwa_klubu as "Nazwa klubu", 
    c.nazwa_kategorii as "Nazwa kategorii",
    w.nr_zawodow as "Numer zawodów",
    w.punkty_globalne as "Punkty"
from
    bd3_zawodnicy z, 
    bd3_kluby k, 
    bd3_kategorie c,
    bd3_wyniki w
where
    z.nr_klubu = k.nr_klubu 
    and z.nr_kategorii = c.nr_kategorii
    and z.nr_zawodnika = w.nr_zawodnika
    and PLEC = 'K'
    and EXTRACT(YEAR FROM DATA_URODZENIA) BETWEEN 1970 AND 1985
    and Nazwisko like 'K%ska'
order by 2,1
    ;
```

05. Wykonać zadanie z pkt. 4 korzystając z jednego zdania select.

```sql
select
    z.NAZWISKO || ' ' || z.IMIE  as "Nazwisko i imię",
    z.DATA_URODZENIA as "Data urodzenia",
    k.nr_klubu as "Numer klubu", 
    k.nazwa_klubu as "Nazwa klubu", 
    c.nazwa_kategorii as "Nazwa kategorii",
    w.nr_zawodow as "Numer zawodów",
    w.punkty_globalne as "Punkty"
from
    bd3_zawodnicy z, 
    bd3_kluby k, 
    bd3_kategorie c,
    bd3_wyniki w
where
    z.nr_klubu = k.nr_klubu 
    and z.nr_kategorii = c.nr_kategorii
    and z.nr_zawodnika = w.nr_zawodnika
    and 
    (
        PLEC = 'M'
        and c.nazwa_kategorii = 'IV'
    or
        PLEC = 'K'
        and EXTRACT(YEAR FROM DATA_URODZENIA) BETWEEN 1970 AND 1985
        and Nazwisko like 'K%ska'
    )
order by 2,1
    ;
```

06. Dokonać modyfikacji modelu bazy danych. O każdym klubie należy przechowywać informacje
teleadresowe, rok założenia klubu, nazwisko prezesa klubu itp. Dane te należy zapisywać
w osobnej tabeli. Dokonać odpowiedniej modyfikacji relacji między tabelami poprzez napisanie
skryptu realizującego te modyfikacje. Wprowadzić przykładowe dane dla kilku klubów i napisać
zdanie wybierające informacje z bazy przy uwzględnieniu nowej tabeli.

```sql
drop table BD3_KLUB_INFORMACJE;

alter table BD3_KLUBY
    add primary key (NR_KLUBU);

create table BD3_KLUB_INFORMACJE
    (
        NR_KLUBU number(38,0) primary key references BD3_KLUBY(NR_KLUBU),
        TELEFON_KONTAKTOWY varchar2(12),
        ROK_ZALOZENIA varchar2(4),
        PREZES varchar2(64)
    );
```

07.  Dokonać modyfikacji modelu bazy danych. O każdym zawodniku trzeba przechowywać
informacje o jego osiągnięciach w postaci wpisów do osobnej tabeli (np. rok i zdarzenie) przy
założeniu, że jeden zawodnik może mieć kilka wpisów. Wpisy dotyczą historii zawodnika (np.
zmiana barw klubowych, wyniki sportowe). Dokonać odpowiedniej modyfikacji relacji między
tabelami poprzez napisanie skryptu realizującego te modyfikacje. Wprowadzić przykładowe
dane dla kilku zawodników i napisać zdanie wybierające informacje z bazy przy uwzględnieniu
nowej tabeli.

```sql
drop table BD3_ZAWODNICY_OSIAGNIECIA;

create table BD3_ZAWODNICY_OSIAGNIECIA
    (
        ID_OSIAGNIECIA number primary key,
        NR_ZAWODNIKA number references BD3_ZAWODNICY(NR_ZAWODNIKA),
        OSIAGNIECIE_DATA date not null,
        OSIAGNIECIE_INFO text not null
    )
```

08. Dokonać modyfikacji modelu bazy danych tak, aby niemożliwe było zarejestrowanie zawodnika
bez przynależności klubowej. Utworzyć fikcyjny klub o nazwie Niezrzeszeni i w nim umieścić
dotychczasowych zawodników bez przydziału.

```sql
insert into BD3_KLUBY (NR_KLUBU, NAZWA_KLUBU) values (0, 'Niezrzeszeni');

update BD3_ZAWODNICY set NR_KLUBU = 0 where NR_KLUBU IS NULL;

alter table BD3_ZAWODNICY modify (NR_KLUBU default 0 not null);
```

09. Dokonać modyfikacji modelu bazy danych polegającej na konieczności automatycznego
rejestrowania osoby i czasu wprowadzenia danych o zawodniku do ewidencji oraz ewentualnej
ich modyfikacji. Należy wykorzystać systemowe funkcje USER i SYSDATE.

10. W procesie wczytywania danych do tabel z plików płaskich przy pomocy SQL Developer można
było utworzyć skrypt zawierający kompletne zdania insert wybierając metodę Insert Script.
Skrypty te były tworzone automatycznie w odpowiednim folderze systemu operacyjnego
(c:\users\%user%\AppData\Local\Temp). Należy, na ich podstawie utworzyć jeden zbiorczy
skrypt zawierający wszystkie zdania insert niezbędne do wprowadzenia danych do wszystkich
tabel, zakończyć go zatwierdzeniem transakcji oraz zdaniem sprawdzającym zawartość tabel.
Nazwać tak powstały skrypt lab_BD3_populate.sql, a następnie dokonać globalnego testowania
poprawności wdrożenia przy pomocy sekwencji poleceń:

```
@c:\temp\lab_BD3_drop.sql
@c:\temp\lab_BD3_create.sql
@c:\temp\lab_BD3_populate.sql
```

