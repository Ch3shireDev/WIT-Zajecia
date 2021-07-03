/*****************************************************
-- Programowy generator danych dla modelu BD4_RACHUNEK
--
-- opr. Józef Woźniak (2020)
******************************************************/

create or replace package pkg_generator_danych is

-- procedura generująca jedną transakcję poprzez generator
procedure pr_generuj_transakcje (v_data_sprzedazy date default sysdate);

-- procedura generująca wiele transakcji z jedną datą poprzez generator
procedure pr_generuj_transakcje (v_data_sprzedazy date default sysdate,
                                 v_ile number);

-- procedura generująca wiele transakcji w zadanym przedziale czasu poprzez generator 
procedure pr_generuj_transakcje (pocz_data date, konc_data date);

function fn_daj_numer_klienta return number;

function fn_daj_numer_produktu return number;

function fn_daj_ilosc_produktu (min_ilosc number default 1,
                                max_ilosc number default 10) return number;

function fn_daj_cene_produktu (v_numer_produktu number) return number;

-- funkcja losuje liczbę transakcji wygenerowanych jednej doby
function fn_daj_liczbe_transakcji(min_liczba number default 1,
                                  max_liczba number default 5) return number;                               

end pkg_generator_danych;
/
create or replace package body pkg_generator_danych as

  procedure pr_generuj_transakcje (v_data_sprzedazy date default sysdate) as
    v_nr_rachunku number default seq_rachunek.nextval;
    v_nr_klienta number default fn_daj_numer_klienta();
    v_nr_produktu number default fn_daj_numer_produktu();
    v_ilosc_produktu number default fn_daj_ilosc_produktu (1, 10);
    v_cena_produktu number default fn_daj_cene_produktu (v_nr_produktu);
    v_wartosc number default v_cena_produktu * v_ilosc_produktu;
  begin
	insert into bd4_rachunek values (v_nr_rachunku, v_data_sprzedazy,
                        v_ilosc_produktu, v_nr_produktu, v_nr_klienta,
                        v_cena_produktu, v_wartosc);
    commit;                        
  end pr_generuj_transakcje;

  procedure pr_generuj_transakcje (v_data_sprzedazy date default sysdate,
                                   v_ile number) as
  begin
    for i in 1..v_ile 
    loop
     pr_generuj_transakcje (v_data_sprzedazy);
    end loop;
  end pr_generuj_transakcje;

  procedure pr_generuj_transakcje (pocz_data date, konc_data date) as
  cur_date date;
  begin
    cur_date := pocz_data;
	while cur_date <= konc_data
	  loop
	     pkg_generator_danych.pr_generuj_transakcje 
					(v_data_sprzedazy => cur_date,
					 v_ile =>  fn_daj_liczbe_transakcji);
	    cur_date := cur_date + 1;
	end loop;

  end pr_generuj_transakcje;

  function fn_daj_numer_klienta return number as
  v_nr_klienta number;
  begin
    select * into v_nr_klienta 
    from (
            select nr_klienta from  bd4_klient
            order by dbms_random.value)
    where rownum = 1;

    return v_nr_klienta;
  end fn_daj_numer_klienta;

  function fn_daj_numer_produktu return number as
  v_nr_produktu number;
  begin
    select * into v_nr_produktu 
    from (
            select nr_produktu from  bd4_produkt
            order by dbms_random.value)
    where rownum = 1;

    return v_nr_produktu;
  end fn_daj_numer_produktu;

  function fn_daj_ilosc_produktu (min_ilosc number default 1,
                                  max_ilosc number default 10) return number as
  v_ilosc number;
  begin
    select round ( dbms_random.value (min_ilosc, max_ilosc)) 
        into v_ilosc from dual;
    return v_ilosc;
  end fn_daj_ilosc_produktu;

  function fn_daj_cene_produktu (v_numer_produktu number) return number as
  v_cena_produktu number;
  begin
    select cena_produktu into v_cena_produktu
    from bd4_produkt
    where nr_produktu = v_numer_produktu;
    return v_cena_produktu;  
  end fn_daj_cene_produktu;

  function fn_daj_liczbe_transakcji(min_liczba number default 1,
                                    max_liczba number default 5) return number as
  v_liczba_transakcji number;
  begin
    select round (dbms_random.value (min_liczba ,max_liczba)) 
        into v_liczba_transakcji from dual;
    return v_liczba_transakcji;
  end fn_daj_liczbe_transakcji;

end pkg_generator_danych;
/


