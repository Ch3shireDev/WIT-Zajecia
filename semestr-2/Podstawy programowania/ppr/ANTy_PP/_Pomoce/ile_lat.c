/*Program liczy wiek osoby*/
#include <stdio.h>
void main()
{
 int rok_urodzenia, akt_rok=2003;
int wiek;
printf("Witam!!!\n");
printf("Program do obliczania wieku.\n\n");
printf("Podaj date urodzenia: ");
scanf("%i", &rok_urodzenia);
wiek=akt_rok-rok_urodzenia;
printf(
"\nUrodzles sie w %i roku, teraz jest %i rok,\nwiec masz %i lat.",
rok_urodzenia,akt_rok,wiek);
}
