/*
wyswietl menu


t-drojkat,k-kwadrat,o-okrag,p-prostokat
*/

#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

main() {

char figura,fig;
float pole;
printf("podaj figure : t-drojkat,k-kwadrat,o-okrag,p-prostokat a oblicze jego pole : ");
scanf("%c",&figura);
if(figura=='T' || figura=='t'){fig='T';}
else if(figura=='K' || figura=='k'){fig='K';}
else if(figura=='O' || figura=='o'){fig='O';}
else if(figura=='P' || figura=='p'){fig='P';}
float A,B,C,D;
switch(fig) {
case 'K' : printf("Podaj bok kwadratu : "); scanf("%f",&A); pole=A*A; printf("\n\nPole kwadratu = %f",pole); break;
case 'P' : printf("Podaj 1 bok prostokata : "); scanf("%f",&A); printf("Podaj 2 bok prostokata : "); scanf("%f",&B);
pole=A*B; printf("\n\nPole prostokata = %f",pole); break;
case 'T' : printf("Podaj dlugosc podstawy : "); scanf("%f",&A);
printf("Podaj wysokosc : "); scanf("%f",&B);
pole=(1/2)*A*B; printf("\n\nPole trojkata = %f",pole); break;
case 'O' : printf("Podaj promien r :");


default : printf("Jakas dziwna figure wybrales!? %c",figura);
}



getche();
}
