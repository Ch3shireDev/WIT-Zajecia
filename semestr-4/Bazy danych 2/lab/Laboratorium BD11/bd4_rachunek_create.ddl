/************************************

Skrypt przygotowujący schemat bazodanowy
do nauki Oracle Application Express

opr.: Józef Woźniak (2020)
*************************************/


CREATE SEQUENCE seq_klient START WITH 10 INCREMENT BY 1 NOCACHE;

CREATE SEQUENCE seq_produkt START WITH 20 INCREMENT BY 1 NOCACHE;

CREATE SEQUENCE seq_rachunek START WITH 100 INCREMENT BY 1 NOCACHE;


CREATE TABLE bd4_klient (
    nr_klienta            NUMBER(4),
    klient_nazwisko       VARCHAR2(30) NOT NULL,
    klient_imie           VARCHAR2(15),
    klient_adres          VARCHAR2(50),
    klient_miasto         VARCHAR2(20) NOT NULL,
    klient_kod_adresowy   VARCHAR2(6) NOT NULL
);

ALTER TABLE bd4_klient ADD CONSTRAINT bd4_klient_pk PRIMARY KEY ( nr_klienta );

CREATE TABLE bd4_produkt (
    nr_produktu      NUMBER(5),
    nazwa_produktu   VARCHAR2(20) NOT NULL,
    cena_produktu    NUMBER(8, 2) NOT NULL,
    rok_produkcji    NUMBER(4),
    ranking          NUMBER(2)
);

COMMENT ON COLUMN bd4_produkt.ranking IS
    '1 – produkt bardzo zły,
	 10 - produkt bardzo dobry';

ALTER TABLE bd4_produkt ADD CONSTRAINT bd4_produkt_pk PRIMARY KEY ( nr_produktu );

CREATE TABLE bd4_rachunek (
    nr_rachunku      NUMBER(5),
    data_sprzedazy   DATE NOT NULL,
    ilosc_produktu   NUMBER(3) NOT NULL,
    nr_produktu      NUMBER(5) NOT NULL,
    nr_klienta       NUMBER(4) NOT NULL,
	cena_zakupu 	 NUMBER(8,2) NOT NULL,
	wartosc 		 NUMBER(8,2) NOT NULL
);

ALTER TABLE bd4_rachunek ADD CONSTRAINT bd4_rachunek_pk PRIMARY KEY ( nr_rachunku );

ALTER TABLE bd4_rachunek
    ADD CONSTRAINT bd4_klient_fk FOREIGN KEY ( nr_klienta )
        REFERENCES bd4_klient ( nr_klienta );

ALTER TABLE bd4_rachunek
    ADD CONSTRAINT bd4_produkt_fk FOREIGN KEY ( nr_produktu )
        REFERENCES bd4_produkt ( nr_produktu )
            ON DELETE CASCADE;
---------------------------------------
