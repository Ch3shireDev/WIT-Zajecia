/*-------------------------------------------------------*/
/* Zestaw poleceń służących realizacji Laboratorium BD2  */
/* z przedmiotu Bazy danych                              */
/*                                                       */
/*                                                       */
/*Autor: Józef Woźniak, 2008-2009, 2015-2016, 2018       */

----------------------------------------
--
-- Kasowanie tabeli (opcjonalnie)
--
----------------------------------------

drop table BD2_zbiorcza cascade constraints;

----------------------------------------
--
-- Założenie tabeli
--
----------------------------------------

create table BD2_ZBIORCZA 
(
    nr_zawodow			number(2)
   ,nr_zawodnika		number(4)
   ,imie				varchar2(15)                
   ,nazwisko			varchar2(30)	not null
   ,plec				varchar2(1)		not null
   ,rok_urodzenia		number(4)                   
   ,nr_klubu			number(3)		not null
   ,klub				varchar2(40)	not null
   ,kategoria			varchar2(6)		
   ,pkt_generalna		number(2)                  
   ,pkt_kategorie		number(2)                   
   ,constraint PK_ZBIORCZA primary key (nr_zawodow, nr_zawodnika)
);

alter table BD2_ZBIORCZA
	add constraint CH_PKT_GENERALNA check (pkt_generalna between 1 and 50);
	
alter table BD2_ZBIORCZA
	add constraint CH_PKT_KATEGORIE check (pkt_kategorie between 1 and 50);	
	
alter table BD2_ZBIORCZA
	add constraint CH_PLEC check (plec in ('M', 'K'));



