#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int x;

    x = rand()%501;

    printf("x = %d\n", x);

    return  0;
    }
