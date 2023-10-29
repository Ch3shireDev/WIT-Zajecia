//Maciej Wysocki                                                  28/02/2005     
//ID 107

/*

http://and3md.w.interia.pl/gnulibc_time_epoka_i_time_t.html

Funkcja localtime() rozbija czas unixowy (ten wyra¿ony w sekundach)
na lata, dni, godziny itd. Rozbite informacje s¹ zapisywane w strukturze tm 



Struktura tm jest standardowym sposobem zapisu czasu
skonwertowanego do lat, miesiêcy, dni, godzin, minut, sekund. 
*/

// Prosty program sluzacy do obliczania wieku...
//
// Copyright MW

#include <stdlib.h>
#include <stdio.h>
#include <time.h>

main() {
char imie[20],nazwisko[20],tekst[40];
int rok,rok2,ile_lat;
printf("\n\t**** Witaj w programie obliczajacym Twoj wiek ****");
printf("\n\n\nPodaj swoje dane\n");
printf("\n\tWpisz imie i nazwisko : ");     scanf("%s %s",imie,nazwisko);
printf("\n\tRok urodzenia : ");             scanf("%i",&rok);

time_t czas=time(0);
tm*data=localtime(&czas);
rok2=data->tm_year+1900;
ile_lat=rok2-rok;

printf("\n\n// Nazywasz sie %s %s\n// Zyjesz %i lat\n// ", nazwisko,
imie, ile_lat, tekst);
if(ile_lat<18) {
printf("Pamietaj !!! Nie mozesz legalnie kupowac papierosow i piwa ;)");
} else { printf("Gratuluje !!! Jestes dorosly ;)"); }
printf("\n\n\n\t\t# Copyright 2005 Maciej Wysocki #\n\n\n");
system("pause");
}
