#include <stdio.h>

int main(){
    int x;
    int cnt=0;
    int suma=0;

    printf("x? = ");
    scanf("%d", &x);

    while (x!=0){
        ++cnt;
        if(x%2) suma+=x;
        printf("x? = ");
        scanf("%d", &x);
        }

    printf("Liczba liczb = %d\n",cnt);
    printf("Suma nieparzystych = %d\n",suma);

    return 0;
    }
/** 2, 3

x? = 5
x? = 4
x? = 9
x? = 0

Liczba liczb = 3
Suma nieparzystych = 14




*/
