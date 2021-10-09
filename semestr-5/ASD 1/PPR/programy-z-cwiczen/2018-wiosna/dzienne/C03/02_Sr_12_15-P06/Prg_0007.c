#include<stdio.h>


int main(){
    int x;
    int ile=0;
    int suma=0;
    int myMax, myMin;

    printf("x?= ");
    scanf("%d", &x);

    myMax = myMin = x;

    while(x != 0){
        suma+=x;
        ++ile;
        if(x > myMax) myMax = x;
        if(x < myMin) myMin = x;

        printf("x?= ");
        scanf("%d", &x);
        }

    if(ile>0){
        printf("suma = %d\n",suma);
        printf("ile = %d\n",ile);
        printf("max = %d\n",myMax);
        printf("min = %d\n",myMin);
        }
    else{
        printf("Brak danych\n");
        }

    return 0;
    }
