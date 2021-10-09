#include<stdio.h>
#include<stdlib.h>
/*******************************************************************/
typedef struct {
    int x;
    int y;
    }MyPoint;
/*******************************************************************/
MyPoint MyPacking(int, int);
int MyRead(char*);
MyPoint DoubleRead(char*, char*);
void MyPointPrint(MyPoint, char*);
/*******************************************************************/
/*******************************************************************/
MyPoint MyPacking(int x, int y){
    MyPoint myPoint;
    myPoint.x=x;
    myPoint.y=y;
    return myPoint;
    }
/*******************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
/*******************************************************************/
MyPoint DoubleRead(char* myStr1, char* myStr2){
    return MyPacking(MyRead(myStr1),MyRead(myStr2));
    }
/*******************************************************************/
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %d, y=%d",myStr, myPoint.x, myPoint.y);
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MyPoint mP1;

    mP1=DoubleRead("\tx ?=","\nmP1:\n\ty ?=");
    MyPointPrint(mP1,"\n\n****************\nmP1: ");

    MyPointPrint(DoubleRead("\n\n**************\n\tx ?=",
                            "\nEmpty:\n\ty ?="),
                 "\n\n****************\nEmpty: ");

    return 0;
    }
