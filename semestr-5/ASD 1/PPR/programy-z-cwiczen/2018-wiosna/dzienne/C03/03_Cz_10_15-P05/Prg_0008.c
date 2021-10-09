#include <stdio.h>

int main(){
    int n;
    int ile;
    int suma;
    int myMax, myMin;

    printf("n?= ");
    scanf("%d", &n);

    suma = 0;
    ile = 0;

    myMax = myMin = n;

    while (0 != n){
        suma += n;
        if(myMax < n) myMax = n;
        if(myMin > n) myMin = n;
        ++ile;

        printf("n?= ");
        scanf("%d", &n);
        }

    if(0 < ile){
        printf("ile = %d\n", ile);
        printf("suma = %d\n", suma);
        printf("Max = %d\n", myMax);
        printf("min = %d\n", myMin);
        }
    else{
        printf("Brak danych\n");
        }

    return 0;
    }
