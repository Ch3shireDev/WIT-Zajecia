#include<stdio.h>
#include<stdlib.h>
/***********************************************************/
/***********************************************************/
int MyRead(char*);
int Factorial(int);
int Fibonacci(int);
/***********************************************************/
/***********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
/***********************************************************/
int Factorial(int n){
    if(n<2) return 1;
    return n*Factorial(n-1);
    }
/***********************************************************/
int Fibonacci(int n){
    if(n<3) return 1;
    return Fibonacci(n-1) + Fibonacci(n-2);
    }
/***********************************************************/
/***********************************************************/
int main(){
    int n =MyRead("n ?= ");
    printf("%d! = %d\n", n, Factorial(n));
    printf("Fibonacci(%d) = %d\n", n, Fibonacci(n));

    return 0;
    }








