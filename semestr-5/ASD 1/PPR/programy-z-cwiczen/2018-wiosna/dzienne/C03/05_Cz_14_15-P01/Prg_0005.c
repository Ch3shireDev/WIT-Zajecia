#include <stdio.h>

int main(){
    int n;
    int i;
    int silnia;

    printf("n ?=");
    scanf("%d", &n);


    silnia = 1;

    i = 2;
    while(i<=n){
        silnia *= i++;
        }


    printf("%d! = %d\n", n, silnia);

    return 0;
    }
