///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>

///**********************************************
int MyRead(char*);
int Factorial(int);
int Fibbonacci(int);
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
    if(n>2) return Fibbonacci(n-1) + Fibbonacci(n-2);
    return 1;
    }
///**********************************************

int main(){
    int n;
    n= MyRead("n!, n? = ");
    printf("%d! = %d\n",n, Factorial(n));
    printf("f(%d) = %d\n",n, Fibbonacci(n));

    return 0;
    }
///2, 3, 4
