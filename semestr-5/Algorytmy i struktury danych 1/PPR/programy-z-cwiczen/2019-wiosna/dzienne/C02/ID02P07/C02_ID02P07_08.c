#include <stdio.h>
int main(){
    int x=7;
    int suma=0;
    int licz=0;
    printf("x? = ");
    scanf("%d",&x);

    while(0!=x){
        if(x%2==1) suma+=x;
        ++licz;
        printf("x? = ");
        scanf("%d",&x);
        }


    printf("suma nieparzystych = %d\n",suma);
    printf("liczba liczb = %d\n",licz);

    return 0;
    }
/** 2, 3, 4



*/
