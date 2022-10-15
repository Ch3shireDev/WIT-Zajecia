#include <stdio.h>
int MyRead();
void MyBlackLine(int );
void MyWhiteLine(int );
void MySquare(int);
void MyTriangle(int);

/** 3b, 4b, 5b
* * * * *
  * * * *
    * * *
      * *
        *
*/

/**************************************************************/
/**************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);
    return x;
    }
/**************************************************************/
void MyBlackLine(int x){
    int j;
    for(j=0; j<x; ++j)
            printf("* ");
    }
/**************************************************************/
void MyWhiteLine(int x){
    int j;
    for(j=0; j<x; ++j)
            printf("  ");
    }
/**************************************************************/
void MySquare(int x){
    int i;
    for(i=0; i<x;++i){
        MyBlackLine(x);
        printf("\n");
        }
    }
/**************************************************************/
void MyTriangle(int x){
    int i;
    for(i=0; i<x;++i){
        MyWhiteLine(i);
        MyBlackLine(x-i);
        printf("\n");
        }
    }
/**************************************************************/
/**************************************************************/
int main(){
    MyTriangle(MyRead());
    return 0;
    }
