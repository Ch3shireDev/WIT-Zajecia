///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>

///**********************************************
int MyRead(char*);
int Factorial(int);
int Fibbonacci(int);
void FibbLet(int);
///**********************************************
///**********************************************
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
///**********************************************
int Factorial(int n){
    if(n>1) return n*Factorial(n-1);
    return 1;
    }
///**********************************************
int Fibbonacci(int n){
    printf("f(%d)\n",n);
    if(n>2) return Fibbonacci(n-1) + Fibbonacci(n-2);
    return 1;
    }
///**********************************************
void FibbLet(int n){
    if(1==n) printf("a");
    if(2==n) printf("b");
    if(n>2) {
        FibbLet(n-1);
        FibbLet(n-2);
        }
    }
///**********************************************

int main(){
    int n;
    n= MyRead("n!, n? = ");
    printf("%d! = %d\n",n, Factorial(n));
    printf("f(%d) = %d\n",n, Fibbonacci(n));
    FibbLet(n);
    return 0;
    }
///2, 3, 4
