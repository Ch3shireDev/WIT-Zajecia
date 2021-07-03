/*-------------------------------------------------------*/
/* Zestaw poleceń służących realizacji Laboratorium BD1  */
/* z przedmiotu Bazy danych                              */
/*                                                       */
/* Należy wykonywać fragmenty skryptu krokowo            */
/* i obserwować tworzenie się nowych obiektów po każdym  */
/* kroku w Oracle SQL Developer                          */
/*                                                       */
/* Autor: Józef Woźniak, 2010 (2021)                     */


----------------------------------------------------
--Tworzenie struktury tabel
----------------------------------------------------

create table BD1_WYPOZYCZENIE 
(
   ID_WYPOZYCZENIA      	number(7)      not null,
   ID_CZYTELNIKA        	number(7)      null,
   ID_KSIAZKI           	varchar2(10)   null,
   DATA_WYPOZYCZENIA    	date           not null,
   STATUS_WYPOZYCZENIA  	number(1)      null,

   constraint PK_WYPOZYCZENIE primary key (ID_WYPOZYCZENIA)
);

create table BD1_CZYTELNIK 
(
   ID_CZYTELNIKA       		 number(7)      not null,
   CZYTELNIK_NAZWISKO   	 varchar2(25)   not null,
   CZYTELNIK_IMIE      		 varchar2(25)   null,
   CZYTELNIK_ADRES      	 varchar2(40)   null,
   CZYTELNIK_MIASTO     	 varchar2(20)   null,
   CZYTELNIK_KOD        	 varchar2(10)   null,
   CZYTELNIK_DATA_URODZENIA  date           not null,

   constraint PK_CZYTELNIK primary key (ID_CZYTELNIKA)
);

create table BD1_KSIAZKA 
(
   ID_KSIAZKI           	varchar2(10)     not null,
   TYTUL                	varchar2(50)     not null,
   AUTOR_NAZWISKO       	varchar2(25)     not null,
   AUTOR_IMIE           	varchar2(25)     null,
   RANKING              	number(2)        null,

   constraint PK_KSIAZKA primary key (ID_KSIAZKI)
);

---------------------------------------------------
--Tworzenie referencji
---------------------------------------------------

alter table BD1_WYPOZYCZENIE
   add constraint FK_CZYTELNIK_WYPOZYCZENIE foreign key (ID_CZYTELNIKA)
      references BD1_CZYTELNIK (ID_CZYTELNIKA);
     

alter table BD1_WYPOZYCZENIE
   add constraint FK_KSIAZKA_WYPOZYCZENIE foreign key (ID_KSIAZKI)
      references BD1_KSIAZKA (ID_KSIAZKI);

---------------------------------------------------
--Modyfikacja struktury tabel
---------------------------------------------------

alter table BD1_KSIAZKA
    add ROK_WYDANIA number(4);

alter table BD1_CZYTELNIK
    drop column CZYTELNIK_ADRES;

alter table BD1_WYPOZYCZENIE
    modify STATUS_WYPOZYCZENIA varchar2(3) DEFAULT 'WYP';  

/* kolumna STATUS_WYPOZYCZENIA przyjmuje wartości:
   WYP - książka jest wypożyczona,
   ZWR - książka zwrócona o czasie,
   POT - książka zwrócona po terminie
*/

alter table BD1_KSIAZKA
    modify RANKING check (RANKING between 1 and 10);
	
alter table BD1_KSIAZKA
    add constraint CH_KSIAZKA_RANKING check (RANKING between 1 and 10); 

alter table BD1_KSIAZKA
    drop constraint SYS_C00296602; -- odpowiednia nazwa	
---------------------------------------------------

--Wprowadzanie danych
---------------------------------------------------

insert into BD1_KSIAZKA
	(ID_KSIAZKI, TYTUL, AUTOR_NAZWISKO, AUTOR_IMIE, RANKING)
values
	(1205,'W pustyni i w puszczy','Sienkiewicz','Henryk',10);

select * from BD1_KSIAZKA;

insert into BD1_CZYTELNIK
values
	(1,'Szewczyk','Katarzyna','ul. Kwitnąca 15','Łódź','12-456','1989/02/23');

select * from BD1_CZYTELNIK;

insert into BD1_WYPOZYCZENIE
	(ID_WYPOZYCZENIA, ID_CZYTELNIKA, ID_KSIAZKI, DATA_WYPOZYCZENIA)
values
	(15,1,1205,'2021/01/28');

select * from BD1_WYPOZYCZENIE;

----------------------------------------------------

--Modyfikacja danych
----------------------------------------------------

update BD1_CZYTELNIK
  set CZYTELNIK_KOD = '05-456',
      CZYTELNIK_NAZWISKO = 'Malinowska'
where ID_CZYTELNIKA = 1;

update BD1_WYPOZYCZENIE
  set STATUS_WYPOZYCZENIA = 'ZWR'
where ID_KSIAZKI = 1205;

----------------------------------------------------

--Usuwanie danych
----------------------------------------------------

delete BD1_CZYTELNIK
where ID_CZYTELNIKA = 1;

delete BD1_KSIAZKA
where AUTOR_NAZWISKO = 'Sienkiewicz';

---------------------------------------------------

--Zatwierdzanie transakcji
---------------------------------------------------

select * from BD1_KSIAZKA;
select * from BD1_CZYTELNIK;
select * from BD1_WYPOZYCZENIE;

rollback;

--Odczytać zawartość tabel
--Ponownie wprowadzić dane do tabel
--Odczytać zawartość tabel

commit;

--Odczytać zawartość tabel

rollback;

--Odczytać zawartość tabel

----------------------------------------------------

--Zmiana nazwy tabeli
----------------------------------------------------
rename BD1_CZYTELNIK to BD1_CZYTELNIK_ZMIANA;

rename BD1_CZYTELNIK_ZMIANA to BD1_CZYTELNIK;


---------------------------------------------------

--Usuwanie tabel
---------------------------------------------------

drop table BD1_WYPOZYCZENIE cascade constraints;
drop table BD1_KSIAZKA cascade constraints;
drop table BD1_CZYTELNIK cascade constraints;

---------------------------------------------------