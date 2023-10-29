#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

// podaj cyfre, pokaz jaki miesiac



main() {
int aaa;
printf("c miesiaca");
scanf("%i",&aaa);


switch(aaa) {
case 1 : printf("Styczen"); break;
case 2 : printf("Luty"); break;
case 3 : printf("Marzec"); break;
case 4 : printf("Kwiecien"); break;
case 5 : printf("Maj"); break;
case 6 : printf("Czerwiec"); break;
case 7 : printf("Lipiec"); break;
case 8 : printf("Sierpien"); break;
case 9 : printf("Wrzesien"); break;
case 10 : printf("pazdz"); break;
case 11 : printf("list"); break;
case 12 : printf("gru"); break;
default : printf("nie ma %i",aaa);
         }
printf("\n\nNacisnij ENTER");         
getche();


}
