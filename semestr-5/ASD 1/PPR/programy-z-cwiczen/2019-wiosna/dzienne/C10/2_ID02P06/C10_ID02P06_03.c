#include<stdio.h>
#include<stdlib.h>
///213.135.45.65:7070
///**************************************************
int MyRead(char*);
int Factorial(int);
int Fibbonacci(int);
void FibbChar(int);
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
    if(n>1) return n*Factorial(n-1);
    return 1;
    }
///**************************************************
int Fibbonacci(int n){
    printf("Fibbonacci(%d)\n",n);
    if(n>2) return Fibbonacci(n-1) + Fibbonacci(n-2);
    return 1;
    }
///**************************************************
void FibbChar(int);
///**************************************************
///**************************************************
int main(){
    int n = MyRead("n!: n? = ");
    printf("%d! = %d\n",n, Factorial(n));
    printf("Fib(%d) = %d\n",n, Fibbonacci(n));

    return 0;
    }
///2, 3, 4

/**
n = 1  -> a
n = 2  -> b
n = 3  -> ba
n = 4  -> bab
n = 5  -> babba

*/
