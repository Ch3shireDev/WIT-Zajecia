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
void MyPointPrint(MyPoint, char*);
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
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %d, y = %d", myStr, myPoint.x, myPoint.y);
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MyPoint p1;
    p1 = MyDoubleRead("x ?=", "y ?=");
    MyPointPrint(p1,"\n*************** \np1: ");
    MyPointPrint(p1,"\n");

    MyPointPrint(MyDoubleRead("\n>x ?=", ">y ?="),"\nempty: ");

    return 0;
    }
