--
-- PostgreSQL database dump
--

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: osoba; Type: TABLE; Schema: public; Owner: alex; Tablespace: 
--

CREATE TABLE osoba (
    osobaid integer DEFAULT nextval('osobaseq'::regclass) NOT NULL,
    nazwisko character varying(64),
    imie character varying(32),
    pesel character varying(11),
    adres character varying(96)
);


ALTER TABLE osoba OWNER TO alex;

--
-- Data for Name: osoba; Type: TABLE DATA; Schema: public; Owner: alex
--

INSERT INTO osoba VALUES (1, 'Piotrowski', 'Kacper', '52092415087', 'ul. Piotrowska 198/30');
INSERT INTO osoba VALUES (2, 'Mazur', 'Nikodem', '59120470985', 'ul. Mazura 134/19');
INSERT INTO osoba VALUES (3, 'Żak', 'Filip', '71052429998', 'ul. Żaka 80/104');
INSERT INTO osoba VALUES (4, 'Kubiak', 'Piotr', '73062867999', 'ul. Kubiaka 94/23');
INSERT INTO osoba VALUES (5, 'Czajka', 'Kamil', '87021944928', 'ul. Czajka 136/121');
INSERT INTO osoba VALUES (6, 'Sadowska', 'Maja', '87092258279', 'ul. Sadowska 160/14');
INSERT INTO osoba VALUES (7, 'Wiśniewska', 'Julia', '87111374896', 'ul. Wiśniewska 158/97');
INSERT INTO osoba VALUES (8, 'Michalski', 'Krzysztof', '91031598063', 'ul. Michalska 6/31');
INSERT INTO osoba VALUES (9, 'Kozak', 'Daniel', '94071293582', 'ul. Kozaka 188/32');
INSERT INTO osoba VALUES (10, 'Sawicka', 'Maja', '90040414249', 'ul. Sawicka 137/9');
INSERT INTO osoba VALUES (11, 'Rutkowska', 'Oliwia', '84090189407', 'ul. Rutkowska 186/67');
INSERT INTO osoba VALUES (12, 'Adamczyk', 'Hubert', '84091440499', 'ul. Adamczyka 137/99');
INSERT INTO osoba VALUES (13, 'Adamczyk', 'Liliana', '81041679389', 'ul. Adamczyka 17/43');
INSERT INTO osoba VALUES (14, 'Michalik', 'Grzegorz', '90101966966', 'ul. Michalika 1/135');
INSERT INTO osoba VALUES (15, 'Kalinowska', 'Alicja', '81080516011', 'ul. Kalinowska 133/5');
INSERT INTO osoba VALUES (16, 'Czyż', 'Aleksander', '92102784149', 'ul. Czyża 102/20');
INSERT INTO osoba VALUES (17, 'Mucha', 'Krzysztof', '82052506819', 'ul. Mucha 1/26');
INSERT INTO osoba VALUES (18, 'Marcinkowska', 'Amelia', '92102722242', 'ul. Marcinkowska 121/43');
INSERT INTO osoba VALUES (19, 'Sikora', 'Natalia', '85120170482', 'ul. Sikora 54/95');
INSERT INTO osoba VALUES (20, 'Kowalczyk', 'Kacper', '80080776168', 'ul. Kowalczyka 136/139');
INSERT INTO osoba VALUES (21, 'Wróbel', 'Antoni', '92111179646', 'ul. Wróbela 61/97');
INSERT INTO osoba VALUES (22, 'Lewandowski', 'Grzegorz', '81021919558', 'ul. Lewandowska 10/123');
INSERT INTO osoba VALUES (23, 'Rybak', 'Krystian', '93070328840', 'ul. Rybaka 123/12');
INSERT INTO osoba VALUES (24, 'Sosnowska', 'Julia', '91030245632', 'ul. Sosnowska 162/54');
INSERT INTO osoba VALUES (26, 'Barski', 'Aleksy', '5435', 'dfsgdhgkjdfhjgds fgkldfjklgdfjklg fdkgjdfl');


--
-- Name: osoba_nazwisko_imie_key; Type: CONSTRAINT; Schema: public; Owner: alex; Tablespace: 
--

ALTER TABLE ONLY osoba
    ADD CONSTRAINT osoba_nazwisko_imie_key UNIQUE (nazwisko, imie);


--
-- Name: osoba_pesel_key; Type: CONSTRAINT; Schema: public; Owner: alex; Tablespace: 
--

ALTER TABLE ONLY osoba
    ADD CONSTRAINT osoba_pesel_key UNIQUE (pesel);


--
-- Name: osoba_pkey; Type: CONSTRAINT; Schema: public; Owner: alex; Tablespace: 
--

ALTER TABLE ONLY osoba
    ADD CONSTRAINT osoba_pkey PRIMARY KEY (osobaid);


--
-- PostgreSQL database dump complete
--

