#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int silnia(int n);
long double czas();

main() {
int s,result;
long double t1,t2;

printf("Oblicz silnie z : ");   scanf("%i",s);
t1=czas();

for(float i=0; i<20000000000; i++) {
result=silnia(s);
}

t2=czas()-t1;
printf("Silnia = %i // Czas robienia = %ld",result,t2);
getche();

}


long double czas() {
time_t aktualnyczas;
aktualnyczas=time(0);
return aktualnyczas;
}

}

int silnia(int n) {
int pom;
pom=1;
while(n>0) {
pom=n*pom;
n--;
}
return pom;
}

