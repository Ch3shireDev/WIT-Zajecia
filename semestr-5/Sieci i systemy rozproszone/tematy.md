# ZAKRES TEMATYCZNY WYKŁADÓW

## I. ZAGADNIENIA BUDOWY SYSTEMÓW ROZPROSZONYCH

### Synchronizacja w systemach rozproszonych

* Synchronizacja czasu logicznego i czasu fizycznego
* Algorytmy synchronizacji procesów
* Algorytmy elekcji

### Transakcje niepodzielne

* Założenia przetwarzania transakcyjnego
* Metody realizacji: prywatna przestrzeń robocza, 
* Protokół zatwierdzania dwufazowego
* Protokoły współbieżnego przetwarzania transakcji

### Blokady w systemach rozproszonych

* Algorytm scentralizowanego rozpoznawania blokady
* Algorytm zdecentralizowany

### Procesy i procesory w systemach rozproszonych

* Praca wielowątkowa
* Synchronizacja wątków
* Modele systemów
   - Model stacji roboczej
   - Model puli procesorów

### Zagadnienia tolerowania awarii

* Wady elementów systemu
* Awarie systemu
* Redundancja
* Zwielokrotnienie aktywne
* Zasoby rezerwowe
* Uzgodnienia w systemach wadliwych
* Przykład systemu MC Service Guard firmy Hewlett-Packard

### Wprowadzenie do zarządzania w sieciach komputerowych (opcjonalnie)

* Model zarządzania: stacja zarządzająca – „agent” na stacji roboczej
* Zmienne wykorzystywane do zarządzania
* Baza MIB
* Przykład rodziny produktów Open View firmy Hewlett Packard

### Rozproszone środowisko obliczeniowe (DCE)

## II. PODSTAWY SIECI KOMPUTEROWYCH

### Praca w intersieci (internetworking)
* Bazowe techniki sieciowe (Ethernet, FDDI, ATM)
* Specyfikacja Ethernetu. Metody dostępu do sieci.
* Budowa ramek (Ethernet, FDDI)
* Adresy logiczne i fizyczne

### Łączenie sieci w intersieć i model jej architektury. 

* Przyporządkowanie adresowi logicznemu adresu fizycznego (ARP). Przenoszenie datagramów w intersieci bez użycia  połączenia – protokół IP. 
* Format datagramu, typ obsługi datagramu, kapsułkowanie datagramu, MTU sieci i fragmentacja, opcje datagramów. 
* Wyznaczanie trasy datagramu, podstawowe zasady. 
* Analizatory protokołów sieciowych.

### Wybrane protokoły

* Komunikaty kontrolne i komunikaty o błędach - protokół ICMP. Formaty komunikatów ICMP. Wykorzystanie ICMP- ping. Przesyłanie danych niezawodnymi strumieniami – protokół TCP. Format segmentu TCP. 
* Realizacja niezawodności połączenia za pomocą TCP. 
* Porty, połączenia, pasywne i aktywne otwarcia. 
* Potwierdzenia i retransmisje. Protokół UDP.

### Modele warstwowe oprogramowania protokołów. 

* Zasady podziału na warstwy. 7-warstwowy wzorcowy model ISO-OSI. X.25 i jego związek z modelem ISO-OSI. 
* Model warstwowy TCP/IP. Podstawowe idee multiplesowania i demultipleksowania. 
* Programy użytkowe do pracy na odległym komputerze: telnet, rlogin. 
* Programy użytkowe do przesyłania plików i dostępu: ftp, tftp.

### Konfiguracja i podstawy administrowania TCP/IP

* Konfiguracja interfejsów sieciowych. Ustawienia routingu. Pliki konfiguracyjne. 
* Demon inetd. Polecenie netstat.

### Zdalne wywoływanie procedury (RPC)

* Model zdalnego wywoływania procedury. 
* Model proceduralny w systemach rozproszonych. 
* Semantyka wywołań a protokół komunikacyjny. 
* Format komunikatów Sun RPC. 
* Generowanie programów rozproszonych (generator rpcgen)

### Sieciowy system plików NFS 

* Zdalny dostęp a przesyłanie plików. Serwer i klient NFS. Montowanie systemu plików w NFS. Uchwyty do plików. Protokół montowania.

### Obsługa nazw domenowych (DNS)

* Struktura nazw domenowych. Organizacja serwerów DNS. Rekordy zasobów RR. 
* Format komunikatów DNS. 
* Pliki konfiguracyjne na serwerach DNS.

## LITERATURA PODSTAWOWA:

* Tanenbaum Andrew S. , Maarten van Steen: Systemy rozproszone, zasady i paradygmaty. WNT. Warszawa, 2006.
* Tanenbaum Andrew S. : Rozproszone systemy operacyjne. PWN. Warszawa 1997.
* Coulouris G. , J. Dollimore, T. Kindberg : Systemy rozproszone, podstawy i projektowanie. WNT, Warszawa, 1998.
* Douglas E. Comer: Sieci komputerowe i intersieci.  WNT Warszawa 2000.
* Douglas E. Comer: Sieci komputerowe TCP/IP. (Tom 1) Zasady, protokoły i architektura. WNT, Warszawa 1998.
* Larry L. Peterson, Bruce S. Davie: Sieci komputerowe – podejście systemowe.  Nikom, Poznań.2000.

