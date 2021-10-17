#include<stdio.h>


int main(){
    int n;
    int i;
    int silnia=1;

    printf("n?= ");
    scanf("%d", &n);

    i = 2;

    while(i <= n){
        silnia = silnia *i;   /*1*2*3*4*/
        ++i;
        }


    printf("%d! = %d\n",n,silnia);


    return 0;
    }
