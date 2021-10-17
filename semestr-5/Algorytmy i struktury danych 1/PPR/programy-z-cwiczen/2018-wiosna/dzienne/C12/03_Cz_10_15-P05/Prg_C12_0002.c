#include<stdio.h>
#include<stdlib.h>
/*******************************************************************/
struct{
    int x;
    int y;
    }typedef MyPoint;
/*******************************************************************/
/*******************************************************************/
MyPoint MyPacking(int, int);
int MyRead(char*);
MyPoint MyDoubleRead(char*, char*);
/*******************************************************************/
/*******************************************************************/
MyPoint MyPacking(int x, int y){
    MyPoint myPoint;

    myPoint.x = x;
    myPoint.y = y;

    return myPoint;
    }
/*******************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d", &x);
    return x;
    }
/*******************************************************************/
MyPoint MyDoubleRead(char* myStr1, char* myStr2){
    MyPoint myPoint;
    myPoint.x=MyRead(myStr1);
    myPoint.y=MyRead(myStr2);
    return myPoint;
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MyPoint p1;

    p1.x=12;
    p1.y=123;

    return 0;
    }
