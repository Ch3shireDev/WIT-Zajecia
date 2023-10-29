// Moj pierwszy program w C++ ;]

# include <stdio.h>
# include <stdlib.h>

main(void) {
system("ver");
printf("\n\n");
//system("ping localhost");

char imie[20];
printf("Imie :");
scanf("%s",imie);
printf("Twoje imie to %s\n\n",imie); // :D

int o;
float a1,a2,suma;
printf("Wprowadz liczbe pierwsza:");
scanf("%f",&a1);
printf("Wprowadz liczbe druga:");
scanf("%f",&a2);
printf("Co chcesz robic?(wybierz: 1-dodac, 2-odjac, 3-podzielic, 4-pomnozyc):");
scanf("%i",&o);

if(o==1) { suma=a1+a2; }
else if(o==2) { suma=a1-a2; }
else if(o==3) { suma=a1/a2; }
else if(o==4) { suma=a1*a2; }
else { printf("NIE WYBRALES OPCJI !!!"); exit; }

printf("WYNIK : %f",suma);
system("pause");
}
/*

char zn; // znaki
int lc; // calkowite
float lf;// przecinkowe
double db; // podwojno przecinkowe?? :D

printf("
Wprowadz char: ");
scanf("%c",&zn);
printf("\nWprowadz int : ");
scanf("%i",&lc);
printf("
Wprowadz float: ");
scanf("%f",&lf);

//zn='a';
//lc=-22;
//lf=3.7;

// %c - wartosc typu "char", wstawi wartosc jaka chcemy zeby wstawil
// %i - int     %c - char    %f - float      musi sie zgadzac rozumiesz!!
printf("\n\n\nMain first programme :D\n\nwartosci zmiennych:\n");
printf("zn = %c => to jest znak\n",zn);
printf("lc = %i => to jest liczba calkowita\t:)\n",lc);
printf("lf = %f => to jest float\n\n\n\n",lf);
printf("zn jest %c\tln jest %i\tlf jest %f\n\n",zn,lc,lf);
system("pause");

}





void main2(void) {

printf("\tERA\tAAAA\r\n\r\n\r\n");
printf("**************************\n");
printf("*  M@ciej Wysocki        *\n");
printf("*                        *");
printf("\n**************************\n\n\n\n\n");

system("PAUSE");


}*/
