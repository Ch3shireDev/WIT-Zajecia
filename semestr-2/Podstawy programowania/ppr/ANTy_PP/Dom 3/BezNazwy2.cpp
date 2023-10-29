/*





*/
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

void showKwadrat(int bok, char autor[20]);
int x;
int showPole(int a);


int showPole(int a) {
return a*a;
}


void showKwadrat(int bok, char autor[20]) {

int o=0;

for(int z=1; z<=bok; z++){
printf("#");
if(z==bok) { z=0; o++; printf("\n"); }
if(o==bok) { break; }
}
printf("\nAutor %s",autor);

}





main() {

printf("Dlugosc boku : ");
scanf("%i",&x);
printf("\n\n");
showKwadrat(x,"Maciek");

printf("\n\nPole kwadratu o boku %i wynosi %i",x,showPole(x));


getche();

}
