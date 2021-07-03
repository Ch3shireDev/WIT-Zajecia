# BD2 LAB 02

## Zadania do samodzielnego wykonania

### Działania na tabeli BD2_ZBIORCZA_TEMP

1. Zmodyfikować plik `lab_BD2_dane.csv` poprzez wprowadzenie na początku nazw kolumn (zgodnych z nazwami kolumn w tabeli lub też nie) i przeprowadzić proces ładowania danych do tabeli `BD2_ZBIORCZA_TEMP`, która ma mieć dokładnie taką samą strukturę jak tabela `BD2_ZBIORCZA`.

```sql
drop table BD2_zbiorcza cascade constraints;

create table BD2_ZBIORCZA 
(
    nr_zawodow			number(2),
    nr_zawodnika		number(4),
    imie				varchar2(15),            
    nazwisko			varchar2(30)	not null,
    plec				varchar2(1)		not null,
    rok_urodzenia		number(4),
    nr_klubu			number(3)		not null,
    klub				varchar2(40)	not null,
    kategoria			varchar2(6),
    pkt_generalna		number(2),       
    pkt_kategorie		number(2),
    constraint PK_ZBIORCZA primary key (nr_zawodow, nr_zawodnika)
);

alter table BD2_ZBIORCZA
	add constraint CH_PKT_GENERALNA check (pkt_generalna between 1 and 50);
	
alter table BD2_ZBIORCZA
	add constraint CH_PKT_KATEGORIE check (pkt_kategorie between 1 and 50);	
	
alter table BD2_ZBIORCZA
	add constraint CH_PLEC check (plec in ('M', 'K'));
```

2. W tabeli `BD2_ZBIORCZA_TEMP` zmienić kolumnę plec tak, aby zawierała wartości odpowiednio Kobieta lub Mężczyzna zamiast dotychczasowych K i M, a nazwę kolumny zmienić na plec_nazwa. Po przeprowadzeniu niezbędnych modyfikacji zdaniem update przetestować ich skuteczność (w kolumnie określającej płeć mogą być tylko wartości Kobieta lub Mężczyzna).

```sql

create table BD2_ZBIORCZA_TEMP
(
    nr_zawodow			number(2)
   ,nr_zawodnika		number(4)
   ,imie				varchar2(15)                
   ,nazwisko			varchar2(30)	not null
   ,plec_nazwa			varchar2(11)	not null
   ,rok_urodzenia		number(4)                   
   ,nr_klubu			number(3)		not null
   ,klub				varchar2(40)	not null
   ,kategoria			varchar2(6)		
   ,pkt_generalna		number(2)                  
   ,pkt_kategorie		number(2)                   
   ,constraint PK_ZBIORCZA primary key (nr_zawodow, nr_zawodnika)
);

alter table BD2_ZBIORCZA_TEMP
	add constraint CH_PKT_GENERALNA check (pkt_generalna between 1 and 50);
	
alter table BD2_ZBIORCZA_TEMP
	add constraint CH_PKT_KATEGORIE check (pkt_kategorie between 1 and 50);	
	
alter table BD2_ZBIORCZA_TEMP
	add constraint CH_PLEC_NAZWA check (plec_nazwa in ('Mężczyzna', 'Kobieta'));

insert into BD2_ZBIORCZA_TEMP select    
    nr_zawodow,
    nr_zawodnika,
    imie,
    nazwisko,
    CASE WHEN plec = 'M' then 'Mężczyzna' else 'Kobieta' END as ALIAS,
    rok_urodzenia,
    nr_klubu,
    klub,
    kategoria,
    pkt_generalna,
    pkt_kategorie 
from BD2_ZBIORCZA

```

3. W tabeli `BD2_ZBIORCZA_TEMP` zmodyfikować kolumnę pkt_kategorie tak, aby konieczne było wprowadzenie do niej wartości różnej od null (czyli, aby otrzymała atrybut not null). W miejsce dotychczas występujących wartości null wstawić 0.

```sql
alter table BD2_ZBIORCZA_TEMP modify pkt_kategorie default 0 not null;
```

### Działania na tabeli BD2_ZBIORCZA

Zaprojektować zdania SQL generujące zbiory wynikowe przy następujących założeniach:
1. Mężczyźni urodzeni po 1975 roku i należący do klubów o numerach między 3 i 10. Uporządkowanie – według numerów klubów i roczników (malejąco).

```sql
select distinct IMIE, NAZWISKO, NR_KLUBU, ROK_URODZENIA from BD2_ZBIORCZA where ROK_URODZENIA > 1975 and NR_KLUBU BETWEEN 3 and 10 and PLEC = 'M' order by NR_KLUBU DESC, ROK_URODZENIA DESC
```

2. Zawodnicy, których nazwisko kończy się na ‘ski’ lub ‘ska’ należący do jednej z kategorii (I, II, K-II, K-V). Uporządkowanie – na początku kobiety, a potem mężczyźni, a w ramach płci alfabetycznie.

```sql
select distinct IMIE, NAZWISKO, KATEGORIA, PLEC from BD2_ZBIORCZA where ( NAZWISKO like '%ski' or NAZWISKO like '%ska' ) and KATEGORIA in ( 'I', 'II', 'K-II', 'K-V')   order by PLEC, NAZWISKO
```

3. Zawodnicy należący do klubu ‘KB Gymnasion Warszawa', którzy nie zdobyli punktów w klasyfikacji generalnej. Uporządkowanie - według kategorii wiekowej i nazwisk.

```sql
select distinct IMIE, NAZWISKO, PKT_GENERALNA, KLUB from BD2_ZBIORCZA where KLUB = 'KB Gymnasion Warszawa' and pkt_generalna is null order by kategoria, nazwisko
```

4. Zawodnicy, którzy nie zdobyli punktów w klasyfikacji kategoriami i należą do kategorii (II, III, V). Uporządkowanie – według kategorii, klubów i aliasu stanowiącego połączenie Nazwiska i imienia.

```sql
select distinct  NAZWISKO || ' ' ||  IMIE AS NAZW_IMIE, KATEGORIA, PKT_KATEGORIE, KLUB from BD2_ZBIORCZA where KATEGORIA in ('II', 'III', 'V') and PKT_KATEGORIE is null order by KATEGORIA, KLUB, NAZW_IMIE
```
