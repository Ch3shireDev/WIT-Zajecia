REM INSERTING into BD5_KLIENT

Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Kowalski','Jan','jan.kowalski@kowalski.pl','Warszawa','01-578','ul. Strumykowa 15 / 60');
Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Nowak','Adam','adam.nowak@nowak.pl','Kraków','31-879','ul. Kwiatowa 12 / 5');
Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Boczyński','Edward','edward.boczynski@boczynski.pl','Warszawa','01-237','ul. Spokojna 56');
Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Walecki ','Franciszek','franciszek.walecki@walecki.pl','Kraków','31-769','ul. Słoneczna 4 / 6');
Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Misiowiec','Jacek','jacek.misiowiec@misiowiec.pl','Łódź','90-019','pl. Miejski 14');
Insert into BD5_KLIENT (NR_KLIENTA,NAZWISKO,IMIE,MAIL,MIEJSCOWOSC,KOD_POCZTOWY,ADRES) values (bd5_klient_seq.nextval,'Polewski','Zbigniew','zbigniew.polewski@polewski.pl','Łódź','90-019','ul. Zgody 17 / 16');

REM INSERTING into BD5_PRODUKT

Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('POL_M','Koszulka polo',150);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('SP_M','Spodnie',180);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('ZA_K','Żakiet',150);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('BL_K','Bluzka',60);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('SP_K','Spódnica',80);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('BUT_K','Buty damskie',120);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('PAS_M','Pasek do spodni',30);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('TOR_K','Torebka',125);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('BUT_M','Buty męskie',110);
Insert into BD5_PRODUKT (KOD_PRODUKTU,NAZWA_PRODUKTU,CENA_KATALOGOWA) values ('POR_M','Portfel',50);

REM INSERTING into BD5_FAKTURA_NAGLOWEK

Insert into BD5_FAKTURA_NAGLOWEK (NR_FAKTURY,DATA_FAKTURY,WARTOSC_FAKTURY,NR_KLIENTA) values (1,to_date('2020/11/10','YYYY/MM/DD'),970,100);

REM INSERTING into BD5_FAKTURA_DETALE

Insert into BD5_FAKTURA_DETALE (NR_FAKTURY,POZYCJA_FAKTURY,KOD_PRODUKTU,ILOSC_PRODUKTU,CENA_ZAKUPU) values (1,1,'POL_M',5,150);
Insert into BD5_FAKTURA_DETALE (NR_FAKTURY,POZYCJA_FAKTURY,KOD_PRODUKTU,ILOSC_PRODUKTU,CENA_ZAKUPU) values (1,2,'BUT_M',2,110);
commit;