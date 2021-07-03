/*-------------------------------------------------------*/
/* Zestaw poleceń służących realizacji Laboratorium BD1  */
/* z przedmiotu Bazy danych                              */
/*                                                       */
/* Należy przeanalizować budowę skryptu i porównać go    */
/* ze skryptem lab_BD1.sql.                              */
/* Wykonać przy pomocy polecenia zawartego w sekcji      */
/* Uruchamiane skryptu.                                  */
/*                                                       */
/* Autor: Józef Woźniak, 2010 (2021)                     */

----------------------------------------------------
--Uruchamianie skryptu
----------------------------------------------------

-- @d:\temp\lab_BD1_ver2.sql

----------------------------------------------------
--Usuwanie istniejących tabel
----------------------------------------------------

drop table BD1_CZYTELNIK cascade constraints;
drop table BD1_KSIAZKA cascade constraints;
drop table BD1_WYPOZYCZENIE cascade constraints;

----------------------------------------------------
--Tworzenie struktury tabel
----------------------------------------------------

create table BD1_CZYTELNIK 
(
    ID_CZYTELNIKA       		number(7)      primary key
   ,CZYTELNIK_NAZWISKO   		varchar2(25)   not null
   ,CZYTELNIK_IMIE      		varchar2(25)
   ,CZYTELNIK_ADRES      		varchar2(40)
   ,CZYTELNIK_MIASTO     		varchar2(20)
   ,CZYTELNIK_KOD        		varchar2(10)
   ,CZYTELNIK_DATA_URODZENIA 	date      		not null
);


create table BD1_KSIAZKA 
(
    ID_KSIAZKI           	varchar2(10)     primary key
   ,TYTUL                	varchar2(50)     not null
   ,AUTOR_NAZWISKO       	varchar2(25)     not null
   ,AUTOR_IMIE           	varchar2(25)
   ,RANKING              	number(2)  		 check (RANKING between 1 and 10)
);


create table BD1_WYPOZYCZENIE 
(
    ID_WYPOZYCZENIA      	number(7)      primary key
   ,ID_CZYTELNIKA        	number(7)      not null references BD1_CZYTELNIK (ID_CZYTELNIKA)
   ,ID_KSIAZKI           	varchar2(10)   references BD1_KSIAZKA (ID_KSIAZKI)
   ,DATA_WYPOZYCZENIA    	date           not null
   ,STATUS_WYPOZYCZENIA  	number(1)
);
------------------------------------------------------------------


