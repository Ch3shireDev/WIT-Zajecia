#include <stdio.h>
int main(){
    int x=7;
    int suma=0;

    while(0!=x){
        printf("x? = ");
        scanf("%d",&x);

        if(x%2==1) suma+=x;
        }


    printf("liczba nieparzystych = %d\n",suma);

    return 0;
    }
/** 2, 3, 4



*/
