select nr_rachunku, data_sprzedazy, klient_nazwisko || ' ' || klient_imie klient, 
       	nazwa_produktu, ilosc_produktu, cena_produktu, 
		ilosc_produktu * cena_produktu wartosc_rachunku
	from bd4_klient k
    	  join bd4_rachunek r on r.nr_klienta = k.nr_klienta
    	  join bd4_produkt p on p.nr_produktu = r.nr_produktu
    order by nr_rachunku
