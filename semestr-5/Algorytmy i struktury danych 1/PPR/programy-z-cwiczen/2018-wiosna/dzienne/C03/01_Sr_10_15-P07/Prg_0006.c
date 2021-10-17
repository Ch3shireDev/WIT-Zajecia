#include <stdio.h>

int main(){
    int ile=0;
    int suma;
    int myMax;
    int myMin;
    int x;

    printf("x?= ");
    scanf("%d", &x);

    suma = 0;
    myMax = myMin =x;

    while(x != 0){
        if(x>myMax) myMax = x;
        if(x<myMin) myMin = x;
        suma+=x;
        ++ile;

        printf("x?= ");
        scanf("%d", &x);
        }

    if(ile>0)
        printf("suma=%d, ile=%d, Max=%d, min=%d\n",suma, ile, myMax, myMin);
    else
        printf("Brak danych");




    return 0;
    }
