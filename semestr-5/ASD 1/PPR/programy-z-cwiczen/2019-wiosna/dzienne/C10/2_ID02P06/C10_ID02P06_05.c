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
void FibbChar(int n){
    if(1 == n) printf("a");
    if(2 == n) printf("b");
    if(n > 2) FibbChar(n-1), FibbChar(n-2);
    }
///**************************************************
///**************************************************
int main(){
    int n = MyRead("n!: n? = ");
    for(int i=0;i<=n;printf("\n"),++i)
        FibbChar(i);
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
