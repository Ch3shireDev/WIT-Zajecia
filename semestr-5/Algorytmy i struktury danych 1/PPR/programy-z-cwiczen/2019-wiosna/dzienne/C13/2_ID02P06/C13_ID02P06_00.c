#include<stdio.h>
#include<stdlib.h>
typedef struct{
    int aqq;
    }Ala;
int main(){
    Ala x;
    Ala*px;

    px = &x;

    x.aqq =7;

    printf("aqq = %d\n", x.aqq);
    printf("aqq = %d\n", px->aqq);

    px->aqq = 12;

    printf("aqq = %d\n", x.aqq);
    printf("aqq = %d\n", px->aqq);

    return 0;
    }
