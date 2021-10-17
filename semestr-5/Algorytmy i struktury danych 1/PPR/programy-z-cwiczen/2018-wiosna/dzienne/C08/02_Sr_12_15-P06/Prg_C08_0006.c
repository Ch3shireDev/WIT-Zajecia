#include<stdio.h>
#include<stdlib.h>
/*********************************************************************/
/*********************************************************************/
int MyRead();
void MyFig(int, void(*mF)(int));
void BlackLine(int);
void WhiteLine(int);
void GrowLine(int);
void Triangle1(int);
void Triangle2(int);
/*********************************************************************/
/*********************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/*********************************************************************/
void MyFig(int x, void(*mF)(int)){
    int i;
    for(i=0; i<x;++i){
        mF(x);
        printf("\n");
        }
    }
/*********************************************************************/
void BlackLine(int x){
    int i;
    for(i=0; i<x;++i)
        printf(" *");
    }
/*********************************************************************/
void WhiteLine(int x){
    int i;
    for(i=0; i<x;++i)
        printf(" _");
    }
/*********************************************************************/
void GrowLine(int x){
    int i;
    for(i=0; i<x;++i){
        WhiteLine(i+1);
        BlackLine(i+1);
        }
    }
/*********************************************************************/
void Triangle1(int x){
    int i;
    for(i=0; i<x;++i){
        BlackLine(x-i);
        printf("\n");
        }
    }
/*********************************************************************/
void Triangle2(int x){
    int i;
    for(i=0; i<x;++i){
        BlackLine(i+1);
        printf("\n");
        }
    }
/*********************************************************************/
/*********************************************************************/
int main(){
    int x;
    x = MyRead();
    BlackLine(x);
    printf("\n\n");
    MyFig(x, BlackLine);
    printf("\n");
    MyFig(x, GrowLine);
    printf("\n");
    MyFig(x, Triangle1);
    printf("\n");
    MyFig(x, Triangle2);
    /** 6b, 7b, 8b
    x ?= 3
     * * *

     * * *
     * * *
     * * *

     _ * _ _ * * _ _ _ * * *
     _ * _ _ * * _ _ _ * * *
     _ * _ _ * * _ _ _ * * *

     * * *
     * *
     *

     * * *
     * *
     *

     * * *
     * *
     *

     *
     * *
     * * *

     *
     * *
     * * *

     *
     * *
     * * *
    */



    return 0;
    }










