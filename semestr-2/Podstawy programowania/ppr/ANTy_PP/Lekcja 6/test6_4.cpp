//mamy mape skladajaca sie z sektorow, ktorych jest koszt przejscia
//zuczek startuje w tym miejscu
//wypelnij tablice 2wymiarowa
//printTab2D
//albo tu albo tu
//za tydzien jest kolokwium

#define SIZEx 11
#define SIZEy 11
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define REPEAT 2000

int t[SIZEx][SIZEy];
void fillTab2D(int t[SIZEx][SIZEy],int sX, int sY);
void printTab2D(int t[SIZEx][SIZEy],int sX, int sY);

int findWayZ(int t[SIZEx][SIZEy],int sX, int sY);
int findWayR(int t[SIZEx][SIZEy],int sX, int sY, int pozX, int pozY);

main() {
int kosztZ;
clock_t start,stop;

fillTab2D(t,SIZEx,SIZEy);
printTab2D(t,SIZEx,SIZEy);

start=clock();

kosztZ=findWayZ(t,SIZEx,SIZEy);

stop=clock();

printf("Zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
printf("Koszt Z => %i",kosztZ);

getche();
}

int findWayR(int t[SIZEx][SIZEy],int sX, int sY, int pozX, int pozY) {
int c1,c2,cost;



}


int findWayZ(int t[SIZEx][SIZEy],int sX, int sY) {
int i,j;
int c1,c2; //c1-koszt przesuniecia sie na prawo,c2-do dolu
int cost; // koszt wedrowki
i=j=0;
cost=t[i][j];

while(i!=sX-1 || j!=sY-1) {

if(i==sX-1) { cost+=t[i][++j]; }
else if(j==sY-1) { cost+=t[++i][j]; }
else {
c1=t[i][j+1];
c2=t[i+1][j];
if(c1<c2) { cost+=t[i][++j]; }
else { cost+=t[++i][j]; }
}

}

return cost;

}


void printTab2D(int t[SIZEx][SIZEy],int sX, int sY) {
int tabliczka;

for(int i=0;i<sY;i++) {
for(int j=0; j<sX; j++) {
tabliczka=t[i][j];
printf("%i ",i,j,tabliczka);
}
printf("\n");
}

}

void fillTab2D(int t[SIZEx][SIZEy],int sX, int sY) {
for(int i=0; i<sY; i++) {
for(int j=0; j<sX; j++) {
t[i][j]=rand()%10;
}
}
}




