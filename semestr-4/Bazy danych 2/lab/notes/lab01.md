# BD2 LAB 01

## Zadania do samodzielnego wykonania

### Działanie na modelu Biblioteka

1. Utworzyć w swoim schemacie tabele modelu relacyjnego Biblioteka przy pomocy skryptu
lab_BD1_ver2.sql metodą `@c:\temp\lab_BD1_ver2.sql` . Wypełnić tabele przykładowymi
danymi wykorzystując wszystkie postacie zdanie insert. Układ danych powinien zapewnić
obserwację relacji 1: N czyli jedna książka była wypożyczona wiele razy oraz jeden czytelnik
kilka razy przychodził do biblioteki w celu wypożyczenia książek.

```sql
DROP TABLE BD1_WYPOZYCZENIE cascade constraints;
DROP TABLE BD1_CZYTELNIK cascade constraints;
DROP TABLE BD1_KSIAZKA cascade constraints;

create table BD1_CZYTELNIK (
    ID_CZYTELNIKA NUMBER(7) PRIMARY KEY,
    CZYTELNIK_NAZWISKO VARCHAR2(25) NOT NULL,
    CZYTELNIK_IMIE VARCHAR2(25),
    CZYTELNIK_ADRES VARCHAR2(40),
    CZYTELNIK_MIASTO VARCHAR2(25),
    CZYTELNIK_KOD VARCHAR2(10),
    CZYTELNIK_DATA_URODZENIA DATE NOT NULL
);

create table BD1_KSIAZKA (
    ID_KSIAZKI VARCHAR2(10) PRIMARY KEY,
    TYTUL VARCHAR2(50),
    AUTOR_NAZWISKO VARCHAR2(25),
    AUTOR_IMIE VARCHAR2(25),
    RANKING NUMBER(2) NULL check (RANKING between 1 and 10)
);

create table BD1_WYPOZYCZENIE (
    ID_WYPOZYCZENIA NUMBER(7) PRIMARY KEY,
    ID_CZYTELNIKA NUMBER(7) REFERENCES BD1_CZYTELNIK (ID_CZYTELNIKA),
    ID_KSIAZKI VARCHAR2(10) REFERENCES BD1_KSIAZKA (ID_KSIAZKI),
    DATA_WYPOZYCZENIA DATE,
    STATUS_WYPOZYCZENIA NUMBER(1)
);

insert into BD1_CZYTELNIK (id_czytelnika, czytelnik_nazwisko, czytelnik_data_urodzenia) values (1, 'Nowicki', TO_DATE('1989/02/23', 'YYYY/MM/DD'));
insert into BD1_CZYTELNIK (id_czytelnika, czytelnik_nazwisko, czytelnik_data_urodzenia) values (2, 'Kowalski', TO_DATE('1989/01/25', 'YYYY/MM/DD'));
insert into BD1_CZYTELNIK (id_czytelnika, czytelnik_nazwisko, czytelnik_data_urodzenia) values (3, 'Stefanik', TO_DATE('1995/05/17', 'YYYY/MM/DD'));

insert into BD1_KSIAZKA (ID_KSIAZKI, TYTUL) values ('aaa', 'W pustyni i w puszczy');
insert into BD1_KSIAZKA (ID_KSIAZKI, TYTUL) values ('aab', 'Necronomicon');
insert into BD1_KSIAZKA (ID_KSIAZKI, TYTUL) values ('aac', 'Kopytka w sosie');

insert into BD1_WYPOZYCZENIE (ID_WYPOZYCZENIA, ID_CZYTELNIKA, ID_KSIAZKI) values (1, 1, 'aaa');
insert into BD1_WYPOZYCZENIE (ID_WYPOZYCZENIA, ID_CZYTELNIKA, ID_KSIAZKI) values (2, 1, 'aab');
```

2. Na tak skonfigurowanym modelu z danymi dokonać modyfikacji struktury poprzez zapewnienie
poprawności rejestrowania wypożyczeń. Struktura tabeli WYPOZYCZENIA dopuszcza
możliwość rejestrowania transakcji bez określenia numeru wypożyczonej książki. Należy to
zmienić.

```sql
ALTER TABLE BD1_WYPOZYCZENIE MODIFY ( ID_CZYTELNIKA NOT NULL);
ALTER TABLE BD1_WYPOZYCZENIE MODIFY ( ID_KSIAZKI NOT NULL);
```

3. Dokonać modyfikacji danych w dwóch wariantach. Pierwszy - modyfikacji podlega jeden wiersz
(modyfikacja w oparciu o klucz główny), a drugi - modyfikacji podlega zbiór wierszy, ale nie
wszystkie.

```sql
UPDATE BD1_KSIAZKA set RANKING=10 where ID_KSIAZKI='aaa';
UPDATE BD1_KSIAZKA set RANKING=9 where ID_KSIAZKI!='aaa';
```

4. Zaprezentować skuteczność lub nie kasowania wiersza nadrzędnego w dwóch wariantach.
Pierwszy - wiersz nadrzędny jest w relacji z wierszami podrzędnymi, a drugi - nie jest.

```sql
delete from bd1_ksiazka where id_ksiazki = 'aaa'; -- powoduje błąd wykonania, bo jest relacja wypożyczenia
delete from bd1_ksiazka where id_ksiazki = 'aac'; -- nie powoduje błędu, nie ma relacji wypożyczenia
```

### Tworzenie nowego modelu

1. Zaprojektować prosty model bazy danych składający się z trzech tabel i odzwierciedlający
ewidencję studentów uczelni z uwzględnieniem podziału na rodzaj studiowania i kierunki
studiów.

* Tabela `BD1_Student` – zawierająca dane studenta, 
* Tabela `BD1_Kierunki_Studiow` – zawierająca nazwy kierunków (Informatyka, Psychologia, ...), 
* Tabela `BD1_Rodzaj_Studiow` – zawierająca nazwy sposobów studiowania (Dzienne, Zaoczne, Indywidualne, Podyplomowe, MBA).

Tabele `BD1_Kierunki_Studiow` oraz `BD1_Rodzaj_Studiow` są klasycznymi tabelami
słownikowymi. Na ogół struktura takich tabel zawiera dwie kolumny: kod i opis:

```sql
(
kod varchar2(3) primary key
, opis varchar2(100)
); 
```

Tabele takie często są używane w systemach bazodanowych do przechowywania
danych stałych, na przykład mogą to być zbiory nazw województw, nazw walut, 
komórek organizacyjnych itp. Kolumna stanowiąca klucz główny może być typu
varchar2 (ale zdecydowanie krótsza niż kolumna stanowiąca opis obiektu) lub typu
numerycznego.

Tabelę `BD1_Student` należy traktować jako tabelę dynamiczną (transakcyjną).

```sql
DROP TABLE BD1_KIERUNKI_STUDIOW;
DROP TABLE BD1_RODZAJ_STUDIOW;
DROP TABLE BD1_STUDENT;

CREATE TABLE BD1_KIERUNKI_STUDIOW ( KOD VARCHAR2(3) PRIMARY KEY, OPIS VARCHAR2(100));
CREATE TABLE BD1_RODZAJ_STUDIOW ( KOD VARCHAR2(3) PRIMARY KEY, OPIS VARCHAR2(100));
CREATE TABLE BD1_STUDENT ( 
    ID_STUDENTA NUMBER PRIMARY KEY,
    STUDENT_IMIE VARCHAR2(32),
    STUDENT_NAZWISKO VARCHAR2(32),
    STUDENT_DATA_URODZENIA DATE,
    STUDENT_MIASTO_URODZENIA VARCHAR2(32),
    STUDENT_KRAJ_URODZENIA VARCHAR2(32),
    STUDENT_MIASTO_ZAMIESZKANIA VARCHAR2(32),
    STUDENT_KOD_POCZTOWY VARCHAR2(10),
    KIERUNEK_STUDIOW VARCHAR2(3),
    RODZAJ_STUDIOW VARCHAR2(3)
    );

```

2. Zdefiniować klucze główne oraz klucze obce określające relacje między tabelami:

Relacje: 
* student studiuje na określonym kierunku, 
* student studiuje określonym sposobem studiowania.

```sql
alter table BD1_STUDENT add constraint FK_STUDENT_KIERUNEK foreign key (KIERUNEK_STUDIOW) references BD1_KIERUNKI_STUDIOW (KOD);
alter table BD1_STUDENT add constraint FK_STUDENT_RODZAJ foreign key (RODZAJ_STUDIOW) references BD1_RODZAJ_STUDIOW (KOD);
```

3. Na tak zbudowanym modelu przećwiczyć wprowadzanie danych do tabel, ich modyfikacje
oraz usuwanie na różne sposoby (zdania insert, update, delete).

```sql

INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('INF', 'Informatyka');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('PSY', 'Psychologia');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('FIZ', 'Fizyka');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('MAT', 'Matematyka');

INSERT INTO BD1_RODZAJ_STUDIOW values ('DZI', 'Dzienne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('ZAO', 'Zaoczne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('IND', 'Indywidualne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('POD', 'Podyplomowe');
INSERT INTO BD1_RODZAJ_STUDIOW values ('MBA', 'Podyplomowe dla kadry menadżerskiej');

INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (1, 'Nowicki', 'INF', 'ZAO');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (2, 'Kowalski', 'MAT', 'DZI');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (3, 'Chojnacki', 'PSY', 'POD');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (4, 'Brzeziński', 'INF', 'IND');

DELETE FROM BD1_STUDENT WHERE ID_STUDENTA = 4;

UPDATE BD1_STUDENT SET STUDENT_IMIE = 'Igor' where ID_STUDENTA = 1;

```

4. Przećwiczyć skuteczność działania klucza obcego w celu utrzymania spójności bazy
danych (np. poprzez wprowadzenie do ewidencji studenta, który studiuje na kierunku, 
którego brak w ewidencji kierunków oraz skasowanie z tabeli kierunków studiów pozycji, 
w przypadku gdy na ten kierunek są zapisani studenci).

```sql
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (4, 'Kowal', 'INF', 'XXX');
-- ORA-02291: integrity constraint (NOWICKII.FK_STUDENT_RODZAJ) violated - parent key not found

DELETE FROM BD1_RODZAJ_STUDIOW WHERE KOD = 'DZI';
-- ORA-02292: integrity constraint (NOWICKII.FK_STUDENT_RODZAJ) violated - child record found
```

5. Zmodyfikować model bazy danych poprzez wprowadzenie do jednej z tabel nowej kolumny
(np. do tabeli kierunków studiów kolumnę określającą datę uruchomienia danego kierunku)
i uzupełnić tę kolumnę danymi (zrobić to na dwa sposoby: wszystkie wiersze na raz oraz
wybiórczo).

```sql
alter table BD1_KIERUNKI_STUDIOW add DATA_OTWARCIA date default current_date not null;

update BD1_KIERUNKI_STUDIOW set DATA_OTWARCIA=TO_DATE('1991/09/01', 'YYYY/MM/DD') WHERE KOD = 'INF';
```

6. Sprawdzić czy jest możliwość zmiany struktury tabeli poprzez zmianę wielkości wybranej
kolumny w przypadku, gdy jest ona wypełniona (np. kolumna Nazwisko w tabeli
BD1_Student). Należy zwiększyć rozmiar kolumny np. do 100 i zmniejszyć np. do 5.

```sql
alter table BD1_STUDENT modify STUDENT_NAZWISKO varchar2(100);

alter table BD1_STUDENT modify STUDENT_NAZWISKO varchar2(3); 
-- ORA-01441: cannot decrease column length because some value is too big
```

7. Utworzyć dwa skrypty. Pierwszy (np. create_BD1.sql) zawierający zdania tworzące obiekty
bazodanowe i zdania wprowadzające testowe dane do tabel oraz drugi (np. drop_BD1.sql)
usuwający wszystkie tabele opracowanego modelu bazy danych.

```sql
-- create_BD1.sql

CREATE TABLE BD1_KIERUNKI_STUDIOW ( KOD VARCHAR2(3) PRIMARY KEY, OPIS VARCHAR2(100));
CREATE TABLE BD1_RODZAJ_STUDIOW ( KOD VARCHAR2(3) PRIMARY KEY, OPIS VARCHAR2(100));
CREATE TABLE BD1_STUDENT ( 
    ID_STUDENTA NUMBER PRIMARY KEY,
    STUDENT_IMIE VARCHAR2(32),
    STUDENT_NAZWISKO VARCHAR2(32),
    STUDENT_DATA_URODZENIA DATE,
    STUDENT_MIASTO_URODZENIA VARCHAR2(32),
    STUDENT_KRAJ_URODZENIA VARCHAR2(32),
    STUDENT_MIASTO_ZAMIESZKANIA VARCHAR2(32),
    STUDENT_KOD_POCZTOWY VARCHAR2(10),
    KIERUNEK_STUDIOW VARCHAR2(3),
    RODZAJ_STUDIOW VARCHAR2(3)
    );

INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('INF', 'Informatyka');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('PSY', 'Psychologia');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('FIZ', 'Fizyka');
INSERT INTO BD1_KIERUNKI_STUDIOW VALUES ('MAT', 'Matematyka');

INSERT INTO BD1_RODZAJ_STUDIOW values ('DZI', 'Dzienne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('ZAO', 'Zaoczne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('IND', 'Indywidualne');
INSERT INTO BD1_RODZAJ_STUDIOW values ('POD', 'Podyplomowe');
INSERT INTO BD1_RODZAJ_STUDIOW values ('MBA', 'Podyplomowe dla kadry menadżerskiej');

INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (1, 'Nowicki', 'INF', 'ZAO');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (2, 'Kowalski', 'MAT', 'DZI');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (3, 'Chojnacki', 'PSY', 'POD');
INSERT INTO BD1_STUDENT (ID_STUDENTA, STUDENT_NAZWISKO, KIERUNEK_STUDIOW, RODZAJ_STUDIOW) VALUES (4, 'Brzeziński', 'INF', 'IND');

alter table BD1_STUDENT add constraint FK_STUDENT_KIERUNEK foreign key (KIERUNEK_STUDIOW) references BD1_KIERUNKI_STUDIOW (KOD);
alter table BD1_STUDENT add constraint FK_STUDENT_RODZAJ foreign key (RODZAJ_STUDIOW) references BD1_RODZAJ_STUDIOW (KOD);
```

```sql
-- drop_BD1.sql

DROP TABLE BD1_KIERUNKI_STUDIOW;
DROP TABLE BD1_RODZAJ_STUDIOW;
DROP TABLE BD1_STUDENT;
```

8. Usunąć jedną z referencji między tabelami i przetestować tego skutki poprzez wprowadzanie danych umożliwiających osiągnięcie przez bazę danych stanu niespójności. Odpowiednimi zdaniami SQL doprowadzić z powrotem do spójności bazy danych.

```sql
alter table BD1_STUDENT drop constraint FK_STUDENT_KIERUNEK;
update BD1_STUDENT set KIERUNEK_STUDIOW='XXX' where ID_STUDENTA=4;

alter table BD1_STUDENT add constraint FK_STUDENT_KIERUNEK foreign key (KIERUNEK_STUDIOW) references BD1_KIERUNKI_STUDIOW (KOD);
-- ORA-02298: cannot validate (NOWICKII.FK_STUDENT_KIERUNEK) - parent keys not found
-- 02298. 00000 - "cannot validate (%s.%s) - parent keys not found"
-- *Cause:    an alter table validating constraint failed because the table has
--            child records.
-- *Action:   Obvious

update BD1_STUDENT set KIERUNEK_STUDIOW='INF' where ID_STUDENTA=4;
alter table BD1_STUDENT add constraint FK_STUDENT_KIERUNEK foreign key (KIERUNEK_STUDIOW) references BD1_KIERUNKI_STUDIOW (KOD);
```