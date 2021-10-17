#include <stdio.h>

int main(){
    int n;
    int ile;
    int suma;
    int myMax, myMin;

    printf("n ?= ");
    scanf("%d", &n);

    suma = 0;
    ile = 0;
    myMax = myMin = n;

    while(0 != n){
        ++ile;
        suma += n;
        if(myMax < n) myMax = n;
        if(myMin > n) myMin = n;

        printf("n ?= ");
        scanf("%d", &n);
        }

    if(ile > 0){
        printf("ile   = %d\n", ile);
        printf("suma  = %d\n", suma);
        printf("max   = %d\n", myMax);
        printf("min   = %d\n", myMin);
        }
    else{
        printf("Brak danych\n");
        }
    return 0;
    }
