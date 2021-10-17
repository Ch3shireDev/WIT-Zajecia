#include<stdio.h>
#include<stdlib.h>
///213.135.45.65:7070
///**************************************************
int MyRead(char*);
int Factorial(int);
///**************************************************
///**************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///**************************************************
int Factorial(int n){
    int fact;
    if(n>0) fact = n*Factorial(n-1);
    else fact = 1;
    return fact;
    }
///**************************************************
///**************************************************
int main(){
    int n = MyRead("n!: n? = ");
    printf("%d! = %d\n",n, Factorial(n));

    return 0;
    }
